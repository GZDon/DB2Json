using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DBtoJSON.Models.Storage;

namespace DBtoJSON.Models
{
    public class Actions
    {
        public static void SwitchForm(dynamic newForm, dynamic oldForm) // 選擇哪個Form畫面
        {
            // 開新Form 隱藏舊From畫面
            newForm.StartPosition = FormStartPosition.Manual;
            int x = oldForm.Left;
            int y = oldForm.Top;
            newForm.Location = (Point)new Size(x, y);
            oldForm.Hide();
            newForm.ShowDialog();
            oldForm.Dispose();
        }
        public static void CreatNewForm(JObject JsonData)
        {
            Form newform = new Form();
            newform.Size = new Size(816, 489);

            Button button = new Button();
            button.Size = new Size(165, 29);
            button.Location = (Point)new Size(632, 12);
            button.Name = "Back";
            button.Text = "返回";
            button.Click += MyNewButton_Click;

            newform.Load += NewformLoad;

            newform.Controls.Add(button);
        }
        public static void AddItem(dynamic json, string FieldJson, Form form) // 依照json格式 畫出對應的畫面
        {
            
            if(json.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
            {
                int Count = 1;
                foreach (JProperty data in json.Properties())
                {
                
                    //JsonFormatLoop(data);
                    Label label = new Label(); // 欄位Key值 文字顯示
                    //label.Size = new Size(100, 50);
                    label.Location = new Point(form.Width / 4, 20 + Count * 30);
                    label.Name = "label" + Convert.ToString(Count);
                    label.Text = data.Name.ToString(); 
                    form.Controls.Add(label); // 將欄位新增至目標Form
                    // if (data.Value.ToString() == "") // 若此Object Value值為空 => 需Mapping欄位
                    if (data.Value.Type.ToString() == "String") // 若此Object Value值為字串 => 需Mapping欄位
                    {
                        ComboBox Combo = new ComboBox(); // 下拉選單
                        Combo.Size = new Size(200, 50);
                        Combo.Location = new Point(320, 20 + Count * 30);
                        Combo.Name = data.Name.ToString();

                        foreach (dynamic Field in JArray.Parse(FieldJson)) // 將DB欄位放進下拉選單
                        {
                            foreach (JProperty FieldProp in Field.Properties())
                            {
                                Combo.Items.Add(FieldProp.Value.ToString());
                            }
                        }
                        form.Controls.Add(Combo);
                    }
                    //
                    else // 若此Object Value值不為空 => 還需設定下一層
                    {
                        if (DetailLevelData.Count == CurrentLevel)
                        {
                            DetailLevelData.Add(data.Value); // ------------------------------------目前這一層的JSON資料
                        }
                    
                        TextBox textbox = new TextBox();
                        textbox.Name = data.Name.ToString();
                        textbox.Text = data.Value.ToString(); // 下層的JSON
                        textbox.Hide();
                        form.Controls.Add(textbox);

                        Button button = new Button();
                        button.Size = new Size(200, 25);
                        button.Location = new Point(320, 20 + Count * 30);
                        button.Name = data.Name.ToString() + "_btn";
                        button.Text = "設定欄位";
                        button.Click += MyNewButton_Click;

                        form.Controls.Add(button);
                    }
                    Count = Count + 1;
                }
            }else if (json.GetType().ToString() == "Newtonsoft.Json.Linq.JArray")
            {
                Label ArrayName_Label = new Label(); // 欄位Key值 文字顯示
                //label.Size = new Size(100, 50);
                ArrayName_Label.Location = new Point(form.Width / 4, 0);
                ArrayName_Label.Name = "ArrayName_Label";
                ArrayName_Label.Text = GlobalLevel[GlobalLevel.Count-1];
                form.Controls.Add(ArrayName_Label); // 將欄位新增至目標Form
                int Count = 1;
                foreach (dynamic arr in json)
                {
                    Label label = new Label(); // 欄位Key值 文字顯示
                    //label.Size = new Size(100, 50);
                    label.Location = new Point(form.Width / 4, Count * 30);
                    label.Name = "label" + Convert.ToString(Count);
                    label.Text = Count.ToString();
                    form.Controls.Add(label); // 將欄位新增至目標Form

                    if (arr.Type.ToString() == "String") // 若此Object Value值為字串 => 需Mapping欄位
                    {
                        ComboBox Combo = new ComboBox(); // 下拉選單
                        Combo.Size = new Size(200, 50);
                        Combo.Location = new Point(320, Count * 30);
                        Combo.Name = arr.ToString();

                        foreach (dynamic Field in JArray.Parse(FieldJson)) // 將DB欄位放進下拉選單
                        {
                            foreach (JProperty FieldProp in Field.Properties())
                            {
                                Combo.Items.Add(FieldProp.Value.ToString());
                            }
                        }
                        form.Controls.Add(Combo);
                    }
                    //
                    else // => 還需設定下一層
                    {
                        //if (DetailLevelData.Count == CurrentLevel)
                        //{
                        //    DetailLevelData.Add(data.Value); // ------------------------------------目前這一層的JSON資料
                        //}

                        //TextBox textbox = new TextBox();
                        //textbox.Name = data.Name.ToString();
                        //textbox.Text = data.Value.ToString(); // 下層的JSON
                        //textbox.Hide();
                        //form.Controls.Add(textbox);

                        //Button button = new Button();
                        //button.Size = new Size(200, 25);
                        //button.Location = new Point(320, Count * 30);
                        //button.Name = data.Name.ToString() + "_btn";
                        //button.Text = "設定欄位";
                        //button.Click += MyNewButton_Click;

                        //form.Controls.Add(button);
                    }

                    Count++;
                }
            }
        }
        public static void MyNewButton_Click(object sender, EventArgs e) // "設定欄位"按鈕
        {
            CurrentLevel++; // 目前層數
            Button btn = (Button)sender;
            string btn_name = btn.Name.ToString();
            string Text_name = btn_name.Split('_')[0];
            Form oldForm = Form.ActiveForm;

            // JObject Json = new JObject();
            dynamic Json = null;
            
            foreach (Control control in oldForm.Controls)
            {
                if (control.Name.ToString() == Text_name) // 下一頁JSON的資料
                {
                    if (CommFunc.IsJObject(control.Text))
                    {
                        Json = JObject.Parse(control.Text);
                    }
                    else if(CommFunc.IsJArray(control.Text))
                    {
                        Json = JArray.Parse(control.Text);
                    }
                }
            }
            dynamic newForm = new DetailField(Json);
            EditField = Text_name;


            // -----------------------------------------
            

            GlobalLevel.Add(btn_name.Split('_')[0]); // 


            // -----------------------------------------

            SwitchForm(newForm, oldForm);
        }
        public static void BackButton_Click(object sender, EventArgs e)
        {
            Form oldForm = Form.ActiveForm;
            SwitchForm(LastForm, oldForm);
        }
        public static void NewformLoad(object sender, EventArgs e)
        {
            Form thisform = Form.ActiveForm;
            //AddItem(Json, FieldJson, thisform);
        }

        // -----------------------------------------------

        public static void DataMapping_AddItem(dynamic json, string FieldJson, Form form) // 依照json格式 畫出對應的畫面
        {

            if (json.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
            {
                int Count = 1;
                foreach (JProperty data in json.Properties())
                {

                    //JsonFormatLoop(data);
                    Label label = new Label(); // 欄位Key值 文字顯示
                    //label.Size = new Size(100, 50);
                    label.Location = new Point(form.Width / 4, 20 + Count * 30);
                    label.Name = "label" + Convert.ToString(Count);
                    label.Text = data.Name.ToString();
                    form.Controls.Add(label); // 將欄位新增至目標Form
                    // if (data.Value.ToString() == "") // 若此Object Value值為空 => 需Mapping欄位
                    if (data.Value.Type.ToString() == "String") // 若此Object Value值為字串 => 需Mapping欄位
                    {
                        ComboBox Combo = new ComboBox(); // 下拉選單
                        Combo.Size = new Size(200, 50);
                        Combo.Location = new Point(320, 20 + Count * 30);
                        Combo.Name = data.Name.ToString();

                        foreach (dynamic Field in JArray.Parse(FieldJson)) // 將DB欄位放進下拉選單
                        {
                            foreach (JProperty FieldProp in Field.Properties())
                            {
                                Combo.Items.Add(FieldProp.Value.ToString());
                            }
                        }
                        form.Controls.Add(Combo);
                    }
                    //
                    else // 若此Object Value值不為空 => 還需設定下一層
                    {
                        if (DetailLevelData.Count == CurrentLevel)
                        {
                            DetailLevelData.Add(data.Value); // ------------------------------------目前這一層的JSON資料
                        }

                        TextBox textbox = new TextBox();
                        textbox.Name = data.Name.ToString();
                        textbox.Text = data.Value.ToString(); // 下層的JSON
                        // textbox.Hide();
                        form.Controls.Add(textbox);

                        Button button = new Button();
                        button.Size = new Size(200, 25);
                        button.Location = new Point(320, 20 + Count * 30);
                        button.Name = data.Name.ToString() + "_btn";
                        button.Text = "設定欄位";
                        button.Click += DataMapping_MyNewButton_Click;

                        form.Controls.Add(button);
                    }
                    Count = Count + 1;
                }
            }
            else if (json.GetType().ToString() == "Newtonsoft.Json.Linq.JArray")
            {
                Label ArrayName_Label = new Label(); // 欄位Key值 文字顯示
                //label.Size = new Size(100, 50);
                ArrayName_Label.Location = new Point(form.Width / 4, 0);
                ArrayName_Label.Name = "ArrayName_Label";
                ArrayName_Label.Text = GlobalLevel[GlobalLevel.Count - 1];
                form.Controls.Add(ArrayName_Label); // 將欄位新增至目標Form
                int Count = 1;
                foreach (dynamic arr in json)
                {
                    Label label = new Label(); // 欄位Key值 文字顯示
                    //label.Size = new Size(100, 50);
                    label.Location = new Point(form.Width / 4, Count * 30);
                    label.Name = "label" + Convert.ToString(Count);
                    label.Text = Count.ToString();
                    form.Controls.Add(label); // 將欄位新增至目標Form

                    if (arr.Type.ToString() == "String") // 若此Object Value值為字串 => 需Mapping欄位
                    {
                        ComboBox Combo = new ComboBox(); // 下拉選單
                        Combo.Size = new Size(200, 50);
                        Combo.Location = new Point(320, Count * 30);
                        Combo.Name = arr.ToString();

                        foreach (dynamic Field in JArray.Parse(FieldJson)) // 將DB欄位放進下拉選單
                        {
                            foreach (JProperty FieldProp in Field.Properties())
                            {
                                Combo.Items.Add(FieldProp.Value.ToString());
                            }
                        }
                        form.Controls.Add(Combo);
                    }
                    //
                    else // => 還需設定下一層
                    {
                        //if (DetailLevelData.Count == CurrentLevel)
                        //{
                        //    DetailLevelData.Add(data.Value); // ------------------------------------目前這一層的JSON資料
                        //}

                        //TextBox textbox = new TextBox();
                        //textbox.Name = data.Name.ToString();
                        //textbox.Text = data.Value.ToString(); // 下層的JSON
                        //textbox.Hide();
                        //form.Controls.Add(textbox);

                        //Button button = new Button();
                        //button.Size = new Size(200, 25);
                        //button.Location = new Point(320, Count * 30);
                        //button.Name = data.Name.ToString() + "_btn";
                        //button.Text = "設定欄位";
                        //button.Click += MyNewButton_Click;

                        //form.Controls.Add(button);
                    }

                    Count++;
                }
            }
        }
        public static void DataMapping_MyNewButton_Click(object sender, EventArgs e) // "設定欄位"按鈕
        {
            CurrentLevel++; // 目前層數
            Button btn = (Button)sender;
            string btn_name = btn.Name.ToString();
            string Text_name = btn_name.Split('_')[0];
            Form oldForm = Form.ActiveForm;

            // JObject Json = new JObject();
            dynamic Json = null;

            foreach (Control control in oldForm.Controls)
            {
                if (control.Name.ToString() == Text_name) // 下一頁JSON的資料
                {
                    if (CommFunc.IsJObject(control.Text))
                    {
                        Json = JObject.Parse(control.Text);
                    }
                    else if (CommFunc.IsJArray(control.Text))
                    {
                        Json = JArray.Parse(control.Text);
                    }
                }
            }
            dynamic newForm = new DataMapping(Json);
            EditField = Text_name;


            // -----------------------------------------


            Data_GlobalLevel.Add(btn_name.Split('_')[0]); // 


            // -----------------------------------------

            SwitchForm(newForm, oldForm);
        }
    }
}
