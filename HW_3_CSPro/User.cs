using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_CSPro
{
    internal class User
    {
        //проперті
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte Age { get; }
        public bool gender_is_male { get; set; }


        //дефолтний конструктор
        public User()
        {
            Firstname = "Невідомо";
            Lastname = "Невідомо";
            Age = 0;
            gender_is_male = true;
        }


        //конструктор з можливістю вказати пропертю Age
        public User (byte Age)
        {
            Firstname = "Невідомо";
            Lastname = "Невідомо";
            this.Age = Age;
            gender_is_male = true;
        }
        

        //метод, який відображає дані про юзера
        public void ShowUser()
        {
            Console.WriteLine("Ім'я : {0}", Firstname);
            Console.WriteLine("Прізвище : {0}", Lastname);
            Console.WriteLine("Рік : {0}", Age);
            Console.Write("Стать : ");
            if (gender_is_male == true) { Console.WriteLine("чоловіча"); }
            else { Console.WriteLine("жіноча"); }
        }

    }
}
