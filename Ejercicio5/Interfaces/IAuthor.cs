using Ejercicio5.Models;

namespace Ejercicio5.Interfaces
{
    internal interface IAuthor
    {
        public Author AddAuthor(string name);
        public bool RemoveAuthorByName(string name);
        public Author ModifyAuthorName(string oldName, string newName);
        public Author GetAuthorById(int id);
        public Author GetAuthorByName(string name);
        public List<Author> GetAllAuthors();
    }
}
