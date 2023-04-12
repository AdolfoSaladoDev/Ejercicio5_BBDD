namespace Ejercicio5.Models
{
    internal class Author
    {
        private int authorId;
        private string authorName;
        private List<Book> booksWritten;

        public Author(string authorName)
        {
            authorId = Utils.Utils.CreateRandomId();
            this.authorName = Utils.Utils.CheckName(authorName);
            booksWritten = new();
        }

        public int AuthorId { get => authorId; }

        public string AuthorName { get => authorName; set => authorName = value; }

        public List<Book> PublishedBooks { get => booksWritten; set => booksWritten = value; }
    }
}
