using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string zig = "Nobody cares how much you know," +
                " until they know how much you care.";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

        }
    }
}
