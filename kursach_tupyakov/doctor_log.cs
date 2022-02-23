using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursach_tupyakov
{
    public partial class doctor_log : Form
    {
        public string user_name;
        public doctor_log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text == Form1.doc[0])
            {
                if (textBox2.Text == String.Empty || textBox1.Text == Form1.doc[1])
                {
                    user_name = textBox1.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите корректный пароль!");
                }
                //MessageBox.Show("1");
            } else
            {
                MessageBox.Show("Введите корректное имя!");
            }
        }
    }
}
