using System;

namespace _07._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("tarix yazin:");
            DateTime date;

            string dateStr = Console.ReadLine();
            date = Convert.ToDateTime(dateStr);

            Console.WriteLine("gun:"+date.Day);
            Console.WriteLine("ay:"+date.Month);
            Console.WriteLine("il:"+date.Year);

        }
    }
}
