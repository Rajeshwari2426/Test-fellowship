using System;

namespace TestProjects
{
    class FibonacciSeries
    {
        public void FindFibonacciSeries()
        {
            Console.WriteLine("Please enter how many fibonocci numbers we have to generate ");
            int number = Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1;
            int result = 0;
            result = first + second;
            Console.Write("{0} {1} {2}", first, second, result);
            for (int i = 3; i < number; i++)
            {
                first = second;
                second = result;
                result = first + second;
                Console.Write(" " + result);
            }
        }
    }
}
