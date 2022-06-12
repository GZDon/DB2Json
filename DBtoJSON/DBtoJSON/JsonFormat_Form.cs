using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Actions;

namespace DBtoJSON
{
    public partial class JsonFormat_Form : Form
    {
        public JsonFormat_Form()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            SwitchForm(new Form1(), this);
        }
    }
}
