using Ejercicio5.Models;
using Ejercicio5.Interfaces;
using Ejercicio5.DataBase;

namespace Ejercicio5.Controllers
{
    internal class AuthorController : IAuthor
    {
        public Author AddAuthor(string name)
        {
            Author newAuthor = new(name);
            Session.AuthorsSession.Add(newAuthor);

            return newAuthor;
        }

        public List<Author> GetAllAuthors()
        {
            return Session.AuthorsSession;
        }

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

        public Author ModifyAuthorName(string oldName, string newName)
        {
            Author author = GetAuthorByName(oldName);

            author.AuthorName = newName;

            return author;
        }


        public bool RemoveAuthorByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
