using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1PianoKeys
{
    struct Key : IComparable<Key>
    {
        public Notes Note;
        public Octaves Octave;
        public Accidentals Accidental;

        public Key (Notes note, Octaves octave, Accidentals accidental = 0)
        {
            Note = note;
            Octave = octave;
            Accidental = accidental;

            if(Octave == Octaves.Zero)
            {
                if(Note != Notes.A && Note != Notes.B)
                {
                    throw new ArgumentException("Octave 0 has only notes A, B");
                }
            }
            else if(Octave == Octaves.Eighth)
            {
                if(Note != Notes.C)
                {
                    throw new ArgumentException("Octave 8 has only note C");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder temp = new();

            if(Accidental == 0)
            {
                temp.Append($"{Note}{(int)Octave}");
            }
            else
            {
                temp.Append($"{Note}{(char)Accidental}{(int)Octave}");

            }

            return temp.ToString();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Key))
            {
                return false;
            }
            
            var testKey = (Key)obj;

            if(this.Octave == testKey.Octave && this.Note == testKey.Note && this.Accidental == testKey.Accidental)
            {
                return true;
            }

            if(this.Octave == testKey.Octave)
            {
                if(this.Accidental == Accidentals.Sharp && testKey.Accidental == Accidentals.Flat)
                {
                    if ( (this.Note == Notes.A && testKey.Note == Notes.B) ||
                         (this.Note == Notes.C && testKey.Note == Notes.D) ||
                         (this.Note == Notes.D && testKey.Note == Notes.E) ||
                         (this.Note == Notes.F && testKey.Note == Notes.G) ||
                         (this.Note == Notes.G && testKey.Note == Notes.A)  )
                    {
                        return true;
                    }

                }
                else if(this.Accidental == Accidentals.Flat && testKey.Accidental == Accidentals.Sharp)
                {
                    if ( (this.Note == Notes.B && testKey.Note == Notes.A) ||
                         (this.Note == Notes.D && testKey.Note == Notes.C) ||
                         (this.Note == Notes.E && testKey.Note == Notes.D) ||
                         (this.Note == Notes.G && testKey.Note == Notes.F) ||
                         (this.Note == Notes.A && testKey.Note == Notes.G)  )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (this.ToString()).GetHashCode();
        }

        public int CompareTo(Key other)
        {
            if(this.Octave == other.Octave)
            {
                if(this.Note == other.Note)
                {
                    return this.Accidental.CompareTo(other.Accidental);
                }
                else if (this.Equals(other))
                {
                    return 0;
                }

                return this.Note.CompareTo(other.Note);
            }

            return this.Octave.CompareTo(other.Octave);
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
        None = 0,
        Sharp = '#',
        Flat = 'b'
    }
}
