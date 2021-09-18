using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class PrimeNumbers
    {
		static int i, n, m = 0, flag = 0;

		public static void Main3(String[] args)
		{
			// TODO Auto-generated method stub

			Console.WriteLine("Enter the number: ");
			n = Convert.ToInt32(Console.ReadLine());
			m = n / 2;

			if (n == 0 || n == 1)
			{
				Console.WriteLine(n + " is not prime number");
			}
			else
			{
				for (i = 2; i <= m; i++)
				{
					if (n % i == 0)
					{
						Console.WriteLine(n + " is not prime number");
						flag = 1;
						break;
					}
				}
				if (flag == 0)
				{
					Console.WriteLine(n + " is prime number");
				}
			}
		}
	}
}
