
namespace DBtoJSON
{
    partial class DataMapping
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
            this.Title = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.BackDBtoJson = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SettingDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(320, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(138, 26);
            this.Title.TabIndex = 14;
            this.Title.Text = "設定資料格式";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(219, 331);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(165, 29);
            this.Save_btn.TabIndex = 13;
            this.Save_btn.Text = "儲存資料";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // BackDBtoJson
            // 
            this.BackDBtoJson.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackDBtoJson.Location = new System.Drawing.Point(623, 12);
            this.BackDBtoJson.Name = "BackDBtoJson";
            this.BackDBtoJson.Size = new System.Drawing.Size(165, 29);
            this.BackDBtoJson.TabIndex = 12;
            this.BackDBtoJson.Text = "返回";
            this.BackDBtoJson.UseVisualStyleBackColor = true;
            this.BackDBtoJson.Click += new System.EventHandler(this.BackDBtoJson_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(13, 197);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(89, 15);
            this.MessageLabel.TabIndex = 15;
            this.MessageLabel.Text = "MessageLabel";
            // 
            // SettingDone
            // 
            this.SettingDone.Location = new System.Drawing.Point(416, 331);
            this.SettingDone.Name = "SettingDone";
            this.SettingDone.Size = new System.Drawing.Size(165, 29);
            this.SettingDone.TabIndex = 16;
            this.SettingDone.Text = "設定完成";
            this.SettingDone.UseVisualStyleBackColor = true;
            this.SettingDone.Click += new System.EventHandler(this.SettingDone_Click);
            // 
            // DataMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingDone);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.BackDBtoJson);
            this.Name = "DataMapping";
            this.Text = "DataMapping";
            this.Load += new System.EventHandler(this.DataMapping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button BackDBtoJson;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button SettingDone;
    }
}