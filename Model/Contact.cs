using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCreator.Model
{
    internal class Contact
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
