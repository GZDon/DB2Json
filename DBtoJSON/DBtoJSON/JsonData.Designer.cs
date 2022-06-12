
namespace DBtoJSON
{
    partial class JsonData
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
            this.BackDBtoJson = new System.Windows.Forms.Button();
            this.DataSource = new System.Windows.Forms.Button();
            this.DataFormat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackDBtoJson
            // 
            this.BackDBtoJson.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackDBtoJson.Location = new System.Drawing.Point(623, 12);
            this.BackDBtoJson.Name = "BackDBtoJson";
            this.BackDBtoJson.Size = new System.Drawing.Size(165, 29);
            this.BackDBtoJson.TabIndex = 3;
            this.BackDBtoJson.Text = "返回";
            this.BackDBtoJson.UseVisualStyleBackColor = true;
            this.BackDBtoJson.Click += new System.EventHandler(this.BackDBtoJson_Click);
            // 
            // DataSource
            // 
            this.DataSource.Location = new System.Drawing.Point(318, 157);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(165, 29);
            this.DataSource.TabIndex = 4;
            this.DataSource.Text = "資料來源設定";
            this.DataSource.UseVisualStyleBackColor = true;
            this.DataSource.Click += new System.EventHandler(this.DataSource_Click);
            // 
            // DataFormat_btn
            // 
            this.DataFormat_btn.Location = new System.Drawing.Point(318, 214);
            this.DataFormat_btn.Name = "DataFormat_btn";
            this.DataFormat_btn.Size = new System.Drawing.Size(165, 29);
            this.DataFormat_btn.TabIndex = 4;
            this.DataFormat_btn.Text = "資料格式設定";
            this.DataFormat_btn.UseVisualStyleBackColor = true;
            this.DataFormat_btn.Click += new System.EventHandler(this.DataFormat_btn_Click);
            // 
            // JsonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataFormat_btn);
            this.Controls.Add(this.DataSource);
            this.Controls.Add(this.BackDBtoJson);
            this.Name = "JsonData";
            this.Text = "JsonData";
            this.Load += new System.EventHandler(this.JsonData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackDBtoJson;
        private System.Windows.Forms.Button DataSource;
        private System.Windows.Forms.Button DataFormat_btn;
    }
}