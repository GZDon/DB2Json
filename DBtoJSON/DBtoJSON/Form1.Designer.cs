
namespace DBtoJSON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DBConnet_btn = new System.Windows.Forms.Button();
            this.JsonFormat_btn = new System.Windows.Forms.Button();
            this.DBtoJson_btn = new System.Windows.Forms.Button();
            this.JsonData_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DBConnet_btn
            // 
            this.DBConnet_btn.Location = new System.Drawing.Point(331, 106);
            this.DBConnet_btn.Name = "DBConnet_btn";
            this.DBConnet_btn.Size = new System.Drawing.Size(130, 29);
            this.DBConnet_btn.TabIndex = 0;
            this.DBConnet_btn.Text = "資料庫連線設定";
            this.DBConnet_btn.UseVisualStyleBackColor = true;
            this.DBConnet_btn.Click += new System.EventHandler(this.DBConnet_btn_Click);
            // 
            // JsonFormat_btn
            // 
            this.JsonFormat_btn.Location = new System.Drawing.Point(12, 409);
            this.JsonFormat_btn.Name = "JsonFormat_btn";
            this.JsonFormat_btn.Size = new System.Drawing.Size(130, 29);
            this.JsonFormat_btn.TabIndex = 1;
            this.JsonFormat_btn.Text = "Json格式設定";
            this.JsonFormat_btn.UseVisualStyleBackColor = true;
            this.JsonFormat_btn.Click += new System.EventHandler(this.JsonFormat_btn_Click);
            // 
            // DBtoJson_btn
            // 
            this.DBtoJson_btn.Location = new System.Drawing.Point(331, 151);
            this.DBtoJson_btn.Name = "DBtoJson_btn";
            this.DBtoJson_btn.Size = new System.Drawing.Size(130, 29);
            this.DBtoJson_btn.TabIndex = 2;
            this.DBtoJson_btn.Text = "DBtoJson設定";
            this.DBtoJson_btn.UseVisualStyleBackColor = true;
            this.DBtoJson_btn.Click += new System.EventHandler(this.DBtoJson_btn_Click);
            // 
            // JsonData_btn
            // 
            this.JsonData_btn.Location = new System.Drawing.Point(331, 198);
            this.JsonData_btn.Name = "JsonData_btn";
            this.JsonData_btn.Size = new System.Drawing.Size(130, 29);
            this.JsonData_btn.TabIndex = 3;
            this.JsonData_btn.Text = "JsonData設定";
            this.JsonData_btn.UseVisualStyleBackColor = true;
            this.JsonData_btn.Click += new System.EventHandler(this.JsonData_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "產生JSON(尚未完成)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JsonData_btn);
            this.Controls.Add(this.DBtoJson_btn);
            this.Controls.Add(this.JsonFormat_btn);
            this.Controls.Add(this.DBConnet_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DBConnet_btn;
        private System.Windows.Forms.Button JsonFormat_btn;
        private System.Windows.Forms.Button DBtoJson_btn;
        private System.Windows.Forms.Button JsonData_btn;
        private System.Windows.Forms.Button button1;
    }
}

