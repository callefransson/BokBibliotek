using System.Globalization;

namespace BokBibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("title","auther", "summary"); 

            Console.WriteLine("Please write the title of the book");
            book._title = Console.ReadLine();
            Console.WriteLine("Please write in the auther of the book");
            book._author = Console.ReadLine();
            Console.WriteLine("Please write in the summary of the book");
            book._summary = Console.ReadLine();

            book.PrintBook();// Anropar metoden för att se vad användaren skrev 
        }
    }
}