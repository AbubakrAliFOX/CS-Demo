using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime date1;
            string dateString = "3/8/2024";
            DateTime.TryParse(dateString, out date1);
            Console.WriteLine(date1);

        }
    }
}

