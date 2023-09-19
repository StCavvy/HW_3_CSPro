namespace HW_3_CSPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine(user1.Firstname);
            Console.WriteLine(user1.Lastname);
            Console.WriteLine(user1.Age);
            if (user1.gender_is_male = true)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }
        }
    }
}