using System;
using System.Linq;

namespace Task3_MinMaxSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrayLength;

			Console.Write("Enter the number of elements:  ");

			arrayLength = int.Parse(Console.ReadLine());

			int[] numbersArray = new int[arrayLength];

			for (int i = 0; i < numbersArray.Length; i++)
			{
				Console.Write("Enter integer element Nr. " + i + ":  ");
				numbersArray[i] = int.Parse(Console.ReadLine());
			}

			Console.Write("\nEntered array of numbers:  ");
			foreach (int number in numbersArray)
			{
				Console.Write(number + ",");
			}


			int firstMinIndex = Array.IndexOf(numbersArray, numbersArray.Min());
			int lastMaxIndex = Array.LastIndexOf(numbersArray, numbersArray.Max());

			int subsum = 0;
			if (firstMinIndex < lastMaxIndex)
			{
				for (int i = firstMinIndex; i <= lastMaxIndex; i++)
				{
					subsum += numbersArray[i];
				}
			}
			else
			{
				for (int i = lastMaxIndex; i <= firstMinIndex; i++)
				{
					subsum += numbersArray[i];
				}
			}

			Console.Write("\nThe sum of all elements between min and max values of the array is:  ");
			Console.WriteLine(subsum);
		}
	}
}
