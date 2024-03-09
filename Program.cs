using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < 5; i++)
            {
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

