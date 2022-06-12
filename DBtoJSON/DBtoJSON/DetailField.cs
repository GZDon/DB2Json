using DBtoJSON.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.Storage;

namespace DBtoJSON
{
    public partial class DetailField : Form
    {
        // private JObject Json = new JObject();
        private dynamic Json;
        
        public DetailField(dynamic JsonData)
        {
            InitializeComponent();
            Json = JsonData;
        }
        private void DetailField_Load(object sender, EventArgs e) // 載入DB對應欄位設定頁
        {
            MessageLabel.Text = "GlobalJson: \r\n" + GlobalJson.ToString() + "\r\n"; // -------------------------------------
            MessageLabel.Text += "GlobalLevel: \r\n" + string.Join(", ", GlobalLevel) + "\r\n"; // -------------------------------------
            
            AddItem(Json, FieldJson, this);
            if (DetailJson[EditField] != null)
            {
                foreach (Control control in this.Controls) // 將值放入 ComboBox 中
                {
                    if (control.GetType().Name == "ComboBox")
                    {
                        string Value = JObject.Parse(DetailJson[EditField].ToString())[control.Name].ToString();
                        (control as ComboBox).SelectedItem = Value;
                    }
                }
            }
        }
        private void Save_btn_Click(object sender, EventArgs e) // 儲存按鈕
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
                
                MessageLabel.Text = "GlobalJson: \r\n" + GlobalJson.ToString() + "\r\n";
                MessageLabel.Text += "GlobalLevel: \r\n  - " + string.Join(", ", GlobalLevel) + "\r\n";


                CommFunc.SetJson(GlobalJson, GlobalLevel, SetJsonData); // ------------------------------------------------

                MessageLabel.Text += "-----\nGlobalJson: \r\n" + GlobalJson.ToString();
                // GlobalLevel.Clear(); // 返回到BindDBField，清空List

            }
            else
            {
                MessageBox.Show("請選擇對應欄位!!");
            }
            
        }

        private void Back_Click(object sender, EventArgs e) // 返回按鈕
        {
            EditField = string.Empty;
            // SwitchForm(new BindDBField_Form(), this); // 回到欄位設定首頁 (第一頁)

            

            CurrentLevel--;            
            if(CurrentLevel <= 0)
            {
                GlobalLevel.Clear(); // 返回 清除所有Item
                SwitchForm(new BindDBField_Form(), this); // 回到欄位設定首頁 (第一頁)
            }
            else
            {
                GlobalLevel.RemoveAt(GlobalLevel.Count - 1); // 返回 刪除最後一個Item
                int backPageNum = CurrentLevel - 1;
                SwitchForm(new DetailField(JObject.Parse(DetailLevelData[backPageNum].ToString())), this);
                MessageBox.Show("CurrentLeave: " + CurrentLevel.ToString() + "\r\nDetailLeaveData: " + DetailLevelData); // 返回上一頁
            }
            
        }
    }
}
