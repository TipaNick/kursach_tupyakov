using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursach_tupyakov
{
    public partial class create_test : Form
    {
        int num_quest, num_test, count = 0;
        string[] question, answers;
        int[] type;
        public create_test()
        {
            InitializeComponent();
        }

        private void create_test_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox2.SelectedItem = comboBox2.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_quest = Convert.ToInt32(comboBox2.Text);
            switch (comboBox1.Text)
            {
                case "Ячейка 1":
                    num_test = 0;
                    break;
                case "Ячейка 2":
                    num_test = 1;
                    break;
                case "Ячейка 3":
                    num_test = 2;
                    break;
                case "Ячейка 4":
                    num_test = 3;
                    break;
                case "Ячейка 5":
                    num_test = 4;
                    break;
            }
            button_create(num_quest);
            question = new string[num_quest];
            type = new int[num_quest];
            answers = new string[num_quest];
        }

        public void button_create(int num_quest)
        {
            this.Controls.Clear();
            Label name = new Label();
            name.AutoSize = true;
            name.Text = "Введите вопрос " + (count + 1) +":";
            name.Location = new Point(66, 15);
            this.Controls.Add(name);

            TextBox txb = new TextBox();
            txb.Location = new Point(66, 45);
            txb.Size = new Size(300, 23);
            txb.Name = "textBox";
            this.Controls.Add(txb);

            Label type = new Label();
            type.AutoSize = true;
            type.Text = "Выберите тип ответа:";
            type.Location = new Point(66, 90);
            this.Controls.Add(type);

            ComboBox type_choise = new ComboBox();
            type_choise.Size = new Size(140, 23);
            type_choise.Name = "choise";
            type_choise.DropDownStyle = ComboBoxStyle.DropDownList;
            type_choise.Items.Add("Поле ввода");
            type_choise.Items.Add("Выбор одного из");
            type_choise.Items.Add("Выбор нескольких");
            type_choise.SelectedItem = type_choise.Items[0];
            type_choise.Location = new Point(66, 115);
            type_choise.SelectedValueChanged += Type_choise_SelectedValueChanged;
            this.Controls.Add(type_choise);

            Panel pn = new Panel();
            pn.Name = "panel";
            pn.Size = new Size(315, 200);
            pn.Location = new Point(66, 160);
            this.Controls.Add(pn);

            Button bt = new Button();
            if(count + 1 == num_quest)
            {
                bt.Text = "Завершить";
            } else
            {
                bt.Text = "Следующий";
            }
            bt.Size = new Size(150, 40);
            bt.Location = new Point(150, 370);
            bt.Click += Bt_Click;
            this.Controls.Add(bt);

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            question[count] = this.Controls["textBox"].Text;
            type[count] = (this.Controls["choise"] as ComboBox).SelectedIndex;
            switch (type[count])
            {
                case 1:
                case 2:
                    string temp = 
                        this.Controls["panel"].Controls["textBox1"].Text + ";" +
                        this.Controls["panel"].Controls["textBox2"].Text + ";" +
                        this.Controls["panel"].Controls["textBox3"].Text + ";" +
                        this.Controls["panel"].Controls["textBox4"].Text;
                    answers[count] = temp;
                    break;
            }
            
            count++;
            if(count == num_quest)
            {
                Form1.test[num_test].make_test(num_quest, question, type, answers);
                MessageBox.Show("Опрос создан");
                this.Close();
            }
            else
            {
                button_create(num_quest);
            }
        }

        private void Type_choise_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (sender as ComboBox);
            this.Controls["panel"].Controls.Clear();

            if (cmb.SelectedIndex == 1 || cmb.SelectedIndex == 2)
            {
                int y = 20;
                for(int i = 0; i < 4; i++)
                {
                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Text = "Вариант " + (i + 1) + ":";
                    lb.Location = new Point(20, y);
                    this.Controls["panel"].Controls.Add(lb);

                    TextBox txb = new TextBox();
                    txb.Size = new Size(190, 23);
                    txb.Location = new Point(90, y-5);
                    txb.Name = "textBox" + (i + 1);
                    this.Controls["panel"].Controls.Add(txb);

                    y += 40;
                }
            }
        }
    }
}
