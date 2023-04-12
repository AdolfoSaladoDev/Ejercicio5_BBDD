using Ejercicio5.Models;

namespace Ejercicio5
{
    public class Ejercicio4
    {
        static void Main()
        {
            Author firstAuthor = new("Autor Uno");
            Publisher firstPublisher = new("Editorial Uno");

            Book firstBook = new("Primer Libro", firstAuthor, firstPublisher);
            firstAuthor.BooksWritten.Add(firstBook);
            firstPublisher.PublishedBooks.Add(firstBook);

            Console.WriteLine($"{firstBook.BookId} - {firstBook.BookName}");
        }
    }
}