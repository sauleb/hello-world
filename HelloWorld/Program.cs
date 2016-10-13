using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Program requires at least one argument");
                return;
            }

            string name = args[0];

            Console.WriteLine("Hello," + name + "!");

            Console.ReadLine();
        }
    }
}
