using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_Tables_Quiz
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            int score = 0;
            Console.WriteLine("Hello! Welcome to the times tables quiz! Press any key to start."); Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int num1 = random.Next(1, 12); int num2 = random.Next(1, 12); int answer = num1 * num2;
                Console.WriteLine("What is {0} times {1}?", num1, num2);
                int response;
                while (true)
                {
                    try
                    {
                        response = int.Parse(Console.ReadLine()); break;

                    }
                    catch
                    {
                        Console.WriteLine("bro what r u doing bro that just is not a number LOL loser try again");
                    }
                }
                if (response == answer)
                {
                    Console.WriteLine("\nCorrect!");
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect.");
                }
            }
            Console.WriteLine("Your score was {0} out of 10\nWould you like to play again? (y/n)", score);
            string replay = Console.ReadLine();
            if (replay == "y") {Main();}
        }
    }
}
