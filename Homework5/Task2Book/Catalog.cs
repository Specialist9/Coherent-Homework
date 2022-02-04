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
                Book result = new();
                foreach(var book in BookList)
                {
                    if (book.ISBN == isbn)
                    {
                        result = book;
                    }
                    else
                    {
                        throw new KeyNotFoundException("TestMessage");
                    }
                }
                return result;
            }

        }

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }
    }
}
