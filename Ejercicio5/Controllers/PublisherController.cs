using Ejercicio5.Interfaces;
using Ejercicio5.Models;
using Ejercicio5.DataBase;

namespace Ejercicio5.Controllers
{
    internal class PublisherController : IPublisher
    {

        public Publisher AddPublisher(string name)
        {
            Publisher newPublisher = new(name);
            Session.PublisherSession.Add(newPublisher);

            return newPublisher;
        }

        public List<Publisher> GetAllPublishers()
        {
            return Session.PublisherSession;
        }

        public Publisher GetPublisherById(int id)
        {
            List<Publisher> publishers = Session.PublisherSession;

            foreach (Publisher publisher in publishers)
            {
                if (publisher.PublisherId.Equals(id))
                {
                    return publisher;
                }
            }

            return null;
        }

        public Publisher GetPublisherByName(string name)
        {
            List<Publisher> publishers = Session.PublisherSession;

            foreach (Publisher publisher in publishers)
            {
                if (publisher.PublisherName.Equals(name))
                {
                    return publisher;
                }
            }

            return null;
        }

        public Publisher ModifyPublisherName(string oldName, string newName)
        {
            Publisher publisher = GetPublisherByName(oldName);

            publisher.PublisherName = newName;

            return publisher;
        }

        public bool RemovePublisherByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
