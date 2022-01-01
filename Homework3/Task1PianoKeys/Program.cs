using System;

namespace Task1PianoKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Key Test1 = new Key(Notes.C, Octaves.First, Accidentals.Sharp);
            Console.WriteLine(Test1.ToString());

            Key Test2 = new Key(Notes.D, Octaves.First);
            Console.WriteLine(Test2.ToString());
        }
    }
}
