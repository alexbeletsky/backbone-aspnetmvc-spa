using System.Collections.Generic;
using System.Web.Http;
using Spa.Models;
using Spa.Models.Repositories;

namespace Spa.Api
{
    public class ContactsController : ApiController
    {
        private readonly ContactsRepository _contactsRepository;

        public ContactsController()
        {
            _contactsRepository = new ContactsRepository();
        }
        public IEnumerable<Contact> GetContacts()
        {
            return _contactsRepository.All;
        }
    }
}
