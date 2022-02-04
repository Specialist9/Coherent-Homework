using System;

namespace Task2Book
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] TestBook1Authors = new string[2] { "Mike", "John" };
                DateTime TestBookPubTime = new(1981, 01, 01);
                Book TestBook1 = new("Test1", TestBookPubTime, TestBook1Authors, "123-4-56-789123-4");
                Console.WriteLine(TestBook1.Title);
                Console.WriteLine(TestBook1.PublicationDate);
                Console.WriteLine(TestBook1.BookAuthors);
                Console.WriteLine(TestBook1.ISBN);
                Console.WriteLine("//////////////////////////");


                Catalog Catalog1 = new();
                Catalog1.AddBook(TestBook1);
                Console.WriteLine(Catalog1["1234567891234"]);

            }
            catch (ArgumentNullException) { Console.WriteLine("Book title wasn't entered or is empty"); }

            catch (ArgumentException) { Console.WriteLine("Duplicate authors entered"); }

            catch (FormatException) { Console.WriteLine("ISBN wrong format"); }

        }
    }
}
