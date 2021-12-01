using System;

namespace Higher_Lower
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();


            Console.WriteLine("Welcome to Higher or lower Are you ready to play");
            Console.WriteLine("");


            Console.WriteLine("Guess The number");

            int GuessNumber = rand.Next(1, 100);
            

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                
                if (input < GuessNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Guess Higher");
                    Console.WriteLine("");

                }

                else if (input > GuessNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Guess Lower");
                    Console.WriteLine("");
 
                }

                else if (input == GuessNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Great You got it the number was:" + GuessNumber);
                    Console.WriteLine("");
                    Console.WriteLine("Please press Enter to Exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                

            }

            
                
            

        }
    }
}
