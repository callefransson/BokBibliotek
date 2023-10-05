using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BokBibliotek
{
    internal class Book
    {
        //egenskaperna som används i programmet

        public string _title;
        public string _author;
        public string _summary;
        public Book(string title, string auther, string summary) //Konstruktorn som initierar värderna på variablerna
        {
            _title = title;
            _author = auther;
            _summary = summary;
        }

        public void PrintBook() // Metoden för att skriva ut värderna i variablerna
        {
            Console.WriteLine("The title of the book : {0}\nAuther: {1}\nSummary of the book: {2}",_title,_author,_summary);
        }
    }
}
