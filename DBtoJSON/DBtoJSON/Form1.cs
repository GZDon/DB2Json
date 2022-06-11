using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DBtoJSON.Models.Actions;

namespace DBtoJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DBConnet_btn_Click(object sender, EventArgs e)
        {
            SwitchForm(new DBSetting_Form(),this);
        }

        private void JsonFormat_btn_Click(object sender, EventArgs e)
        {
            SwitchForm(new JsonFormat_Form(), this);
        }

        private void DBtoJson_btn_Click(object sender, EventArgs e)
        {
            SwitchForm(new DBtoJson_Form(), this);
        }

        private void JsonData_btn_Click(object sender, EventArgs e)
        {
            SwitchForm(new JsonData(), this);
        }
    }
}
