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
        public test_choice()
        {
            InitializeComponent();
        }

        private void test_choice_Load(object sender, EventArgs e)
        {
            string path = "tests.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                //MessageBox.Show(line);

            }
        }
    }
}
