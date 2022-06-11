using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace DBtoJson_Func
{
    public static class GetData
    {
        
        public static string ConnString  = string.Empty;

        public static JArray GetJson(Config con)
        {
            JObject JsonConfig = JObject.Parse(ReadTxtToJson(con.JsonDataFormatPath)[con.ConfigKey].ToString());
            Config ConfigData = JsonConvert.DeserializeObject<Config>(JsonConfig.ToString());

            try
            {
                JObject DBSetting = JObject.Parse(ReadTxtToJson(ConfigData.DBSettingPath)[ConfigData.Con_name].ToString());

                ConnString = $@"Data Source={DBSetting["SeverName"].ToString()};Initial Catalog={DBSetting["Database"].ToString()}; User={DBSetting["Account"].ToString()};Password={DBSetting["Password"].ToString()}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error -----> " + ex.Message);
            }

            JObject Data = (JObject)ConfigData.Data;
            JArray MappingData = new JArray();

            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                Conn.Open();
                using (SqlCommand SelCmd = new SqlCommand(ConfigData.SorceTable, Conn))
                {
                    SqlDataReader rd = SelCmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            Dictionary<string, string> DBData = new Dictionary<string, string>();

                            for (int i = 0; i < rd.FieldCount; i++)
                            {
                                DBData.Add(rd.GetName(i), rd[i].ToString());
                            }
                            MappingData.Add(JsonLoop(Data, DBData));
                        }
                    }
                }
                Conn.Close();
            }



            return MappingData;
        }

        public static JObject ReadTxtToJson(string FilePath) // 讀取Txt檔案
        {
            string txtContent = string.Empty;
            using (StreamReader stream = new StreamReader(FilePath))
            {
                txtContent = stream.ReadToEnd();
            }
            return JObject.Parse(txtContent);
        }

        public static dynamic JsonLoop(dynamic JsonData, Dictionary<string, string> DBData) // 透過遞迴將每個對應欄位組合
        {
            JObject json = new JObject();
            if (JsonData != null)
            {
                if (JsonData.GetType().ToString() == "Newtonsoft.Json.Linq.JValue")
                {
                    return DBData[JsonData.ToString()];
                }
                else if (JsonData.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                {
                    foreach (JProperty Prop in JsonData.Properties())
                    {
                        if (Prop.Value.Type.ToString() == "String")
                        {
                            // json.Add(Prop.Name, GetSqlData(@"Server=LAPTOP-HHM7QL7D;Database=Test;Trusted_Connection=True;User ID=sa;Password=sa", "DBtoJSON_TEST1", (string)Prop.Value));
                            json.Add(Prop.Name, DBData[(string)Prop.Value]);
                        }
                        else if (Prop.Value.Type.ToString() == "Object")
                        {
                            json.Add(Prop.Name, JsonLoop((JObject)Prop.Value, DBData));
                        }
                        else if (Prop.Value.Type.ToString() == "Array")
                        {
                            JArray JArr = new JArray();
                            Prop.Value.ToList().ForEach(arr =>
                            {
                                JArr.Add(JsonLoop(arr, DBData));
                            });
                            json.Add(Prop.Name, JArr);
                        }
                    }
                }
            }
            return json;
        }
    }
}
