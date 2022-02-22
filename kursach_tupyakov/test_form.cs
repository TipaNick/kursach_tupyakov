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
    }
}
