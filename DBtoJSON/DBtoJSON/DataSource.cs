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
using static DBtoJSON.Models.Storage;
using static DBtoJSON.Models.Actions;

namespace DBtoJSON
{
    public partial class DataSource : Form
    {
        static SqlConnection con = new SqlConnection();
        static JObject DBObj = new JObject();
        public DataSource()
        {
            InitializeComponent();
        }

        private void DataSource_Load(object sender, EventArgs e) // 載入DataSource表單
        {
            
            using (StreamReader DB_sr = new StreamReader(DBFilePath))
            {
                try {
                    DBObj = JObject.Parse(DB_sr.ReadToEnd());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("DBSetting content error.\n" + ex.Message);
                }
            }

            foreach (JProperty Prop in DBObj.Properties())
            {
                Connetion_Combo.Items.Add(Prop.Name.ToString());
            }
        }

        private void BackDBtoJson_Click(object sender, EventArgs e) // Back
        {
            SwitchForm(new JsonData(), this);
        }

        private void Save_btn_Click(object sender, EventArgs e) // Save btn
        {
            bool Check = true;
            if(Connetion_Combo.Text == "")
            {
                MessageBox.Show("未選擇 連線名稱");
                Check = false;
            }
            else if(Table.Text == "")
            {
                MessageBox.Show("未選擇 資料表");
                Check = false;
            }
            else if(FilterCol.Text != "" || FilterSybol.Text != "" || FilterVal.Text != "") // 任一有值
            {
                if (FilterCol.Text == "" || FilterSybol.Text == "" || FilterVal.Text == "") // 所有必填
                {
                    MessageBox.Show("篩選設定有誤 請確認");
                    Check = false;
                }
            }

            if (Check)
            {
                if(FilterCol.Text != "")
                {
                    if(FilterSybol.Text != "like")
                    {
                        Data_Source = $@"SELECT * FROM {Table.Text} WHERE {FilterCol.Text} {FilterSybol.Text} '{FilterVal.Text}'";
                    }
                    else
                    {
                        Data_Source = $@"SELECT * FROM {Table.Text} WHERE {FilterCol.Text} {FilterSybol.Text} '%{FilterVal.Text}%'";
                    }
                }
                else
                {
                    Data_Source = $@"SELECT * FROM {Table.Text}";
                }

                Data_Con_name = Connetion_Combo.Text;
                Data_SorceTable = Data_Source;
                MessageBox.Show("設定成功");
                SwitchForm(new JsonData(), this);
            }

        }

        private void Connetion_Combo_SelectedIndexChanged(object sender, EventArgs e) // 資料庫來源
        {
            // 
            JObject DBSetting = (JObject)(DBObj[Connetion_Combo.Text.ToString()]);            
            // 資料庫連線設定
            con = new SqlConnection($@"Data Source={DBSetting["SeverName"].ToString()};Initial Catalog={DBSetting["Database"].ToString()}; User={DBSetting["Account"].ToString()};Password={DBSetting["Password"].ToString()}");

            try
            {
                con.Open();
                using (SqlCommand Cmd = new SqlCommand(@"SELECT * FROM Information_Schema.TABLES ORDER BY TABLE_NAME", con))
                {
                    Table.Items.Clear();
                    SqlDataReader rd = Cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Table.Items.Add(rd["TABLE_NAME"].ToString());
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }
        private void Table_SelectedIndexChanged(object sender, EventArgs e) // 資料表設定
        {
            try
            {
                con.Open();
                using (SqlCommand Cmd = new SqlCommand(@"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TABLE_NAME ORDER BY COLUMN_NAME", con))
                {
                    FieldJsonJArr.Clear();
                    FilterCol.Items.Clear();
                    Cmd.Parameters.AddWithValue("@TABLE_NAME", Table.Text);

                    SqlDataReader rd = Cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        FilterCol.Items.Add(rd["COLUMN_NAME"].ToString());
                        JObject JOb = new JObject();
                        JOb.Add("COLUMN_NAME", rd["COLUMN_NAME"].ToString());
                        FieldJsonJArr.Add(JOb);
                    }
                    FieldJson = FieldJsonJArr.ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void FilterCol_SelectedIndexChanged(object sender, EventArgs e) // 篩選條件
        {

        }

    }
}
