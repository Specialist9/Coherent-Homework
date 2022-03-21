using System;
using System.Collections.Generic;

namespace Task1_Ternary_nrs
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNum, secondNum;

			Console.Write("Enter two integer numbers, one per line \n");
			Console.Write("First number: ");
			firstNum = int.Parse(Console.ReadLine());
			
			Console.Write("Second number: ");
			secondNum = int.Parse(Console.ReadLine());


            List<int> numbers = new List<int>();        //List of numbers between 2 user entered integer numbers
            List<int> numbers2x2 = new List<int>();     // List of numbers with two 2 digits in ternary form

            if (firstNum < secondNum)
			{
				for (int i = firstNum; i <= secondNum; i++)
				{
					numbers.Add(i);
				}
			}
			else
			{
				for (int i = secondNum; i <= firstNum; i++)
				{
					numbers.Add(i);
				}
			}

            string DecimalToTernary(int inputNum)
			{
				string s = "";

				while (Math.Abs(inputNum) > 0)
				{
					s += (inputNum % 3);
					inputNum = inputNum / 3;
				}

				char[] result = s.ToCharArray();

				Array.Reverse(result);
				return new String(result);
			}

            foreach (int number in numbers)
			{
				string x = DecimalToTernary(number);
				int count = 0;
				foreach (char c in x)
				{
					if (c == '2')
					{
						count++;
					}
				}
				if (count == 2)
				{
					numbers2x2.Add(number);
				}

			}

			Console.WriteLine("\n\nList of numbers between user entered numbers: \n");

            foreach (int number in numbers)
			{
				Console.Write(number + ",");
			}

			Console.WriteLine("\n\nList of numbers with exactly two digits 2 in ternary form\n");

            foreach (int number in numbers2x2)
			{
				Console.Write(number + ",");
			}

		}
	}
}
