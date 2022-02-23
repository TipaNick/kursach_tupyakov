using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursach_tupyakov
{
    public partial class patient_log : Form
    {
        public string user_name;
        public patient_log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty)
            {
                user_name = textBox1.Text;
                this.Close();
            } else
            {
                MessageBox.Show("Введите имя!");
            }
            
        }
    }
}
