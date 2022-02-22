using System;
using System.Collections.Generic;
using System.Text;

namespace kursach_tupyakov
{
    public class User
    {
        public string name;

    }
    public class Pateint : User
    { 
        public void do_test(int num)
        {
            test_form test_Form = new test_form(num);
            test_Form.ShowDialog();
        }
        public Pateint(string name)
        {
            this.name = name;
        }
        
    }
    public class Doctor : User
    {
        public Doctor(string name)
        {
            this.name = name;
        }
        public void create_test()
        {

        }
        
        public void del_test()
        {
            
        }
    }
}
