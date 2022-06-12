using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DBtoJSON.Models
{
    public static class Storage
    {
        public static JObject Data = new JObject();
        public static Form LastForm = new Form();
        public static string pathString = @"C:\\Common\\DBtoJSON\\Setting";
        public static string DBFilePath = pathString + "\\DBSetting.txt";
        public static string JsonFilePath = pathString + "\\JsonFormat.txt";
        public static string JsonSettingPath = pathString + "\\JsonSetting.txt";
        public static string Con_name = string.Empty;
        public static string SorceTable = string.Empty;
        public static string ConfigName = string.Empty;
        public static string JsonFormat = string.Empty;
        public static string FieldJson = string.Empty;
        public static string EditField = string.Empty;
        public static JObject MainJson = new JObject();
        public static JObject DetailJson = new JObject();
        // ----------------------------------------------
        public static int ParentLevel = 0; // 上頁
        public static int CurrentLevel = 0; // 目前頁
        public static JArray DetailLevelData = new JArray();
        public static JObject MappingJson = new JObject();
        public static string ParentKey = string.Empty;

        public static JObject GlobalJson = new JObject();
        public static List<string> GlobalLevel = new List<string>();
        // -----
        public static string Data_Source = string.Empty;
        public static string JsonDataFormatPath = Path.Combine(pathString, "JsonDataFormat.txt"); // .
        public static string JsonDataSettingPath = Path.Combine(pathString, "JsonDataSetting.txt"); // . 
        public static JObject SettingData = new JObject();
        public static JArray FieldJsonJArr = new JArray();

        public static string DataConfigKey = string.Empty;
        public static JObject Data_GlobalJson = new JObject();
        public static List<string> Data_GlobalLevel = new List<string>();

        public static string Data_Con_name = string.Empty;
        public static string Data_SorceTable = string.Empty;
        public static JObject Data_GlobalJson_Config = new JObject();
    }
} 
