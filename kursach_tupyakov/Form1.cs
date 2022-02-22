using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_tupyakov
{
    public partial class Form1 : Form
    {
        public static string[] quest = { "1", "2", "3" };
        static int[] type = { 0, 0, 0 };
        static string[] ans = { "1", "2", "3" };
        public static Test test = new Test(3, quest, type, ans);

        public static string[] doc = { "Alan", "123" }; //Администратор
        public static Pateint patient;
        public static Doctor doctor;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient_log log_form = new patient_log();
            log_form.ShowDialog();
 
            patient = new Pateint(log_form.user_name);

            test_choice test_Choice = new test_choice();
            test_Choice.ShowDialog();
            //MessageBox.Show(Convert.ToString(test_Choice.choice_test));
            
        }
    }
}
