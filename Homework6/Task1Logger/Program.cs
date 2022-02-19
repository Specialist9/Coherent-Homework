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
            Logger testLogger = new("testing.json");

            Student testStudent = new(345, "Mike", 18, "+37012345678", "mike18@gmail.com");

            Console.WriteLine(testStudent.ToString());

            testLogger.Track(testStudent);

            Logger testLogger2 = new("TestLogger2.json");
            Student testStudent2 = new(123, "John", 21, "+37097654321", "john123@gmail.com");
            Console.WriteLine(testStudent.ToString());


            testLogger2.Track(testStudent2);
        }
    }
}
