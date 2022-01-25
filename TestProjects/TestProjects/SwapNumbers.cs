using System;

namespace TestProjects
{
    internal class SwapNumbers
    {
        public static void SwapTwoNumbers()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("please enter first number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping numbers :first={0},second={1}", firstNum, secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("after swapping numbers :first ={ 0},second ={1}", firstNum, secondNum);

        }
      
       
     
    }
}
