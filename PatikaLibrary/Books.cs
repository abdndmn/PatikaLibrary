using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    internal class Books//Class
    {
        
        public string BookName { get; set; }//Property:
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set;}
        public int PageNumber { get; set; }
        public string Publisher { get; set; }
        public DateTime RegisterDate { get; set; }

        public Books()//Default Constructor
        {
            RegisterDate = DateTime.Now;
        }

        public Books(string bookName, string authorName,string authorSurname,int pageNumber,string publisher)//Parametre alan alternatif constructor
        {
            BookName = bookName;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PageNumber = pageNumber;
            Publisher = publisher;
                
            RegisterDate= DateTime.Now;

        }
    }
}
