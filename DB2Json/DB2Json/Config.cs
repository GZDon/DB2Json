using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBtoJson_Func
{
    public class Config
    {
        public string JsonDataFormatPath { get; set; } = @"C:\Common\DBtoJSON\Setting\JsonDataFormat.txt";
        public string DBSettingPath { get; set; } = @"C:\Common\DBtoJSON\Setting\DBSetting.txt";
        public string ConfigKey { get; set; }
        public string Con_name { get; set; }
        public string SorceTable { get; set; }
        public JObject Data { get; set; }
    }
}
