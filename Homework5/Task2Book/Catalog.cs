using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Book
{
    class Catalog
    {
        public List<Book> BookList { get; private set; }

        public Catalog()
        {
            BookList = new();
        }

        public Book this [string isbn]
        {
            get
            {
                Book result = new(); //temp reference to Book obj
                bool bookExists = false; 
                foreach(var book in BookList) //check if book with this ISBN exists in catalog
                {
                    if (book.ISBN == isbn)
                    {
                        result = book;
                        bookExists = true;
                    }
                }
                if (!bookExists)
                {
                    throw new KeyNotFoundException();
                }  
                return result;
            }

        }

        public void AddBook(Book book)
        {
            bool isbnExists = false;
            foreach(var item in BookList)
            {
                if(item.ISBN == book.ISBN)
                {
                    isbnExists = true;
                }
            }
            if (isbnExists)
            {
                throw new InvalidOperationException();
            }
            else
            {
                BookList.Add(book);
            }
        }

    }
}
