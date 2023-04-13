using Ejercicio5.Models;
using Ejercicio5.Interfaces;
using Ejercicio5.DataBase;

namespace Ejercicio5.Controllers
{
    internal class BookController : IBook
    {
        public Book AddBook(Book book)
        {
            Session.BookSession.Add(book);

            return book;
        }

        public List<Book> GetAllBooks()
        {
            return Session.BookSession;
        }

        public Book GetBookByName(string name)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            List<Book> books = Session.BookSession;

            foreach (Book book in books)
            {
                if (book.BookId.Equals(id))
                {
                    return book;
                }
            }

            return null;
        }

        public Book ModifyBookName(string oldName, string newName)
        {
            Book book = GetBookByName(oldName);

            book.BookName = newName;

            return book;
        }

        public bool RemoveBookById(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBookByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
