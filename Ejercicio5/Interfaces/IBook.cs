using Ejercicio5.Models;

namespace Ejercicio5.Interfaces
{
    internal interface IBook
    {
        public Book AddBook(Book book);
        public bool RemoveBookByName(string name);
        public bool RemoveBookById(int id);
        public Book ModifyBookName(string oldName, string newName);
        public Book GetBookById(int id);
        public Book GetBookByName(string name);
        public List<Book> GetAllBooks();
    }
}
