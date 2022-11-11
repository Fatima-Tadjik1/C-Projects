using System;

namespace IfStatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please insert your age!");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            if(age < 18)
            {
                Console.WriteLine("You are not allowed to continue!");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
            Console.ReadKey();
        }
    }
}
