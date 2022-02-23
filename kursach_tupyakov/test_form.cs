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
        Test temp = new Test();
        public test_form(int num)
        {
            InitializeComponent();
            number_test = num;
        }

        //Вывод теста на форму
        private void test_form_Load(object sender, EventArgs e)
        {
           
            temp = Form1.test[number_test];
            //string[] question = temp.get_question();
            int x_p = 60, y_p = 25;
            int txbox = 0, rdbox = 0, chbox = 0;
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
                lb.AutoSize = true;
                pan.Controls.Add(lb);

                switch (temp.get_type()[i])
                {
                    case 0:
                        create_textbox(pan, txbox);
                        txbox++;
                        break;
                    case 1:
                        create_radio(pan, temp, i, rdbox);
                        rdbox += 4;
                        break;
                    case 2:
                        create_check(pan, temp, i, chbox);
                        chbox += 4;
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



        //Сохранить результаты
        private void Bt_Click(object sender, EventArgs e)
        {
            int tb = 0, rb = 0, cb = 0;
            string glob_answer = Convert.ToString(temp.get_count()) + ";";
            //MessageBox.Show(this.Controls["panel0"].Controls["textBox1"].Text);
            for(int i = 0; i < temp.get_count(); i++)
            {
                switch (temp.get_type()[i])
                {
                    case 0:
                        glob_answer += this.Controls["panel" + i].Controls["textBox" + tb].Text + ";";
                        tb++;
                        break;
                    case 1:
                        RadioButton rbb;
                        if ((rbb = this.Controls["panel" + i].Controls["radioButton" + rb] as RadioButton).Checked)
                        {
                            glob_answer += rbb.Text + ";";
                        } 
                        else if ((rbb = this.Controls["panel" + i].Controls["radioButton" + (rb + 1)] as RadioButton).Checked)
                        {
                            glob_answer += rbb.Text + ";";
                        } 
                        else if ((rbb = this.Controls["panel" + i].Controls["radioButton" + (rb + 2)] as RadioButton).Checked)
                        {
                            glob_answer += rbb.Text + ";";
                        } 
                        else if ((rbb = this.Controls["panel" + i].Controls["radioButton" + (rb + 3)] as RadioButton).Checked)
                        {
                            glob_answer += rbb.Text + ";";
                        }
                        rb += 4;
                        break;
                    case 2:
                        CheckBox chb;
                        if ((chb = this.Controls["panel" + i].Controls["checkBox" + cb] as CheckBox).Checked)
                        {
                            glob_answer += "1-";
                        }
                        if ((chb = this.Controls["panel" + i].Controls["checkBox" + (cb + 1)] as CheckBox).Checked)
                        {
                            glob_answer += "2-";
                        }
                        if ((chb = this.Controls["panel" + i].Controls["checkBox" + (cb + 2)] as CheckBox).Checked)
                        {
                            glob_answer += "3-";
                        }
                        if ((chb = this.Controls["panel" + i].Controls["checkBox" + (cb + 3)] as CheckBox).Checked)
                        {
                            glob_answer += "4-";
                        }
                        glob_answer += ";";
                        cb += 4;
                        break;
                }

            }
            MessageBox.Show(glob_answer);

        }

        private void create_check(Panel pan, Test test, int i, int chbox)
        {
            string[] answers = test.get_answers()[i].Split(';');
            int x = 50, y = 75;
            for (int j = 0; j < 4; j++)
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Location = new Point(x, y);
                cb.Text = answers[j];
                cb.Name = "checkBox" + (j + chbox);
                pan.Controls.Add(cb);

                y += 25;
            }
        }

        private void create_radio(Panel pan, Test test, int i, int rdbox)
        {
            string[] answers = test.get_answers()[i].Split(';');
            int x = 50, y = 75;
            for(int j = 0; j < 4; j++)
            {
                RadioButton rb = new RadioButton();
                rb.AutoSize = true;
                rb.Location = new Point(x, y);
                rb.Text = answers[j];
                rb.Name = "radioButton" + (j + rdbox);
                pan.Controls.Add(rb);

                y += 25;
            }
        }

        private void create_textbox(Panel pan, int txbox)
        {
            TextBox tb = new TextBox();
            tb.Location = new Point(50, 75);
            tb.Size = new Size(300, 23);
            tb.Name = "textBox" + txbox;
            pan.Controls.Add(tb);
        }

    }
}
