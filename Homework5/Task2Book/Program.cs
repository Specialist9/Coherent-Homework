using System;

namespace Task2Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TestBook1Authors = new string[2] {"Mike", "John"};
            DateTime TestBookPubTime = new(1981, 01, 01);
            Book TestBook1 = new("Test1", TestBookPubTime, TestBook1Authors, "123-4-56-789123-4");
            Console.WriteLine(TestBook1.Title);
            Console.WriteLine(TestBook1.PublicationDate);
            Console.WriteLine(TestBook1.BookAuthors);
            Console.WriteLine(TestBook1.ISBN);


        }
    }
}
