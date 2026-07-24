using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    internal class Book
    {
        

        public string ISBN { get;}

        public string Title { get; set; }

        public Book(string iSBN, string title)
        {
            ISBN = iSBN;
            Title = title;
        }

        public override string ToString() => $"ISBN : {ISBN} Title : {Title}";
        

    }
}
