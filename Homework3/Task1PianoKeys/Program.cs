using System;

namespace Task1PianoKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Key C1Sharp = new Key(Note.C, Octave.First, Accidental.Sharp);
            Console.WriteLine(C1Sharp.ToString());

            Key C1Sharp2 = new Key(Note.C, Octave.First, Accidental.Sharp);
            Console.WriteLine(C1Sharp2.ToString());

            Key D1flat = new Key(Note.D, Octave.First, Accidental.Flat);
            Console.WriteLine(D1flat.ToString());

            Key D1 = new Key(Note.D, Octave.First);
            Console.WriteLine(D1.ToString());            

            Key D1Sharp = new Key(Note.D, Octave.First, Accidental.Sharp);
            Console.WriteLine(D1Sharp.ToString());


            Key A1flat = new Key(Note.A, Octave.First, Accidental.Flat);
            Console.WriteLine(A1flat.ToString());

            Key A1 = new Key(Note.A, Octave.First);
            Console.WriteLine(A1.ToString());

            Key A1Sharp = new Key(Note.A, Octave.First, Accidental.Sharp);
            Console.WriteLine(A1Sharp.ToString());

            Key B0 = new Key(Note.B, Octave.Zero);
            Console.WriteLine(B0.ToString());

            Key C1 = new Key(Note.C, Octave.First);
            Console.WriteLine(C1.ToString());


            Console.WriteLine();
            
            Console.WriteLine(B0.Equals(C1));
            Console.WriteLine(B0.Equals(C1));
            Console.WriteLine(B0.Equals(C1));
            Console.WriteLine(B0.Equals(C1Sharp));


            Console.WriteLine();
            Console.WriteLine(B0.CompareTo(C1));
            Console.WriteLine(B0.CompareTo(C1));
            Console.WriteLine(B0.CompareTo(C1));
            Console.WriteLine(B0.CompareTo(C1Sharp));

        }
    }
}
