
namespace DBtoJSON
{
    partial class JsonDataSetting
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
            this.DataFormat_Label = new System.Windows.Forms.Label();
            this.DataFormat_Combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(320, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(138, 26);
            this.Title.TabIndex = 10;
            this.Title.Text = "設定資料格式";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(307, 330);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(165, 29);
            this.Save_btn.TabIndex = 9;
            this.Save_btn.Text = "設定對應欄位";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // BackDBtoJson
            // 
            this.BackDBtoJson.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackDBtoJson.Location = new System.Drawing.Point(623, 12);
            this.BackDBtoJson.Name = "BackDBtoJson";
            this.BackDBtoJson.Size = new System.Drawing.Size(165, 29);
            this.BackDBtoJson.TabIndex = 8;
            this.BackDBtoJson.Text = "返回";
            this.BackDBtoJson.UseVisualStyleBackColor = true;
            this.BackDBtoJson.Click += new System.EventHandler(this.BackDBtoJson_Click);
            // 
            // DataFormat_Label
            // 
            this.DataFormat_Label.AutoSize = true;
            this.DataFormat_Label.Location = new System.Drawing.Point(225, 155);
            this.DataFormat_Label.Name = "DataFormat_Label";
            this.DataFormat_Label.Size = new System.Drawing.Size(67, 15);
            this.DataFormat_Label.TabIndex = 12;
            this.DataFormat_Label.Text = "設定檔名稱";
            // 
            // DataFormat_Combo
            // 
            this.DataFormat_Combo.FormattingEnabled = true;
            this.DataFormat_Combo.Location = new System.Drawing.Point(307, 152);
            this.DataFormat_Combo.Name = "DataFormat_Combo";
            this.DataFormat_Combo.Size = new System.Drawing.Size(165, 23);
            this.DataFormat_Combo.TabIndex = 11;
            this.DataFormat_Combo.SelectedIndexChanged += new System.EventHandler(this.DataFormat_Combo_SelectedIndexChanged);
            // 
            // JsonDataSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataFormat_Label);
            this.Controls.Add(this.DataFormat_Combo);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.BackDBtoJson);
            this.Name = "JsonDataSetting";
            this.Text = "JsonDataSetting";
            this.Load += new System.EventHandler(this.JsonDataSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button BackDBtoJson;
        private System.Windows.Forms.Label DataFormat_Label;
        private System.Windows.Forms.ComboBox DataFormat_Combo;
    }
}