using DBtoJSON.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.Storage;

namespace DBtoJSON
{
    public partial class BindDBField_Form: Form
    {
        public BindDBField_Form()
        {
            InitializeComponent();
            // 初始化Mapping欄位的JSON Array資料 
            DetailLevelData = new JArray();
        }

        private void BackDBtoJson_Click(object sender, EventArgs e) // 回到主畫面，清空資料內容
        {
            DetailJson = new JObject();
            MainJson = new JObject();
            SwitchForm(new DBtoJson_Form(), this);

            GlobalLevel.Clear(); // 回到主畫面，清空List
            GlobalJson = new JObject(); // 回到主畫面，清空GlobalJson
        }

        private void Save_btn_Click(object sender, EventArgs e) // "設定完成"按鈕
        {
            MessageLabel.Text = "Save_btn_Click -----> SetFormJson() : \r\n" + SetFormJson().ToString();
            bool Check = true;
            // JObject Result = SetFormJson();

            JObject Result = new JObject();
            Result.Add("ErrorMsg", string.Empty);

            JObject SetJsonData = new JObject();
            string ErrorMsg = string.Empty;
            foreach (Control control in this.Controls)
            {
                string controlName = control.Name;

                if (control.GetType().Name == "ComboBox")
                {
                    if ((control as ComboBox).SelectedItem != null)
                    {
                        SetJsonData[controlName] = (control as ComboBox).SelectedItem.ToString();
                    }
                    else
                    {
                        ErrorMsg += controlName + "欄位尚未設定 \n";
                    }
                }
            }


            CommFunc.SetJson(GlobalJson, GlobalLevel, SetJsonData);

            MessageBox.Show("GlobalJson : \r\n" + GlobalJson);

            ErrorMsg = Result["ErrorMsg"].ToString();

            // JObject Data = JObject.Parse(Result["Data"].ToString());
            JObject Data = GlobalJson;
            if (ErrorMsg != "") 
            {
                Check = false;
            }
            if (Check)
            {
                try
                {
                    JObject json = new JObject();
                    //檢查檔案是否存在
                    if (File.Exists(JsonSettingPath))
                    {
                        StreamReader sr = new StreamReader(JsonSettingPath);
                        string line = string.Empty;
                        string result = string.Empty;

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
                    }
                    json[ConfigName] = new JObject();
                    //JObject settinginfo = JObject.Parse(json[ConfigName].ToString());
                    json[ConfigName]["Con_name"] = Con_name;
                    json[ConfigName]["SorceTable"] = SorceTable;
                    json[ConfigName]["Data"] = Data;
                    //寫入檔案
                    StreamWriter sw = new StreamWriter(JsonSettingPath);
                    sw.WriteLine(JsonConvert.SerializeObject(json));
                    sw.Close();
                    MessageBox.Show("新增成功!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                MainJson = Data;
                SwitchForm(new DBtoJson_Form(), this);
            }
            else
            {
                MessageBox.Show(ErrorMsg);
            }
        }

        private void BindDBField_Form_Load(object sender, EventArgs e) // BindDBField_Form 載入觸發
        {
            // 初始化目前頁數
            CurrentLevel = 0;
            MessageLabel.Text = "DetailJson: \r\n" + DetailJson.ToString() + "\r\n";
            

            JObject json = new JObject();
            StreamReader sr = new StreamReader(JsonFilePath); // 讀取JsonFormat.txt檔案
            string line = string.Empty;
            string result = string.Empty;
            string JsonString = string.Empty;
            line = sr.ReadLine();
            while (line != null)
            {
                result += line;
                line = sr.ReadLine();
            }
            if (result != "")
            {
                json = JObject.Parse(result); // 將檔案內容轉為JSON格式
            }
            sr.Close();

            foreach (JProperty Prop in json.Properties()) // 透過迴圈找到 欲設定的JSON格式
            {
                if (Prop.Name.ToString() == JsonFormat)
                {
                    JObject jsondata = JObject.Parse(Prop.Value.ToString());

                    if(GlobalJson.Count == 0)
                    {
                        GlobalJson = JObject.Parse(Prop.Value.ToString());
                    }

                    AddItem(jsondata, FieldJson, this);
                }
            }

            foreach (Control control in this.Controls)
            {
                string controlName = control.Name;

                if (control.GetType().Name == "ComboBox")
                {
                    if (MainJson[controlName] != null) 
                    {
                        (control as ComboBox).SelectedItem = MainJson[controlName].ToString() ;
                    }
                    (control as ComboBox).SelectedIndexChanged += SelectItemChange;
                }
            }
        }
        private JObject SetFormJson() // 把JSON組好 /////基本上沒用到
        {
            JObject Result = new JObject();
            string ErrorMsg = string.Empty;
            JObject SettingJson = new JObject();
            foreach (Control control in this.Controls)
            {
                string controlName = control.Name;

                if (control.GetType().Name == "ComboBox")
                {
                    if ((control as ComboBox).SelectedItem != null)
                    {
                        SettingJson[controlName] = (control as ComboBox).SelectedItem.ToString();
                    }
                    else
                    {
                        ErrorMsg += controlName + "欄位尚未設定 \n";
                    }
                }
                else if (control.GetType().Name == "TextBox")
                {
                    string Value = DetailJson[controlName] == null ? "" : DetailJson[controlName].ToString();
                    if (Value != "")
                    {
                        SettingJson[controlName] = JObject.Parse(Value);
                    }
                    else
                    {
                        ErrorMsg += controlName + "欄位尚未設定 \n";
                    }

                }
            }
            Result["ErrorMsg"] = ErrorMsg;
            Result["Data"] = SettingJson;

            MessageLabel.Text = "Result : \r\n" + Result; // ---------------------------------------------------------
            return Result;
        }
        private void SelectItemChange(object sender, EventArgs e) 
        {
            JObject Data = SetFormJson();
            MainJson = JObject.Parse(Data["Data"].ToString());
        }
    }
}
