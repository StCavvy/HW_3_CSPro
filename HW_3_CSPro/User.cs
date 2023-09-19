using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_CSPro
{
    internal class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte Age { get; }
        public bool gender_is_male { get; set; }

        public User()
        {
            Firstname = "Невідомо";
            Lastname = "Невідомо";
            Age = 0;
            gender_is_male = true;
        }

        public User (byte Age)
        {
            Firstname = "Невідомо";
            Lastname = "Невідомо";
            this.Age = Age;
            gender_is_male = true;
        }

    }
}
