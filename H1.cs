using system;

namespace Hands_on
{
    internal class _1
    {
        static void main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age :");
            age = int.parse(Console.ReadLine());
            Console.WriteLine("Enter your country :");
            string country = Console.ReadLine();
            Console.WriteLine($"welocome {name}. Your age is {age} and you are from {country}");
        }
    }
}