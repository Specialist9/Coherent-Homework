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


    }
}
