using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2Book
{
    class Book
    {
        public string Title { get; }
        public DateTime PublicationDate { get; }
        public string[] BookAuthors { get; }
        public string ISBN { get; }

        //public Regex ISBNFormat = new();;
        Regex ISBNpattern1 = new(@"^[0-9]{13}$");
        Regex ISBNpattern2 = new(@"^[0-9]{3}\-[0-9]\-[0-9]{2}\-[0-9]{6}\-[0-9]$");

        public Book(string title, DateTime date, string[] authors, string isbn)
        {
            Title = String.IsNullOrEmpty(title) ? throw new ArgumentNullException("ArgNull") : title;

            PublicationDate = date;

            BookAuthors = (authors.Length != authors.Distinct().Count()) ? throw new ArgumentException("ArgEx") : authors;

            if (ISBNpattern1.IsMatch(isbn))
            {
                ISBN = isbn;
            }
            else if (ISBNpattern2.IsMatch(isbn))
            {
                string ISBNonlyDigits = Regex.Replace(isbn, @"[^0-9]", "");
                ISBN = ISBNonlyDigits;
            }
            else throw new FormatException("Wrong format");
        }

        public Book()
        {

        }

        public override string ToString()
        {
            StringBuilder temp = new();
            temp.Append($"Title: {Title} / Authors {BookAuthors} / Publication date: {PublicationDate} / ISBN: {ISBN}");
            return temp.ToString();
        }
    }
}
