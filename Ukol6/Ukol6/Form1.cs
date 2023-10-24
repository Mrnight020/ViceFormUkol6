using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ukol6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h = 20, w = 50;
        Font f = null;
        Color back = Color.White;
        Color fore = Color.Black;
        string textBtn = "button";
        Button btn6;
        ComboBox comboBoxTextAlign;
        Form form2;

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Size = new Size(400, 500);
            form2.FormBorderStyle = FormBorderStyle.FixedSingle;


            NumericUpDown num = new NumericUpDown();
            Label lbl = new Label();
            lbl.Text = "Width:";
            lbl.Location = new Point(10, 10);
            num.Value = 50;
            num.Minimum = 50;
            num.Maximum = 200;
            num.Location = new Point(50, 10);
            num.ValueChanged += Num_ValueChanged;
            form2.Controls.Add(num);
            form2.Controls.Add(lbl);

            NumericUpDown num2 = new NumericUpDown();
            Label lbl2 = new Label();
            lbl2.Text = "Hight:";
            lbl2.Location = new Point(10, 50);
            num2.Value = 20;
            num2.Minimum = 20;
            num2.Maximum = 150;
            num2.Location = new Point(50, 50);
            num.ValueChanged += Num_ValueChanged1;
            form2.Controls.Add(num2);
            form2.Controls.Add(lbl2);

            Button btn = new Button();
            btn.Text = "Font";
            btn.Location = new Point(10, 85);
            btn.Click += Btn_Click;
            form2.Controls.Add(btn);

            Button btn2 = new Button();
            btn2.Text = "BackColor";
            btn2.Location = new Point(10, 110);
            btn2.Click += Btn2_Click;
            form2.Controls.Add(btn2);

            Button btn3 = new Button();
            btn3.Text = "ForeColor";
            btn3.Location = new Point(10, 135);
            btn3.Click += Btn3_Click; ;
            form2.Controls.Add(btn3);

            Label lbl4 = new Label();
            lbl4.Text = "Text align:";
            lbl4.Location = new Point(10, 170);
            form2.Controls.Add(lbl4);

            comboBoxTextAlign = new ComboBox();
            comboBoxTextAlign.Location = new Point(150, 170);
            comboBoxTextAlign.Items.AddRange(Enum.GetNames(typeof(System.Drawing.ContentAlignment)));
            comboBoxTextAlign.SelectedIndex = 0;
            form2.Controls.Add(comboBoxTextAlign);

            TextBox txt = new TextBox();
            Label lbl3 = new Label();
            lbl3.Text = "Text:";
            lbl3.Location = new Point(10, 200);
            txt.Location = new Point(50, 200);
            txt.TextChanged += Txt_TextChanged;
            form2.Controls.Add(txt);
            form2.Controls.Add(lbl3);

            Button btn4 = new Button();
            btn4.Text = "Ulož";
            btn4.Location = new Point(10, 250);
            btn4.Click += Btn4_Click; ;
            form2.Controls.Add(btn4);

            Button btn5 = new Button();
            btn5.Text = "Zruš";
            btn5.Location = new Point(250, 250);
            btn5.Click += Btn5_Click; ;
            form2.Controls.Add(btn5);

            btn6 = new Button();
            btn6.Text = "Zkus mě";
            btn6.Location = new Point(135, 300);
            btn6.Click += Btn6_Click; ;
            form2.Controls.Add(btn6);

            form2.ShowIcon = false;
            form2.Text = "Button Editing";
            form2.ShowDialog();
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            textBtn = ((TextBox)sender).Text;
        }

        private void Num_ValueChanged1(object sender, EventArgs e)
        {
            h = (int)((NumericUpDown)sender).Value;
        }

        private void Num_ValueChanged(object sender, EventArgs e)
        {
            w = (int)((NumericUpDown)sender).Value;
        }
        private void Btn6_Click(object sender, EventArgs e)   // zkušební button
        {
            btn6.Text = textBtn;
            btn6.Font = f;
            btn6.ForeColor = fore;
            btn6.BackColor = back;
            btn6.TextAlign = (System.Drawing.ContentAlignment)Enum.Parse(typeof(System.Drawing.ContentAlignment), comboBoxTextAlign.SelectedItem.ToString()); ;
            btn6.Width = w;
            btn6.Height = h;
        }
        private void Btn5_Click(object sender, EventArgs e)   // zrušení
        {
            form2.Close();
        }
        private void Btn4_Click(object sender, EventArgs e)   // uložení
        {
            button1.Text = textBtn;
            button1.Font = f;
            button1.ForeColor = fore;
            button1.BackColor = back;
            button1.TextAlign = (System.Drawing.ContentAlignment)Enum.Parse(typeof(System.Drawing.ContentAlignment), comboBoxTextAlign.SelectedItem.ToString()); ;
            button1.Width = w;
            button1.Height = h;
            button1.Location = new Point(button1.Left, button1.Top);
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                fore = cd.Color;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                back = cd.Color;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
                f = fontDialog.Font;
        }



    }
}
