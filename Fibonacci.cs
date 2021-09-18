using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Fibonacci
    {
        static int n1 = 0, n2 = 1, n3, i, count;
        public static void Main1(string[] args)
        {

            Console.WriteLine("Enter the count for Fibonacci series: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2);//printing 0 and 1    

            for (i = 2; i < count; ++i)//loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.WriteLine(" " + n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
