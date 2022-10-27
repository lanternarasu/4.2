using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Class1
    {
        private string name;
        private string mobile_no;
        private int age;
        private int a = 1, b = 0, c;
        public void action()
        {
            Console.WriteLine("Enter your name");
            try
            {
                name = Console.ReadLine();
                bool result = name.All(char.IsNumber);
                if(result == true)
                {
                    c = a / b;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("name is invalid");
            }
            try
            {
                Console.WriteLine("Enter your mobile no: ");
                mobile_no = Console.ReadLine();
                var len = mobile_no.Length;
                if(len != 10)
                {
                    c = a / b;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("mobile number is invalid");
            }
        }
    }
}
