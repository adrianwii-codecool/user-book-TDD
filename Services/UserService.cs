using ContactCreator.DTO;
using ContactCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCreator.Services
{
    internal class UserService
    {
        public UserService() { }

        public Contact Create(ContactToCreateDTO contactToCreateDTO)
        {
            if (contactToCreateDTO is null)
            {
                throw new ArgumentNullException(nameof(contactToCreateDTO));
            }

            Contact contact = new Contact
            {
                Id = Guid.NewGuid(),
                FirstName = contactToCreateDTO.FirstName,
                LastName = contactToCreateDTO.LastName,
            };

            return contact;
        }
    }
}
