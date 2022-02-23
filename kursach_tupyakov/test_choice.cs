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
    public partial class test_choice : Form
    {
        public int choice_test;
        public test_choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.patient.do_test(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.patient.do_test(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.patient.do_test(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.patient.do_test(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.patient.do_test(4);
        }

        private void test_choice_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                if (Form1.test[i].get_power() == 0)
                {
                    this.Controls["button" + (i + 1)].Enabled = false;
                }
            }
        }
    }
}
