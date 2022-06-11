
namespace DBtoJSON
{
    partial class DBtoJson_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackMenu = new System.Windows.Forms.Button();
            this.Connetion_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table_Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JsonFormat_Combo = new System.Windows.Forms.ComboBox();
            this.BindField_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfigName_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            this.BackMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackMenu.Location = new System.Drawing.Point(623, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(165, 29);
            this.BackMenu.TabIndex = 1;
            this.BackMenu.Text = "返回";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // Connetion_Combo
            // 
            this.Connetion_Combo.FormattingEnabled = true;
            this.Connetion_Combo.Location = new System.Drawing.Point(283, 84);
            this.Connetion_Combo.Name = "Connetion_Combo";
            this.Connetion_Combo.Size = new System.Drawing.Size(121, 23);
            this.Connetion_Combo.TabIndex = 2;
            this.Connetion_Combo.SelectedIndexChanged += new System.EventHandler(this.Connetion_Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "連線名稱";
            // 
            // Table_Combo
            // 
            this.Table_Combo.FormattingEnabled = true;
            this.Table_Combo.Location = new System.Drawing.Point(283, 135);
            this.Table_Combo.Name = "Table_Combo";
            this.Table_Combo.Size = new System.Drawing.Size(260, 23);
            this.Table_Combo.TabIndex = 4;
            this.Table_Combo.SelectedIndexChanged += new System.EventHandler(this.Table_Combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "來源資料表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Json格式";
            // 
            // JsonFormat_Combo
            // 
            this.JsonFormat_Combo.FormattingEnabled = true;
            this.JsonFormat_Combo.Location = new System.Drawing.Point(283, 224);
            this.JsonFormat_Combo.Name = "JsonFormat_Combo";
            this.JsonFormat_Combo.Size = new System.Drawing.Size(121, 23);
            this.JsonFormat_Combo.TabIndex = 7;
            this.JsonFormat_Combo.SelectedIndexChanged += new System.EventHandler(this.JsonFormat_Combo_SelectedIndexChanged);
            // 
            // BindField_btn
            // 
            this.BindField_btn.Location = new System.Drawing.Point(453, 224);
            this.BindField_btn.Name = "BindField_btn";
            this.BindField_btn.Size = new System.Drawing.Size(90, 23);
            this.BindField_btn.TabIndex = 8;
            this.BindField_btn.Text = "設定對應欄位";
            this.BindField_btn.UseVisualStyleBackColor = true;
            this.BindField_btn.Click += new System.EventHandler(this.BindField_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "設定檔名稱";
            // 
            // ConfigName_text
            // 
            this.ConfigName_text.Location = new System.Drawing.Point(283, 181);
            this.ConfigName_text.Name = "ConfigName_text";
            this.ConfigName_text.Size = new System.Drawing.Size(260, 23);
            this.ConfigName_text.TabIndex = 11;
            // 
            // DBtoJson_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfigName_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BindField_btn);
            this.Controls.Add(this.JsonFormat_Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connetion_Combo);
            this.Controls.Add(this.BackMenu);
            this.Name = "DBtoJson_Form";
            this.Text = "DBtoJson";
            this.Load += new System.EventHandler(this.DBtoJson_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.ComboBox Connetion_Combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Table_Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JsonFormat_Combo;
        private System.Windows.Forms.Button BindField_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfigName_text;
    }
}