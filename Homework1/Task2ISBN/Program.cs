using System;

namespace Task2_ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum;

            Console.Write("Enter a 9 digit number: ");

            inputNum = Console.ReadLine();
            

            char[] tempCharArray = inputNum.ToCharArray();

            double sum = 0;

            for (int i = 0, j = 10; i < tempCharArray.Length && j >= 2; i++, j--)
            {
                sum += j * Char.GetNumericValue(tempCharArray[i]);
            }

            double checkDigit = 11 - sum % 11;

            Console.Write("ISBN number is: ");

            if (checkDigit == 10)
            {
                Console.WriteLine(inputNum + "-X");
            }
            else
            {
                Console.WriteLine(inputNum + '-' + checkDigit);
            }


        }
    }
}
