using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_3_CSPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            User user1 = new User(20);

            user1.Gender = User.Genders.Female;

            user1.Firstname = Validate("Ім'я");
            user1.Lastname = Validate("Прізвище");

            user1.Gender = User.Genders.Male;

            Console.Clear();

            Console.WriteLine(user1.ToString());

        }

        public static string Validate(string requesting)
        {
            string input = string.Empty;
            bool check = false;
            while (check == false)
            {
                Console.Write($"{requesting} : ");
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"\d"))
                {
                    Console.WriteLine("Перевірте правильність вводу!");
                }
                else
                {
                    check = true;
                }
            }

            return input;
        }
    }
}