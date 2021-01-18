using System;

namespace GitExerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int hour = DateTime.Now.Hour;

            if ( hour < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            else if(hour < 18)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }

            Console.ReadLine();
        }
    }
}
