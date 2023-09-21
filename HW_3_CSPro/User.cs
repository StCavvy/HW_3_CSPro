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
            Firstname = "Невідомо";
            Lastname = "Невідомо";
            Age = 0;
            Gender = 0;
        }


        public User (byte Age)
        {
            Firstname = "Невідомо";
            Lastname = "Невідомо";
            this.Age = Age;
            Gender = 0;
        }
        

        public override string ToString()
        {
            string show = $"Ім'я : {Firstname} \nПрізвище : {Lastname} \nВік : {Age} \nСтать : {Gender} ";
            return show ;
        }

        public enum Genders
        {
            Male = 0,
            Female = 1
        }
    }
}
