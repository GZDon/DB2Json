
namespace DBtoJSON
{
    partial class DetailField
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
        private void InitializeComponent() // 初始化元件
        {
            this.Save_btn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(299, 329);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(165, 29);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "設定完成";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(623, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(165, 29);
            this.Back.TabIndex = 1;
            this.Back.Text = "返回";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 181);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(58, 15);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message";
            // 
            // DetailField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save_btn);
            this.Name = "DetailField";
            this.Text = "DetailField";
            this.Load += new System.EventHandler(this.DetailField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label MessageLabel;
    }
}