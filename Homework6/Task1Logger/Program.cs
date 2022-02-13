using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger TestLogger = new("testing.json");

            Student TestStudent = new("Mike", 18, "+37012345678", "mike18@gmail.com");

            Console.WriteLine(TestStudent.ToString());

            TestLogger.Track(TestStudent);

            /*foreach(var prop in TestStudent.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name} : {prop.GetValue(TestStudent, null)}");
            }*/

        }
    }
}
