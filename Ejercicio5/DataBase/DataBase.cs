using Ejercicio5.Models;

namespace Ejercicio5.DataBase
{
    class DataBase
    {
        /// <summary>
        /// Método que genera un listado de libros y guardarlos en la sesión para usarlos como BBDD.
        /// </summary>
        public static void MainGenerator()
        {
            List<Book> bookList = RandomBooksGenerator();
            Session.BookSession.AddRange(bookList);

        }

        /// <summary>
        /// Método encargado de generar, de manera aleatoria, nombres y apellidos de diferentes autores.
        /// </summary>
        /// <returns>Cadena formada por un nombre y un apellido generado aleatoriamente.</returns>
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

        /// <summary>
        /// Método encargado de generar, de manera aleatoria, nombres de editoriales.
        /// </summary>
        /// <returns>Cadena formada por un nombre obtenido de manera aleatoria del array de nombres.</returns>
        private static string RandomPublisherNameGenerator()
        {
            string[] arrayOfPublisherNames = { "Perro", "Gato", "Gaviota", "Ratón", "Loro", "Cocodrilo" };

            return arrayOfPublisherNames[new Random().Next(arrayOfPublisherNames.Length)];
        }

        /// <summary>
        /// Método encargado de generar, de manera aleatoria, nombres de libros.
        /// </summary>
        /// <returns>Cadena formada por un nombre obtenido de manera aleatoria de ambos arrays.</returns>
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

        /// <summary>
        /// Método encargado de generar un listado de autores a partir del tamaño que le indiquemos. 
        /// </summary>
        /// <returns>Listado de autores.</returns>
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

        /// <summary>
        /// Método encargado de generar un listado de editoriales a partir del tamaño que le indiquemos.
        /// </summary>
        /// <returns>Listado de editoriales.</returns>
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

        /// <summary>
        /// Método encargado de generar un listado de libros a partir del tamaño que le indiquemos.
        /// </summary>
        /// <returns>Listado de libros.</returns>
        public static List<Book> RandomBooksGenerator()
        {
            int lenghtOfList = 5;
            List<Book> bookList = new();
            List<Author> authorsList = RandomAuthorsGenerator();
            List<Publisher> publisherList = RandomPublishersGenerator();

            // Añadimos ambos listados a la sesión para usarlos como BBDD.
            Session.PublisherSession.AddRange(publisherList);
            Session.AuthorsSession.AddRange(authorsList);

            for (int i = 0; i < lenghtOfList; i++)
            {
                string nameOfBook = RandomBookNameGenerator();
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
