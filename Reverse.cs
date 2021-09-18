using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Reverse
    {
		static int n, reverse = 0, remainder;
		public static void Main4(String[] args)
		{
			// TODO Auto-generated method stub

			Console.WriteLine("Enter the number: ");
			n = Convert.ToInt32(Console.ReadLine());
			while (n != 0)
			{
				remainder = n % 10;
				reverse = ((reverse * 10) + remainder);
				n = n / 10;
			}
			Console.WriteLine(reverse);
		}
	}
}
