using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Storage;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.CommFunc;

namespace DBtoJSON
{
    public partial class JsonDataSetting : Form
    {
        private JObject JsonDataFormat = new JObject();
        public JsonDataSetting()
        {
            InitializeComponent();
            // 初始化Mapping欄位的JSON Array資料 
            DetailLevelData = new JArray();
        }

        private void JsonDataSetting_Load(object sender, EventArgs e) // Form Load
        {
            // 初始化目前頁數
            CurrentLevel = 0;


            JsonDataFormat = ReadTxtToJObject(JsonDataSettingPath);
            if (!JsonDataFormat.ContainsKey("Error"))
            {
                foreach (JProperty Prop in JsonDataFormat.Properties())
                {
                    DataFormat_Combo.Items.Add(Prop.Name); // 設定 設定檔Combo資料
                }
            }
            else
            {
                MessageBox.Show(JsonDataFormat["Error"].ToString());
            }
        }

        private void DataFormat_Combo_SelectedIndexChanged(object sender, EventArgs e) // 設定檔 Combo
        {
            SettingData.RemoveAll(); // 清空舊紀錄
            SettingData = ReadTxtToJObject(JsonDataSettingPath);
            SettingData = JObject.Parse(SettingData[DataFormat_Combo.Text].ToString());
        }

        private void Save_btn_Click(object sender, EventArgs e) // Save btn
        {
            DataConfigKey = DataFormat_Combo.Text;
            Data_GlobalJson = JObject.Parse(JsonDataFormat[DataFormat_Combo.Text].ToString()); // 找到此設定檔格式，存入 Data_GlobalJson
            SwitchForm(new DataMapping(Data_GlobalJson), this);
        }

        private void BackDBtoJson_Click(object sender, EventArgs e) // Back btn
        {
            Data_Source = string.Empty;
            SwitchForm(new JsonData(), this);
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
