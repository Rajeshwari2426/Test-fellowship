using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjects
{
    internal class PrimeNumber
    {
        public static void prime()
        {
            int num,m=0 ;
            Console.WriteLine("enter number to check prime or not");
            num=Convert.ToInt32(Console.ReadLine());
            //  m = num / 2;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    m++;
                }
            }
            if(m == 2)
            { 
                    Console.WriteLine("number is prime");
            }
           else
           {
                Console.WriteLine("number is not prime");
           }
           
            Console.ReadLine();
        }
        

    }
}
