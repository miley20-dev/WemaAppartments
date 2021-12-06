using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class WemaUsers
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string  Password { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy  { get; set; }

    }
}
