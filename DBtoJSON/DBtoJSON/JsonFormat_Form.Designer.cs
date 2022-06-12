
namespace DBtoJSON
{
    partial class JsonFormat_Form
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
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            this.BackMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackMenu.Location = new System.Drawing.Point(623, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(165, 29);
            this.BackMenu.TabIndex = 2;
            this.BackMenu.Text = "返回";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // JsonFormat_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackMenu);
            this.Name = "JsonFormat_Form";
            this.Text = "JsonFormat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
    }
}