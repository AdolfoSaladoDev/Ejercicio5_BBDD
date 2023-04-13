using Ejercicio5.Models;
using Ejercicio5.DataBase;
using Ejercicio5.Controllers;

namespace Ejercicio5
{
    public class Ejercicio5
    {

        static PublisherController publisherManager = new PublisherController();

        static void Main()
        {
            // GENERA LA BASE DE DATOS
            DataBase.DataBase.MainGenerator();

            LogicMainMenu();
        }

        private static void LogicMainMenu()
        {
            string optionString = CheckOptionMainMenu();


            switch (optionString)
            {
                case "1":
                    PrintAllAuthorInformation();
                    LogicMainMenu();
                    break;
                case "2":
                    PrintAllPublisherInformation();
                    LogicMainMenu();
                    break;
                case "3":
                    PrintAllBooksInformation();
                    LogicMainMenu();
                    break;
                case "4":
                    AddNewPublisher();
                    break;
                case "0":
                    PrintExitInformation();
                    break;
            }


        }

        private static void PaintMenu()
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenid@ a la Biblioteca de Alejandría!");
            Console.WriteLine("1.- Ver información de autores.");
            Console.WriteLine("2.- Ver información de editoriales.");
            Console.WriteLine("3.- Ver información de libros.");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("4.- Añadir una nueva editorial.");
            Console.WriteLine("5.- Añadir un nuevo autor.");
            Console.WriteLine("6.- Añadir un nuevo libro.");
            Console.WriteLine("0.- Salir.");
            Console.Write("Selecciona una opción: ");
        }

        private static string CheckOptionMainMenu()
        {
            PaintMenu();

            string optionString = Console.ReadLine();

            bool isCorrect = false;

            // Comprueba si la opción introducida es correcta o no.
            while (!isCorrect)
            {
                if (optionString.Equals("1") || optionString.Equals("2") || optionString.Equals("3") || optionString.Equals("0")
                    || optionString.Equals("4") || optionString.Equals("5") || optionString.Equals("6"))
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("No ha elegido una opción correcta.");
                    Console.WriteLine("Pulsa para continuar...");
                    Console.ReadKey();
                }
            }

            return optionString;
        }

        private static void PrintAllAuthorInformation()
        {

            Console.Clear();

            List<Author> authorsList = Session.AuthorsSession;

            Console.WriteLine("\nAutores:");

            foreach (Author author in authorsList)
            {
                List<Book> booksWritten = author.BooksWritten;

                Console.WriteLine($"\nNombre del autor: {author.AuthorName}");
                Console.WriteLine("Libros escritos: ");

                foreach (Book book in booksWritten)
                {
                    Console.WriteLine($"\tTítulo del libro: {book.BookName}");
                }
            }

            Console.WriteLine("\nPulsa una tecla para volver al menú principal.");
            Console.ReadKey();
        }

        private static void PrintAllPublisherInformation()
        {

            Console.Clear();

            List<Publisher> publishersList = Session.PublisherSession;

            Console.WriteLine("Editoriales:");

            foreach (Publisher publisher in publishersList)
            {
                List<Book> booksPublished = publisher.PublishedBooks;

                Console.WriteLine($"\nNombre de la editorial: {publisher.PublisherName}");

                foreach (Book book in booksPublished)
                {
                    Console.WriteLine($"\tAutor del libro: {book.Author.AuthorName}");
                    Console.WriteLine($"\tTítulo del libro: {book.BookName}\n");
                }
            }

            Console.WriteLine("\nPulsa una tecla para volver al menú principal.");
            Console.ReadKey();
        }

        private static void PrintAllBooksInformation()
        {
            Console.Clear();

            List<Book> booksList = Session.BookSession;

            Console.WriteLine("Libros: ");

            foreach (Book book in booksList)
            {
                Console.WriteLine($"\tAutor del libro: {book.Author.AuthorName}");
                Console.WriteLine($"\tTítulo del libro: {book.BookName}\n");
                Console.WriteLine($"\tEditorial: {book.Publisher.PublisherName}");
            }

            Console.WriteLine("\nPulsa una tecla para volver al menú principal.");
            Console.ReadKey();
        }

        private static void PrintExitInformation()
        {
            Console.Clear();
            Console.WriteLine("¡Gracias por usar nuestro software! Hasta la próxima.");
            Environment.Exit(0);
        }

        // OPCIONES 4, 5 Y 6
        private static void AddNewPublisher()
        {
            Console.Clear();
            Console.WriteLine("Opción: Añadir una nueva editorial.");
            Console.Write("\nIndícame el nombre de la editorial: ");

            string nameOfNewPublisher = Console.ReadLine();

            bool isCorrect = false;

            while (!isCorrect)
            {
                if (!string.IsNullOrEmpty(nameOfNewPublisher))
                {
                    isCorrect = true;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El campo no puede estar vacío.");

                    Console.WriteLine("\nPulsa una tecla para continuar...");
                    Console.ReadKey();
                }
            }

            isCorrect = false;

            Publisher newPublisher = new(nameOfNewPublisher);

            List<Publisher> listOfPublishers = publisherManager.GetAllPublishers();
            
            while (!isCorrect)
            {
                if (!listOfPublishers.Contains(newPublisher))
                {
                    publisherManager.AddPublisher(newPublisher);

                    Console.Clear();
                    Console.WriteLine("Editorial añadida con éxito.");
                    Console.WriteLine($"Nombre de la editorial añadida: {newPublisher.PublisherName}");

                    isCorrect= true;
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Ya existe una editorial con ese nombre.");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey();
                    AddNewPublisher();
                }
            }
           
        }
    }
}