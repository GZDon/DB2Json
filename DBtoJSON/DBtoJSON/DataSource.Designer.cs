
namespace DBtoJSON
{
    partial class DataSource
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.BackDBtoJson = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SelectTxt = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.ComboBox();
            this.FilterTxt = new System.Windows.Forms.Label();
            this.FilterCol = new System.Windows.Forms.ComboBox();
            this.FilterSybol = new System.Windows.Forms.ComboBox();
            this.ConnectionName = new System.Windows.Forms.Label();
            this.Connetion_Combo = new System.Windows.Forms.ComboBox();
            this.FilterVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(307, 331);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(165, 29);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "設定完成";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // BackDBtoJson
            // 
            this.BackDBtoJson.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackDBtoJson.Location = new System.Drawing.Point(623, 12);
            this.BackDBtoJson.Name = "BackDBtoJson";
            this.BackDBtoJson.Size = new System.Drawing.Size(165, 29);
            this.BackDBtoJson.TabIndex = 5;
            this.BackDBtoJson.Text = "返回";
            this.BackDBtoJson.UseVisualStyleBackColor = true;
            this.BackDBtoJson.Click += new System.EventHandler(this.BackDBtoJson_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(320, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(138, 26);
            this.Title.TabIndex = 7;
            this.Title.Text = "選擇資料來源";
            // 
            // SelectTxt
            // 
            this.SelectTxt.AutoSize = true;
            this.SelectTxt.Location = new System.Drawing.Point(240, 139);
            this.SelectTxt.Name = "SelectTxt";
            this.SelectTxt.Size = new System.Drawing.Size(43, 15);
            this.SelectTxt.TabIndex = 7;
            this.SelectTxt.Text = "資料表";
            // 
            // Table
            // 
            this.Table.FormattingEnabled = true;
            this.Table.Location = new System.Drawing.Point(307, 136);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(165, 23);
            this.Table.TabIndex = 8;
            this.Table.SelectedIndexChanged += new System.EventHandler(this.Table_SelectedIndexChanged);
            // 
            // FilterTxt
            // 
            this.FilterTxt.AutoSize = true;
            this.FilterTxt.Location = new System.Drawing.Point(240, 189);
            this.FilterTxt.Name = "FilterTxt";
            this.FilterTxt.Size = new System.Drawing.Size(55, 15);
            this.FilterTxt.TabIndex = 7;
            this.FilterTxt.Text = "篩選條件";
            // 
            // FilterCol
            // 
            this.FilterCol.FormattingEnabled = true;
            this.FilterCol.Location = new System.Drawing.Point(307, 186);
            this.FilterCol.Name = "FilterCol";
            this.FilterCol.Size = new System.Drawing.Size(165, 23);
            this.FilterCol.TabIndex = 8;
            this.FilterCol.SelectedIndexChanged += new System.EventHandler(this.FilterCol_SelectedIndexChanged);
            // 
            // FilterSybol
            // 
            this.FilterSybol.FormattingEnabled = true;
            this.FilterSybol.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "like"});
            this.FilterSybol.Location = new System.Drawing.Point(352, 215);
            this.FilterSybol.Name = "FilterSybol";
            this.FilterSybol.Size = new System.Drawing.Size(71, 23);
            this.FilterSybol.TabIndex = 8;
            // 
            // ConnectionName
            // 
            this.ConnectionName.AutoSize = true;
            this.ConnectionName.Location = new System.Drawing.Point(240, 86);
            this.ConnectionName.Name = "ConnectionName";
            this.ConnectionName.Size = new System.Drawing.Size(55, 15);
            this.ConnectionName.TabIndex = 10;
            this.ConnectionName.Text = "連線名稱";
            // 
            // Connetion_Combo
            // 
            this.Connetion_Combo.FormattingEnabled = true;
            this.Connetion_Combo.Location = new System.Drawing.Point(307, 83);
            this.Connetion_Combo.Name = "Connetion_Combo";
            this.Connetion_Combo.Size = new System.Drawing.Size(165, 23);
            this.Connetion_Combo.TabIndex = 9;
            this.Connetion_Combo.SelectedIndexChanged += new System.EventHandler(this.Connetion_Combo_SelectedIndexChanged);
            // 
            // FilterVal
            // 
            this.FilterVal.Location = new System.Drawing.Point(307, 244);
            this.FilterVal.Name = "FilterVal";
            this.FilterVal.Size = new System.Drawing.Size(165, 23);
            this.FilterVal.TabIndex = 11;
            // 
            // DataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterVal);
            this.Controls.Add(this.ConnectionName);
            this.Controls.Add(this.Connetion_Combo);
            this.Controls.Add(this.FilterSybol);
            this.Controls.Add(this.FilterCol);
            this.Controls.Add(this.FilterTxt);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.SelectTxt);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.BackDBtoJson);
            this.Name = "DataSource";
            this.Text = "DataSource";
            this.Load += new System.EventHandler(this.DataSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button BackDBtoJson;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SelectTxt;
        private System.Windows.Forms.ComboBox Table;
        private System.Windows.Forms.Label FilterTxt;
        private System.Windows.Forms.ComboBox FilterCol;
        private System.Windows.Forms.ComboBox FilterSybol;
        private System.Windows.Forms.Label ConnectionName;
        private System.Windows.Forms.ComboBox Connetion_Combo;
        private System.Windows.Forms.TextBox FilterVal;
    }
}