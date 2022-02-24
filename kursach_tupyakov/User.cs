using System;
using System.Collections.Generic;
using System.Text;

namespace kursach_tupyakov
{
    public class User
    {
        protected string name;
        public string get_name()
        {
            return name;
        }
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
            create_test crtest = new create_test();
            crtest.ShowDialog();
        }
        
        public void del_test()
        {
            del_test deltest = new del_test();
            deltest.ShowDialog();
        }

        public void check_result()
        {
            check_result check_Result = new check_result();
            check_Result.ShowDialog();
        }
    }
}
