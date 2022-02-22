using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursach_tupyakov
{
    public partial class test_form : Form
    {
        public int number_test;
        public test_form(int num)
        {
            InitializeComponent();
            number_test = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Вывод теста на форму
        private void test_form_Load(object sender, EventArgs e)
        {
            Test temp = new Test();
            temp = Form1.test;
            //string[] question = temp.get_question();
            int x_p = 60, y_p = 25;
            for (int i = 0; i < (temp.get_count()); i++)
            {
                Panel pan = new Panel();
                pan.Location = new Point(x_p, y_p);
                pan.Size = new Size(400, 200);
                pan.BackColor = Color.FromArgb(204, 204, 204);
                pan.Name = "panel" + i;
                this.Controls.Add(pan);

                Label lb = new Label();
                lb.Location = new Point(50, 40);
                lb.Text = temp.get_question()[i];
                pan.Controls.Add(lb);

                switch (temp.get_type()[i])
                {
                    case 0:
                        create_textbox(pan);
                        break;
                    case 1:
                        create_radio(pan, temp, i);
                        break;
                    case 2:
                        create_check(pan, temp, i);
                        break;
                }

                y_p += 220;
            }

            Button bt = new Button();
            bt.Location = new Point(190, y_p);
            bt.Size = new Size(150, 50);
            bt.Text = "Принять";
            bt.Click += Bt_Click;
            this.Controls.Add(bt);

            y_p += 50;
            Label emp = new Label();
            emp.Location = new Point(0, y_p);
            this.Controls.Add(emp);
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void create_check(Panel pan, Test test, int i)
        {
            string[] answers = test.get_answers()[i].Split(';');
            int x = 50, y = 75;
            for (int j = 0; j < 4; j++)
            {
                CheckBox cb = new CheckBox();
                cb.Location = new Point(x, y);
                cb.Text = answers[j];

                pan.Controls.Add(cb);

                y += 25;
            }
        }

        private void create_radio(Panel pan, Test test, int i)
        {
            string[] answers = test.get_answers()[i].Split(';');
            int x = 50, y = 75;
            for(int j = 0; j < 4; j++)
            {
                RadioButton rb = new RadioButton();
                rb.Location = new Point(x, y);
                rb.Text = answers[j];

                pan.Controls.Add(rb);

                y += 25;
            }
        }

        private void create_textbox(Panel pan)
        {
            TextBox tb = new TextBox();
            tb.Location = new Point(50, 75);
            tb.Size = new Size(300, 23);
            pan.Controls.Add(tb);
        }
    }
}
