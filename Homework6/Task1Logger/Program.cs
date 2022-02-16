using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AttributeLibrary;

namespace Task1Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger TestLogger = new("testing.json");

            Student TestStudent = new(345, "Mike", 18, "+37012345678", "mike18@gmail.com");

            Console.WriteLine(TestStudent.ToString());

            TestLogger.Track(TestStudent);

            Logger TestLogger2 = new("TestLogger2.json");
            Student TestStudent2 = new(123, "John", 21, "+37097654321", "john123@gmail.com");
            Console.WriteLine(TestStudent.ToString());


            TestLogger2.Track(TestStudent2);
        }
    }
}
