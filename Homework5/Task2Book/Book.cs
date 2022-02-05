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
        public int PublicationDate { get; }
        public string[] BookAuthors { get; }
        public string ISBN { get; }

        //Patterns to match when entering ISBN (digits only or digits with dashes)
        Regex ISBNpattern1 = new(@"^[0-9]{13}$");
        Regex ISBNpattern2 = new(@"^[0-9]{3}\-[0-9]\-[0-9]{2}\-[0-9]{6}\-[0-9]$");

        public Book(string title, int date, string[] authors, string isbn)
        {
            Title = String.IsNullOrEmpty(title) ? throw new ArgumentNullException() : title; //check if title empty or null

            PublicationDate = date;

            BookAuthors = (authors.Length != authors.Distinct().Count()) ? throw new ArgumentException() : authors; //check if there are duplicate authors in authors array

            if (ISBNpattern1.IsMatch(isbn)) //check if ISBN is only digits
            {
                ISBN = isbn;
            }
            else if (ISBNpattern2.IsMatch(isbn)) //check if ISBN is digits & dashes
            {
                string ISBNonlyDigits = Regex.Replace(isbn, @"[^0-9]", ""); //remove dashes
                ISBN = ISBNonlyDigits; //store only digits ISBN
            }
            else throw new FormatException(); //if ISBN format is not supported
        }

        public Book()
        {

        }

        public override string ToString()
        {
            StringBuilder temp = new();
            temp.Append($"Title: {Title} / Authors: {string.Join(",", BookAuthors)} / Publication date: {PublicationDate} / ISBN: {ISBN}");
            return temp.ToString();
        }
    }
}
