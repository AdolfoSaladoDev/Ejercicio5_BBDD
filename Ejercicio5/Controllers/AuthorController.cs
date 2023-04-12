using Ejercicio5.Models;
using Ejercicio5.Interfaces;

namespace Ejercicio5.Controllers
{
    internal class AuthorController : IAuthor
    {
        public Author AddAuthor(string name)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorByName(string name)
        {
            throw new NotImplementedException();
        }

        public Author GetPublisherById(int id)
        {
            throw new NotImplementedException();
        }

        public Author ModifyAuthorName(string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAuthorByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
