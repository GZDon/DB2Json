
namespace DBtoJSON
{
    partial class DBSetting_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.SeverName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.ConnetionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TestCon_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            this.BackMenu.Location = new System.Drawing.Point(623, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(165, 29);
            this.BackMenu.TabIndex = 0;
            this.BackMenu.Text = "返回";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "伺服器名稱";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeverName
            // 
            this.SeverName.Location = new System.Drawing.Point(279, 115);
            this.SeverName.Name = "SeverName";
            this.SeverName.Size = new System.Drawing.Size(165, 23);
            this.SeverName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "使用者帳號";
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(279, 157);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(165, 23);
            this.Account.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(279, 203);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(165, 23);
            this.Password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "資料庫名稱";
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(279, 250);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(165, 23);
            this.Database.TabIndex = 8;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(279, 353);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(165, 29);
            this.Save_btn.TabIndex = 9;
            this.Save_btn.Text = "儲存";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // ConnetionName
            // 
            this.ConnetionName.Location = new System.Drawing.Point(279, 74);
            this.ConnetionName.Name = "ConnetionName";
            this.ConnetionName.Size = new System.Drawing.Size(165, 23);
            this.ConnetionName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "連線名稱";
            // 
            // TestCon_btn
            // 
            this.TestCon_btn.Location = new System.Drawing.Point(476, 249);
            this.TestCon_btn.Name = "TestCon_btn";
            this.TestCon_btn.Size = new System.Drawing.Size(75, 23);
            this.TestCon_btn.TabIndex = 12;
            this.TestCon_btn.Text = "測試連線";
            this.TestCon_btn.UseVisualStyleBackColor = true;
            this.TestCon_btn.Click += new System.EventHandler(this.TestCon_btn_Click);
            // 
            // DBSetting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestCon_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConnetionName);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeverName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackMenu);
            this.Name = "DBSetting_Form";
            this.Text = "DBSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox ConnetionName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TestCon_btn;
    }
}