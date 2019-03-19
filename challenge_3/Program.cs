using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    class Program
    {

        class PuzzleEquation
        {
            private string Version ;

            public PuzzleEquation()
            {
                Version = "1.2";
            }


            public string About()
            {
                return ("1.1");

            }
        }

        static void Main(string[] args)
        {
            PuzzleEquation puzzleEquation = new PuzzleEquation();

            Console.WriteLine(puzzleEquation.About());

            Console.WriteLine("Would you like to start the quiz");
            int cor = 0;
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                Console.WriteLine("You have 10 seconds to answer each of these 10 questions");
                Console.WriteLine("when you are ready please type 'start'");
            }
            else
            {
                Console.WriteLine("Please try again later");
                Console.Read();
                return;
            }

            input = Console.ReadLine().ToLower();

            if (input== "start")
            {
                for (int i = 0; i < 9; i++)
                {
                    Random rnd = new Random();
                    int num_1 = rnd.Next(1, 100);
                    int num_2 = rnd.Next(1, 100);
                    int answer = num_1 + num_2;
                    Console.WriteLine("Q what does " + num_1 + " + " + num_2 + " equal");

                    DateTime t1 = DateTime.Now;
                    String guess = Console.ReadLine();
                    DateTime t2 = DateTime.Now;

                    int seconds = (t2 - t1).Seconds;
                    Console.WriteLine(seconds + " seconds");
                    if (guess == answer.ToString() && seconds <= 10 )
                    {
                        Console.WriteLine("correct");
                        cor++;
                    }
                    else
                    {
                        Console.WriteLine("incorrect or took too long!");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Please try again later");
                Console.Read();
                return;
            }
            Console.WriteLine("you got " + cor + " out of 10 correct");
            Console.Read();
        }
    }
}
