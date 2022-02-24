using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kursach_tupyakov
{
    public partial class check_result : Form
    {
        public check_result()
        {
            InitializeComponent();
        }

        private void check_result_Load(object sender, EventArgs e)
        {
            string path = "result.txt";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] temp = line.Split(";");
                        comboBox1.Items.Add(temp[1]);
                    }
                }
                comboBox1.SelectedItem = comboBox1.Items[0];
            } else
            {
                MessageBox.Show("Результатов опросов нет");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string path = "result.txt";
            int num = comboBox1.SelectedIndex, count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(count == num)
                    {
                        string[] temp = line.Split(";");
                        int y = 20;
                        for (int i = 0; i < Convert.ToInt32(temp[2]); i++)
                        {
                            Label question = new Label();
                            question.AutoSize = true;
                            question.Text = "Вопрос " + (i + 1) + ": " + Form1.test[Convert.ToInt32(temp[0])].get_question()[i];
                            question.Location = new Point(25, y);
                            panel1.Controls.Add(question);
                            y += 30;
                            Label answer = new Label();
                            answer.AutoSize = true;
                            answer.Text = "Ответ: " + temp[3 + i].ToString();
                            answer.Location = new Point(25, y);
                            panel1.Controls.Add(question);
                            panel1.Controls.Add(answer);
                            y += 50;
                        }
                    }
                    count++;
                }
            }

        }
    }
}
