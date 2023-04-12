namespace Ejercicio5.Models
{
    internal class Book
    {
        private readonly int bookId;
        private readonly string bookName;
        private Author author;
        private Publisher publisher;

        public Book(string newName, Author author, Publisher publisher)
        {
            bookId = Utils.Utils.CreateRandomId();
            bookName = Utils.Utils.CheckName(newName);
            this.author = author;
            this.publisher = publisher;
        }

        public int BookId { get => bookId; }
        public string BookName { get => bookName; }
        public Author Author { get => author; }
        public Publisher Publisher { get => publisher; }
    }
}
