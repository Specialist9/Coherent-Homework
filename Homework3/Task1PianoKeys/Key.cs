using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1PianoKeys
{
    struct Key
    {
        public Notes Note;
        public Octaves Octave;
        public Accidentals? Accidental;
        public Key (Notes note, Octaves octave, Accidentals accidental)
        {
            Note = note;
            Octave = octave;
            Accidental = accidental;
        }

        public Key(Notes note, Octaves octave)
        {
            Note = note;
            Octave = octave;
            Accidental = null;
            
        }

        public override string ToString()
        {
            StringBuilder temp = new();

            if(Accidental == null)
            {
                temp.Append($"{Note}{(int)Octave}");
            }
            else
            {
                temp.Append($"{Note}{(char)Accidental}{(int)Octave}");

            }

            return temp.ToString();
        }
    }

    public enum Octaves
    {
        Zero,
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth

    }

    public enum Notes
    {
        C,
        D,
        E,
        F,
        G,
        A,
        B
    }

    public enum Accidentals
    {
        Sharp = '#',
        Flat = 'b'
    }
}
