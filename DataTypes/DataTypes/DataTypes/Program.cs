using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            int y;
            x = 9;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("Whats your Name?");
            Console.Write("Enter the first name");
            string firstName = Console.ReadLine();
            Console.Write("Enter the Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("your NAME is: " + firstName +" " +  lastName);
            Console.ReadLine();


        }
    }
}
