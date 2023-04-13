using Ejercicio5.Models;
using Ejercicio5.Interfaces;
using Ejercicio5.DataBase;

namespace Ejercicio5.Controllers
{
    internal class AuthorController : IAuthor
    {
        /// <summary>
        /// Método encargado de añadir un autor en la BBDD.
        /// </summary>
        /// <param name="name">Nombre del nuevo autor que se va a guardar.</param>
        /// <returns>Devuelve el nuevo autor creado.</returns>
        public Author AddAuthor(string name)
        {
            Author newAuthor = new(name);
            Session.AuthorsSession.Add(newAuthor);

            return newAuthor;
        }

        /// <summary>
        /// Método encargado de devolver todos los autores que se encuentran en la BBDD.
        /// </summary>
        /// <returns></returns>
        public List<Author> GetAllAuthors()
        {
            return Session.AuthorsSession;
        }

        /// <summary>
        /// Método encargado de obtener un autor por su nombre.
        /// </summary>
        /// <param name="name">Nombre del autor que se desea buscar en la BBDD.</param>
        /// <returns>Autor encontrado a partir del nombre.</returns>
        public Author GetAuthorByName(string name)
        {
            List<Author> authors = Session.AuthorsSession;

            foreach (Author author in authors)
            {
                if (author.AuthorName.Equals(name))
                {
                    return author;
                }
            }
            return null;
        }

        /// <summary>
        /// Método encargo de obtener un autor a partir de su ID.
        /// </summary>
        /// <param name="id">Id del autor que se desea localizar.</param>
        /// <returns>Devuelve el autor obtenido a partir de su ID.</returns>
        public Author GetAuthorById(int id)
        {
            List<Author> authors = Session.AuthorsSession;

            foreach (Author author in authors)
            {
                if (author.AuthorId.Equals(id))
                {
                    return author;
                }
            }
            return null;
        }

        /// <summary>
        /// Método encargado de modifcar el nombre de un autor.
        /// </summary>
        /// <param name="oldName">Nombre que tiene el autor.</param>
        /// <param name="newName">Nuevo nombre que se quiere añadir.</param>
        /// <returns></returns>
        public Author ModifyAuthorName(string oldName, string newName)
        {
            Author author = GetAuthorByName(oldName);

            author.AuthorName = newName;

            return author;
        }

        /// <summary>
        /// Método encargado de eliminar un autor a partir de su nombre.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool RemoveAuthorByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
