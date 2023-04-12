using Ejercicio5.Models;

namespace Ejercicio5.Interfaces
{
    internal interface IBook
    {
        public Book AddAuthor(string name);
        public bool RemoveBookByName(string name);
        public bool RemoveBookById(int id);
        public Book ModifyBookName(string oldName, string newName);
        public Book GetPBookById(int id);
        public Book GetBookByName(string name);
        public List<Book> GetAllBooks();
    }
}
