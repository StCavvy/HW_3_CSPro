using System.Text;

namespace HW_3_CSPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //додаємо українську мову для коректного відображення в консолі
            Console.OutputEncoding = Encoding.UTF8;

            //створюємо об'єкт класу User
            User user1 = new User(20);

            //задаємо стать
            user1.gender_is_male = true;

            //реалізація вводу імені та прізвища
            Console.Write("Ім'я : ");
            user1.Firstname = Console.ReadLine();

            Console.Write("Прізвище : ");
            user1.Lastname = Console.ReadLine();

            //чистимо консоль, аби не заважало
            Console.Clear();

            //визиваємо метод, який відобразить данні нашого юзера
            user1.ShowUser();
        }
    }
}