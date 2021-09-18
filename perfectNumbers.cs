using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class perfectNumbers
    {
		public static void Main2(string[] args)
		{
			long n, sum = 0;

			Console.WriteLine("Enter the number: ");
			n = Convert.ToInt32(Console.ReadLine());
			int i = 1;

			while (i <= n / 2)//executes until the condition becomes false    
			{
				if (n % i == 0)
				{
					//calculates the sum of factors  
					sum = sum + i;
					Console.WriteLine(sum + " ");
				}
				i++;
			}
			//compares sum with the number  
			if (sum == n)
			{
				Console.WriteLine(n + " is a perfect number.");
			}
			else
			{
				Console.WriteLine(n + " is not a perfect number.");
			}
		}

	}
}
