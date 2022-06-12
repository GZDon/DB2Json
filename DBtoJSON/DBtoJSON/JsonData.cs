using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Actions;
using static DBtoJSON.Models.Storage;
using DBtoJSON.Models;

namespace DBtoJSON
{
    public partial class JsonData : Form
    {
        public JsonData()
        {
            InitializeComponent();
        }

        private void JsonData_Load(object sender, EventArgs e)
        {

        }

        private void DataSource_Click(object sender, EventArgs e)
        {
            SwitchForm(new DataSource(), this);
            
        }

        private void BackDBtoJson_Click(object sender, EventArgs e) // back Form1
        {
            SwitchForm(new Form1(), this);
        }
        private void DataFormat_btn_Click(object sender, EventArgs e) // 資料格式設定
        {
            if (Data_Source.Length == 0)
            {
                MessageBox.Show("請先設定資料來源");
                SwitchForm(new DataSource(), this);
            }
            else
            {
                SwitchForm(new JsonDataSetting(), this);
            }
        }
    }
}
