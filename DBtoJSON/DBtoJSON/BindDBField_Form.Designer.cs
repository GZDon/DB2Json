
namespace DBtoJSON
{
    partial class BindDBField_Form
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackDBtoJson
            // 
            this.BackDBtoJson.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackDBtoJson.Location = new System.Drawing.Point(623, 12);
            this.BackDBtoJson.Name = "BackDBtoJson";
            this.BackDBtoJson.Size = new System.Drawing.Size(165, 29);
            this.BackDBtoJson.TabIndex = 2;
            this.BackDBtoJson.Text = "返回";
            this.BackDBtoJson.UseVisualStyleBackColor = true;
            this.BackDBtoJson.Click += new System.EventHandler(this.BackDBtoJson_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(299, 329);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(165, 29);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "設定完成";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 181);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(58, 15);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.Text = "Message";
            // 
            // BindDBField_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.BackDBtoJson);
            this.Name = "BindDBField_Form";
            this.Text = "BindBDField";
            this.Load += new System.EventHandler(this.BindDBField_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackDBtoJson;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label MessageLabel;
    }
}