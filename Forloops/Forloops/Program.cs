using System;

namespace Forloops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number, we will give you the sum of previous even numbers:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0; 
            for(int i = 2; i < number; i += 2)
            {
                sum = sum + i; 
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
