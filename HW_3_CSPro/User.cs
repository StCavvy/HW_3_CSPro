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
        public Genders Gender { get; set; }


        public User()
        {
            Firstname = "Uknown";
            Lastname = "Uknown";
            Age = 0;
            Gender = 0;
        }


        public User(byte Age)
        {
            Firstname = "Uknown";
            Lastname = "Uknown";
            this.Age = Age;
            Gender = 0;
        }


        public override string ToString()
        {
            string AgeCheck = string.Empty;

            if (Age > 10)
            {
                AgeCheck = $"I am {Age} years old. ";
            }
            else
            {
                AgeCheck = "I am baby. ";
            }

            string show = $"Hi, my name is {Firstname} and last name is {Lastname}. " + AgeCheck + $"I am {Gender}";

            return show;
        }

        public static Genders SetGender()
        {
            byte tries = 3;
            bool check = false;
            int choise;

            Console.WriteLine("Your gender : \n0 - Male   1 - Female");

            while (tries > 0 && check == false ) {

                if (tries == 0)
                {
                    Console.WriteLine("Кількість спроб вичерпана, перезапустіть програму!");
                    break;
                }

                choise = Convert.ToByte(Console.ReadLine());

                if (choise == 0) return Genders.Male;
                else if (choise == 1) return Genders.Female;
                else 
                {
                    Console.WriteLine("Wrong input! Try again!");
                    tries--;
                }
            }

            return Genders.Uknown_Entity;

        }
    }
}
