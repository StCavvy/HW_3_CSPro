using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_3_CSPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(7);

            user1.Firstname = Validate("Name");
            user1.Lastname = Validate("Lastname");
            user1.Gender = User.SetGender();
            Console.Clear();

            Console.WriteLine(user1.ToString());

        }

        public static string Validate(string requesting)
        {
            string input = string.Empty;
            bool check = false;
            byte tries = 3;
            while (check == false && tries > 0)
            {
                Console.Write($"{requesting} : ");
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"\d"))
                {
                    Console.WriteLine("Wrong input! Try again!");
                    input = "Uknown";
                    tries--;
                }
                else
                {
                    check = true;
                }
            }

            if (tries == 0)
            {
                Console.WriteLine("You have wasted all tries!");
            }
            return input;
        }
    }
}