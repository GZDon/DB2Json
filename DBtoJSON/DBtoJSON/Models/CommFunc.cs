using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DBtoJSON.Models
{
    class CommFunc
    {
        // -----Dong
        public static bool IsJObject(string str)
        {
            bool res = true;
            try
            {
                JObject.Parse(str);
                res = true;
            }
            catch 
            {
                res = false;
            }
            return res;
        }
        public static bool IsJArray(string str)
        {
            bool res = true;
            try
            {
                JArray.Parse(str);
                res = true;
            }
            catch
            {
                res = false;
            }
            return res;
        }

        public static void SetJson(JObject GlobalJson, List<string> GlobalLevel, dynamic SetJsonData) // 目前位置上層
        {
            dynamic ParentJson = GlobalJson; // 最外層
            if (GlobalLevel.Count > 0) // 有內層
            {
                for (var i = 0; i < GlobalLevel.Count; i++)
                {
                    if (ParentJson[GlobalLevel[i]].GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                    { 
                        ParentJson = (JObject)(ParentJson[GlobalLevel[i]]);
                    }else if(ParentJson[GlobalLevel[i]].GetType().ToString() == "Newtonsoft.Json.Linq.JArray")
                    {
                        ParentJson = (JArray)(ParentJson[GlobalLevel[i]]);
                    }
                }
            }
            

            if(SetJsonData.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
            {
                foreach(JProperty Prop in SetJsonData.Properties())
                {
                    ParentJson[Prop.Name] = Prop.Value;
                }
            }else if(SetJsonData.GetType().ToString() == "Newtonsoft.Json.Linq.JArray")
            {
                int i = 0;
                foreach (dynamic arr in SetJsonData)
                {
                    ParentJson[i] = arr.ToString();
                    i++;
                }
            }
        }


        public static JObject ReadTxtToJObject(string filePath)
        {
            JObject TxtContent = new JObject();
            using(StreamReader st = new StreamReader(filePath))
            {
                try
                {
                    TxtContent = JObject.Parse(st.ReadToEnd());
                }
                catch(Exception ex)
                {
                    TxtContent.Add("ReadTxtError", ex.Message);
                }
            }
            return TxtContent;
        }

    }
}
