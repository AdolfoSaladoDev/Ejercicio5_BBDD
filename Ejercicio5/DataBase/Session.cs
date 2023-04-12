using Ejercicio5.Models;

namespace Ejercicio5.DataBase
{
    internal class Session
    {
        private static List<Author> authorsSession = new();
        private static List<Publisher> publishersSession = new();
        private static List<Book> booksSession = new();

        public static List<Author> AuthorsSession
        {
            get => authorsSession;
            set => authorsSession = value;
        }

        public static List<Publisher> PublisherSession
        {
            get => publishersSession;
            set => publishersSession = value;
        }

        public static List<Book> BookSession
        {
            get => booksSession;
            set => booksSession = value;
        }

    }
}
