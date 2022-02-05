using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Book
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] TestBook1Authors = new string[2] { "Mike", "John" };

                Book TestBook1 = new("Test1", 1981, TestBook1Authors, "123-4-56-789123-4");

                Book TestBook2 = new("Test2", 1990, new string[2]{ "Chris", "James" }, "123-4-56-789123-5");

                Console.WriteLine("//////////////////////////");

                Catalog Catalog1 = new();
                Console.WriteLine("catalog created");

                Catalog1.AddBook(TestBook1);
                Console.WriteLine("TB1 added");

                Catalog1.AddBook(TestBook2);
                Console.WriteLine("TB2 added");


                Console.WriteLine(Catalog1["1234567891234"]);
                Console.WriteLine(Catalog1["1234567891235"]);
                //Console.WriteLine(Catalog1["1234567891236"]);


            }
            catch (ArgumentNullException) { Console.WriteLine("Book title wasn't entered or is empty"); }

            catch (ArgumentException) { Console.WriteLine("Duplicate authors entered"); }

            catch (FormatException) { Console.WriteLine("ISBN wrong format"); }

            catch (InvalidOperationException) { Console.WriteLine("ISBN already exists"); }

            catch (KeyNotFoundException) { Console.WriteLine("Book doesn't exist"); }

        }
    }
}
