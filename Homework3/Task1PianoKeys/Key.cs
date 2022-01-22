using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1PianoKeys
{
    struct Key : IComparable<Key>
    {
        public Note Note;
        public Octave Octave;
        public Accidental Accidental;

        public Key (Note note, Octave octave, Accidental accidental = 0)
        {
            Note = note;
            Octave = octave;
            Accidental = accidental;

            if(Octave == Octave.Zero)
            {
                if(Note != Note.A && Note != Note.B)
                {
                    throw new ArgumentException("Octave 0 has only notes A, B");
                }
            }
            else if(Octave == Octave.Eighth)
            {
                if(Note != Note.C)
                {
                    throw new ArgumentException("Octave 8 has only note C");
                }
            }
        }

        public override string ToString()
        {
            string temp = string.Empty;

            if(Accidental == 0)
            {
                temp = $"{Note}{(int)Octave}";
            }
            else
            {
                temp = $"{Note}{(char)Accidental}{(int)Octave}";
            }

            return temp.ToString();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Key) || obj is null)
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
                if(this.Accidental == Accidental.Sharp && testKey.Accidental == Accidental.Flat)
                {
                    if ( (this.Note == Note.A && testKey.Note == Note.B) ||
                         (this.Note == Note.C && testKey.Note == Note.D) ||
                         (this.Note == Note.D && testKey.Note == Note.E) ||
                         (this.Note == Note.F && testKey.Note == Note.G) ||
                         (this.Note == Note.G && testKey.Note == Note.A)  )
                    {
                        return true;
                    }

                }
                else if(this.Accidental == Accidental.Flat && testKey.Accidental == Accidental.Sharp)
                {
                    if ( (this.Note == Note.B && testKey.Note == Note.A) ||
                         (this.Note == Note.D && testKey.Note == Note.C) ||
                         (this.Note == Note.E && testKey.Note == Note.D) ||
                         (this.Note == Note.G && testKey.Note == Note.F) ||
                         (this.Note == Note.A && testKey.Note == Note.G)  )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Octave.GetHashCode());
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

    public enum Octave
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

    public enum Note
    {
        C,
        D,
        E,
        F,
        G,
        A,
        B
    }

    public enum Accidental
    {
        None = 0,
        Sharp = '#',
        Flat = 'b'
    }
}
