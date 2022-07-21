using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,28);
            int startingMultipleNumber = 100;
            int endingMultipleNumber = 999;

            Console.WriteLine("Случайное число: " + randomNumber);
            Console.ReadLine();

            for (int i = startingMultipleNumber; i <= endingMultipleNumber; i += randomNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
