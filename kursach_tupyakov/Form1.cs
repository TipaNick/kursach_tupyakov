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
        public static string[] quest = { "Введите ваше имя:", "Как вы себя чувствуете?", "Что вы испытываете в данный момент?" };
        static int[] type = { 0, 1, 2 };
        static string[] ans = { "", "Отлично;Хорошо;Удовлетворительно;Плохо", "Депрессия;Стресс;Боль;Головокружение" };
        public static Test[] test = new Test[5];

        /*public static Test test = new Test(3, quest, type, ans);*/ //Тестовый опрос

        public static string[] doc = { "Alan", "123" }; //Администратор для авторизации
        public static Pateint patient; //Заранее созданный пациент
        public static Doctor doctor; //Заранее созданный доктор

        public Form1()
        {
            InitializeComponent();
            //Инициализируем тесты
            for(int i = 0; i < 5; i++)
            {
                test[i] = new Test();
            }
            //Делаем вручную тест
            test[0] = new Test(3, quest, type, ans);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient_log log_form = new patient_log();
            log_form.ShowDialog();
            patient = new Pateint(log_form.user_name); //Получаем имя из формы
            test_choice test_Choice = new test_choice(); //Форма вызова выбора теста
            test_Choice.ShowDialog();
            //MessageBox.Show(Convert.ToString(test_Choice.choice_test));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor_log doc_log = new doctor_log();
            doc_log.ShowDialog();
            doctor = new Doctor(doc_log.user_name);
            admin_panel admin_Panel = new admin_panel();
            admin_Panel.ShowDialog();

        }
    }
}
