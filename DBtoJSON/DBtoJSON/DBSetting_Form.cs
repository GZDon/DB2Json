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
using System.Data.SqlClient;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.Storage;

namespace DBtoJSON
{
    public partial class DBSetting_Form : Form
    {
        public DBSetting_Form()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            SwitchForm(new Form1(), this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if(ConnetionName.Text.Trim() != "" &&  
                SeverName.Text.Trim() != "" && 
                Account.Text.Trim() != "" && 
                Password.Text.Trim() != "" && 
                Database.Text.Trim() != "")
            {
                JObject ConnInfo = new JObject();
                JObject json = new JObject();
                ConnInfo["SeverName"] = SeverName.Text;
                ConnInfo["Account"] = Account.Text;
                ConnInfo["Password"] = Password.Text;
                ConnInfo["Database"] = Database.Text;

                try
                {
                    //檢查資料夾是否存在
                    if (!File.Exists(pathString))
                    {
                        //建立資料夾
                        Directory.CreateDirectory(pathString);
                    }
                    //檢查檔案是否存在
                    if (File.Exists(DBFilePath))
                    {
                        StreamReader DB_sr = new StreamReader(DBFilePath);
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
                    }
                    if(json[ConnetionName.Text] == null)
                    {
                        json[ConnetionName.Text] = ConnInfo;
                        //寫入檔案
                        StreamWriter sw = new StreamWriter(DBFilePath);
                        sw.WriteLine(JsonConvert.SerializeObject(json));
                        sw.Close();
                        ConnetionName.Clear();
                        SeverName.Clear();
                        Account.Clear();
                        Password.Clear();
                        Database.Clear();
                        MessageBox.Show("新增成功!!");
                    }
                    else
                    {
                        MessageBox.Show("連線名稱重複!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("欄位不可空白!!");
            }
        }

        private void TestCon_btn_Click(object sender, EventArgs e)
        {
            string Source = SeverName.Text;
            string DB = Database.Text;
            string User = Account.Text;
            string PWD = Password.Text;
            SqlConnection con = new SqlConnection($@"Data Source={Source};Initial Catalog={DB}; User={User};Password={PWD}");

            try 
            {
                con.Open();
                MessageBox.Show("連線成功!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }
    }
}
