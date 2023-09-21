using System.Text;
using System.Text.RegularExpressions;

namespace HW_3_CSPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            User user1 = new User(20);

            user1.Gender = User.Genders.Female;

            while (check == false)
            {
                Console.Write("Ім'я : ");
                user1.Firstname = Console.ReadLine();
                if (Regex.IsMatch(user1.Firstname, @"\d"))
                {
                    Console.WriteLine("Перевірте правильність вводу!");
                }
                else
                {
                    check = true;
                }
            }

            check = false;

            while (check == false)
            {
                Console.Write("Прізвище : ");
                user1.Lastname = Console.ReadLine();
                if (Regex.IsMatch(user1.Lastname, @"\d"))
                {
                    Console.WriteLine("Перевірте правильність вводу!");
                }
                else
                {
                    check = true;
                }
            }

            Console.Clear();

            Console.WriteLine(user1.ToString());
        }
    }
}