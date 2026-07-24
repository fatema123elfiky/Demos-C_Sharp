using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    internal class Library
    {
        public List<Book> Books {  get; set; }

        public Library() {
        
            Books = new List<Book>();
        
        }


        // indexer to add and get

        public Book this [string isbn]
        {
            get
            {
                if (Books != null && !string.IsNullOrEmpty(isbn))
                {
                    // list works with foreach as it has getenumerartor
                    foreach (var book in Books)
                    {
                        if (book.ISBN == isbn)
                            return book;
                    }
                }

                return null;
            }
        }

        public Book this[int idx]
        {
            get
            {
                if (Books != null && idx >=0 && idx< Books.Count) 
                    return Books[idx];
                return null;
            }
        }

        // maybe multi-parameter indexer

    }
}
