using Ejercicio5.Models;

namespace Ejercicio5.Interfaces
{
    internal interface IPublisher
    {
        public Publisher AddPublisher(Publisher publisher);
        public bool RemovePublisherByName(string name);
        public Publisher ModifyPublisherName(string oldName, string newName);
        public Publisher GetPublisherById(int id);
        public Publisher GetPublisherByName(string name);
        public List<Publisher> GetAllPublishers();
    }
}
