using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.Storage;

namespace DBtoJSON
{
    public partial class DBtoJson_Form : Form
    {
        static SqlConnection con = new SqlConnection();
        private string JsonString = string.Empty;
        private DataTable dataTable = new DataTable();

        public DBtoJson_Form()
        {
            InitializeComponent();
        }
        private void BackMenu_Click(object sender, EventArgs e)
        {
            Con_name = string.Empty;
            SorceTable = string.Empty;
            ConfigName = string.Empty;
            JsonFormat = string.Empty;
            FieldJson = string.Empty;
            SwitchForm(new Form1(), this);
        }

        private void DBtoJson_Form_Load(object sender, EventArgs e)
        {
            
            JObject json = new JObject();
            StreamReader DB_sr = new StreamReader(DBFilePath);
            StreamReader Json_sr = new StreamReader(JsonFilePath);
            string line = string.Empty;
            string result = string.Empty;

            line = DB_sr.ReadLine();
            while (line != null)
            {
                result += line;
                line = DB_sr.ReadLine();
            }
            if (result != "")
            {
                json = JObject.Parse(result);
            }
            DB_sr.Close();
            foreach (JProperty Prop in json.Properties())
            {
                Connetion_Combo.Items.Add(Prop.Name.ToString());
            }
            result = string.Empty;
            line = Json_sr.ReadLine();
            while (line != null)
            {
                result += line;
                line = Json_sr.ReadLine();
            }
            if (result != "")
            {
                json = JObject.Parse(result);
            }
            Json_sr.Close();
            foreach (JProperty Prop in json.Properties())
            {
                JsonFormat_Combo.Items.Add(Prop.Name.ToString());
            }
            if (Con_name != "")
            {
                Connetion_Combo.SelectedItem = Con_name;
                Table_Combo.SelectedItem = SorceTable;
                JsonFormat_Combo.SelectedItem = JsonFormat;
                ConfigName_text.Text = ConfigName;
            }
        }

        private void Connetion_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            JObject json = new JObject();
            StreamReader sr = new StreamReader(DBFilePath);
            string line = string.Empty;
            string result = string.Empty;
            string Source = string.Empty;
            string DB = string.Empty;
            string User = string.Empty;
            string PWD = string.Empty;

            line = sr.ReadLine();
            while (line != null)
            {
                result += line;
                line = sr.ReadLine();
            }
            if (result != "")
            {
                json = JObject.Parse(result);
            }
            sr.Close();
            foreach (JProperty Prop in json.Properties()) 
            {
                if(Prop.Name.ToString() == Connetion_Combo.SelectedItem.ToString()) 
                {
                    Source = Prop.Value["SeverName"].ToString();
                    DB = Prop.Value["Database"].ToString();
                    User = Prop.Value["Account"].ToString();
                    PWD = Prop.Value["Password"].ToString();
                }
            }
            
            con = new SqlConnection($@"Data Source={Source};Initial Catalog={DB}; User={User};Password={PWD}");
            try
            {
                con.Open();
                using (SqlCommand Cmd = new SqlCommand())
                {
                    Cmd.CommandText = @"SELECT * FROM Information_Schema.TABLES ORDER BY TABLE_NAME";
                    Cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter(Cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataTable = ds.Tables[0];
                    JsonString = JsonConvert.SerializeObject(dataTable);
                }
                con.Close();
                Table_Combo.Items.Clear();
                foreach (dynamic datas in JArray.Parse(JsonString))
                {
                    foreach (JProperty data in datas)
                    {
                        if(data.Name.ToString() == "TABLE_NAME")
                        {
                            Table_Combo.Items.Add(data.Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void BindField_btn_Click(object sender, EventArgs e) // 設定對應欄位按鈕
        {
            // JsonFormat_Combo.SelectedItem => Json格式下拉選單值
            if (JsonFormat_Combo.SelectedItem == null) 
            {
                MessageBox.Show("請選取Json格式!!");
            }
            else
            {
                bool Check = true;
                JObject json = new JObject();
                StreamReader JsonSetting_sr = new StreamReader(JsonSettingPath); // 讀取JsonSetting.txt內容
                string line = string.Empty;
                string result = string.Empty;

                line = JsonSetting_sr.ReadLine();
                while (line != null)
                {
                    result += line;
                    line = JsonSetting_sr.ReadLine();
                }
                if (result != "")
                {
                    json = JObject.Parse(result);
                }
                JsonSetting_sr.Close();
                foreach (JProperty Prop in json.Properties())
                {
                    if (Prop.Name.ToString() == ConfigName_text.Text)
                    {
                        var confirmResult = MessageBox.Show(
                                            "設定檔名稱重複!! 是否要覆蓋舊資料 ?",
                                            "名稱重複!",
                                            MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.No)
                        {
                            Check = false;
                        }
                    }
                }
                if (Check) 
                {
                    Con_name = Connetion_Combo.SelectedItem.ToString();
                    SorceTable = Table_Combo.SelectedItem.ToString();
                    ConfigName = ConfigName_text.Text;
                    JsonFormat = JsonFormat_Combo.SelectedItem.ToString();

                    SwitchForm(new BindDBField_Form(), this);
                }
                
            }
        }

        private void Table_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand Cmd = new SqlCommand())
            {
                Cmd.CommandText = @"SELECT COLUMN_NAME FROM Information_Schema.COLUMNS WHERE TABLE_NAME = @TableName ORDER BY COLUMN_NAME";
                Cmd.Connection = con;
                Cmd.Parameters.AddWithValue("@TableName", Table_Combo.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataTable = ds.Tables[0];
                FieldJson = JsonConvert.SerializeObject(dataTable);
            }
            con.Close();
        }
        private void JsonFormat_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
