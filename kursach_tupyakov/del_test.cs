using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursach_tupyakov
{
    public partial class del_test : Form
    {
        public del_test()
        {
            InitializeComponent();
        }

        private void del_test_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ячейка 1":
                    Form1.test[0].set_power(0);
                    break;
                case "Ячейка 2":
                    Form1.test[1].set_power(0);
                    break;
                case "Ячейка 3":
                    Form1.test[2].set_power(0);
                    break;
                case "Ячейка 4":
                    Form1.test[3].set_power(0);
                    break;
                case "Ячейка 5":
                    Form1.test[4].set_power(0);
                    break;
            }
            MessageBox.Show("Удаление прошло успешно");
            this.Close();
        }
    }
}
