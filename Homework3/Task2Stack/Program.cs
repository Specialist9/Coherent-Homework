using System;

namespace Task2Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Stack1 = new(3);

            try
            {
                Stack1.Push("Ford");
                Stack1.Push("Toyota");
                Stack1.Push("Opel");
                //Stack1.Push("Audi");

                Console.WriteLine(Stack1.ToString());

                Stack1.Reverse();

                Console.WriteLine(Stack1.ToString());
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Invalid stack index");
            }

        }
    }
}
