using Ejercicio5.Models;

namespace Ejercicio5.DataBase
{
    class DataBase
    {
        public static void MainGenerator()
        {
            List<Book> bookList = RandomBooksGenerator();
            Session.BookSession.AddRange(bookList);

        }

        private static string RandomAuthorNameGenerator()
        {
            string[] arrayOfNames = { "Juan", "José", "Antonio", "Laura", "María", "Luciana",
            "Martina", "Rocío", "Claudio", "Claudia", "Christian", "Inmaculada", "Sergio"};

            string[] arrayOfLastNames = {"Salado", "Iniesta", "Contreras", "López", "Ronaldo", "Martínez",
            "Pulpo"};

            string randomName = arrayOfNames[new Random().Next(arrayOfLastNames.Length)];
            string randomLastName = arrayOfLastNames[new Random().Next(arrayOfLastNames.Length)];

            return $"{randomName} {randomLastName}";
        }

        private static string RandomPublisherNameGenerator()
        {
            string[] arrayOfPublisherNames = { "Perro", "Gato", "Gaviota", "Ratón", "Loro", "Cocodrilo" };

            return arrayOfPublisherNames[new Random().Next(arrayOfPublisherNames.Length)];
        }

        private static string RandomBookNameGenerator()
        {
            string[] arrayOfBookNames = {"La luna", "El perro", "Las canicas", "Las luciérnagas",
            "La tortuga", "El caniche", "La serpiente", "Dama de noche"};

            string[] arrayOfAdjectives = {"amable", "feliz", "caliente", "triste", "agradable",
                "artista", "pobre", "lúgubre"};

            string randomName = arrayOfBookNames[new Random().Next(arrayOfBookNames.Length)];
            string randomAdjective = arrayOfAdjectives[new Random().Next(arrayOfBookNames.Length)];

            return $"{randomName} {randomAdjective}";
        }

        public static List<Author> RandomAuthorsGenerator()
        {
            int lenghtOfList = 20;
            List<Author> authorList = new();

            for (int i = 0; i < lenghtOfList; i++)
            {
                string name = RandomAuthorNameGenerator();

                Author author = new(name);

                if (!authorList.Contains(author))
                {
                    authorList.Add(author);

                }
                else
                {
                    i--;
                }
            }

            return authorList;
        }

        public static List<Publisher> RandomPublishersGenerator()
        {
            int lenghtOfList = 10;
            List<Publisher> publishersList = new();

            for (int i = 0; i < lenghtOfList; i++)
            {
                string name = RandomPublisherNameGenerator();

                Publisher publisher = new(name);

                if (!publishersList.Contains(publisher))
                {
                    publishersList.Add(publisher);

                }
                else
                {
                    i--;
                }
            }

            return publishersList;
        }

        public static List<Book> RandomBooksGenerator()
        {
            int lenghtOfList = 5;
            List<Book> bookList = new();
            List<Author> authorsList = RandomAuthorsGenerator();
            List<Publisher> publisherList = RandomPublishersGenerator();

            Session.PublisherSession.AddRange(publisherList);
            Session.AuthorsSession.AddRange(authorsList);

            for (int i = 0; i < lenghtOfList; i++)
            {
                string nameOfBook = RandomPublisherNameGenerator();
                Author author = authorsList[new Random().Next(authorsList.Count)];
                Publisher publisher = publisherList[new Random().Next(publisherList.Count)];


                Book book = new(nameOfBook, author, publisher);
                author.BooksWritten.Add(book);
                publisher.PublishedBooks.Add(book);

                if (!bookList.Contains(book))
                {
                    bookList.Add(book);

                }
                else
                {
                    i--;
                }
            }

            return bookList;
        }
    }

}
