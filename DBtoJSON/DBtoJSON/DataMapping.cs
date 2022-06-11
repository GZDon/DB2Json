using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static DBtoJSON.Models.Storage;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.CommFunc;
using Newtonsoft.Json.Linq;
using DBtoJSON.Models;

namespace DBtoJSON
{
    public partial class DataMapping : Form
    {
        private dynamic Json;
        public DataMapping(dynamic JsonData)
        {
            InitializeComponent();
            MessageBox.Show("JsonData: " + JsonData);
            Json = JsonData;
        }

        private void DataMapping_Load(object sender, EventArgs e) // Form Load 
        {
                DataMapping_AddItem(Json, FieldJson, this);

        }
        private void Save_btn_Click(object sender, EventArgs e) // Save btn
        {
            bool Check = true;
            // JObject SettingJson = new JObject();
            dynamic SettingJson = null;

            if (this.Controls.ContainsKey("ArrayName_Label")) // 目前頁是Array
            {
                SettingJson = new JArray();
                foreach (Control control in this.Controls) // 遍歷所有Control內容
                {
                    if (control.GetType().Name == "ComboBox") // 若Control中有ComboBox
                    {
                        if ((control as ComboBox).SelectedItem != null) // ComboBox 內容不為null
                        {
                            SettingJson.Add((control as ComboBox).SelectedItem.ToString()); // 將此ComboBox內容 加進SettingJson中
                        }
                        else // ComboBox 內容為null
                        {
                            Check = false;
                        }
                    }
                }
            }
            else
            {
                SettingJson = new JObject();
                foreach (Control control in this.Controls) // 遍歷所有Control內容
                {
                    if (control.GetType().Name == "ComboBox") // 若Control中有ComboBox
                    {
                        if ((control as ComboBox).SelectedItem != null) // ComboBox 內容不為null
                        {
                            SettingJson[control.Name] = (control as ComboBox).SelectedItem.ToString(); // 將此ComboBox內容 加進SettingJson中
                        }
                        else // ComboBox 內容為null
                        {
                            Check = false;
                        }
                    }
                }
            }
            if (Check)
            {
                DetailJson[EditField] = SettingJson;
                // SwitchForm(new BindDBField_Form(), this); // 回到首頁



                dynamic SetJsonData = SettingJson;

                MessageLabel.Text = "Data_GlobalJson: \r\n" + Data_GlobalJson.ToString() + "\r\n";
                MessageLabel.Text += "Data_GlobalLevel: \r\n  - " + string.Join(", ", Data_GlobalLevel) + "\r\n";


                CommFunc.SetJson(Data_GlobalJson, Data_GlobalLevel, SetJsonData); // ------------------------------------------------

                MessageLabel.Text += "-----\nData_GlobalJson: \r\n" + Data_GlobalJson.ToString();
                // GlobalLevel.Clear(); // 返回到BindDBField，清空List

            }
            else
            {
                MessageBox.Show("請選擇對應欄位!!");
            }
        }

        private void BackDBtoJson_Click(object sender, EventArgs e) // Back 
        {
            SwitchForm(new JsonData(), this);
        }

        private void SettingDone_Click(object sender, EventArgs e) // Write JsonDataSetting to Flie
        {
            var confirmResult = MessageBox.Show("請問是否設定完成", "請確認", MessageBoxButtons.YesNo);
            if(confirmResult.ToString() == "Yes")
            {
                try
                {
                    JObject JsonDataFormat = ReadTxtToJObject(JsonDataFormatPath);
                    if (Data_GlobalJson_Config.ContainsKey(DataConfigKey))
                    {
                        Data_GlobalJson_Config[DataConfigKey] = new JObject() {
                            new JProperty("Con_name", Data_Con_name),
                            new JProperty("SorceTable", Data_SorceTable),
                            new JProperty("Data", Data_GlobalJson)
                        }; // 將資料來源、資料格式組合
                    }
                    else
                    {
                        Data_GlobalJson_Config.Add(DataConfigKey, new JObject() {
                            new JProperty("Con_name", Data_Con_name),
                            new JProperty("SorceTable", Data_SorceTable),
                            new JProperty("Data", Data_GlobalJson)
                        }); // 將資料來源、資料格式組合
                    }

                    try
                    {
                        File.WriteAllText(JsonDataFormatPath, Data_GlobalJson_Config.ToString());
                        // 舊資料清空
                        Data_Con_name = string.Empty;
                        Data_Source = string.Empty;
                        DataConfigKey = string.Empty;
                        Data_GlobalJson = new JObject();
                        Data_GlobalLevel = new List<string>();
                        Data_Con_name = string.Empty;
                        Data_SorceTable = string.Empty;
                        Data_GlobalJson_Config = new JObject();

                        MessageBox.Show("設定成功!!");
                        SwitchForm(new Form1(), this);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"寫入錯誤!! 1\n錯誤訊息: {ex.Message}");
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show($"寫入錯誤!! 2\n錯誤訊息: {ex.Message}");
                }

            }
        }
    }
}
