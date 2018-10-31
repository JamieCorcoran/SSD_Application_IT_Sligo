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
            Id = 0;
            Name = "";
            Author = "";
            Publisher = "";
            DatePublished = DateTime.MinValue;
            DatetimeInserted = DateTime.MinValue;
        }
        public Book(int id, string name, string author, string publisher, DateTime datePublished)
        {
            Id = id;
            Name = name;
            Author = author;
            Publisher = publisher;
            DatePublished = datePublished;
            DatetimeInserted = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DatetimeInserted { get; set; }
    }
}
