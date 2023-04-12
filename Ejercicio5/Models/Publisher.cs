namespace Ejercicio5.Models
{
    internal class Publisher
    {
        private int publisherId;
        private string publisherName;
        private List<Book> publishedBooks;

        public Publisher(string publisherName)
        {
            publisherId = Utils.Utils.CreateRandomId();
            this.publisherName = publisherName;
            this.publishedBooks = new();
        }

        public int PublisherId { get => publisherId; }
        public string PublisherName { get => publisherName; set => publisherName = value; }
        public List<Book> PublishedBooks { get => publishedBooks; set => publishedBooks = value; }
    }
}
