using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSD_CRUD_APP
{
    class Book
    {
        public Book()
        {
            id = 0;
            name = "";
            author = "";
            publisher = "";
            datePublished = DateTime.MinValue;
            daterimeInserted = DateTime.MinValue;
        }
        int id { get; set; }
        string name { get; set; }
        string author { get; set; }
        string publisher { get; set; }
        DateTime datePublished { get; set; }
        DateTime daterimeInserted { get; set; }
    }
}
