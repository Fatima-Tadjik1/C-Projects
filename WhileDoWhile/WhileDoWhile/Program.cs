using System;

namespace WhileDoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many stars do you want to see?");
            int number = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            while(x < number)
            {
                Console.Write("*");
                x++;
            }
            //============================================
            int game;
            do
            {
                Console.WriteLine("\n What game do you want to play?1 or 2? Please insert 0 to exit!");
                game = Convert.ToInt32(Console.ReadLine());
                if (game == 1)
                {
                    Console.WriteLine("Game 1 is selected!");
                }
                else
                if (game == 2)
                {
                    Console.WriteLine("Game 2 is selected!");
                }
            } while (game != 0);
            Console.ReadKey();
            
        }
    }
}
