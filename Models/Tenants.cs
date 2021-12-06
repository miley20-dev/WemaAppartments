using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class Tenants
    {
        public Guid Id { get; set; }
        public String TenantFirstName { get; set; }
        public String TenantMiddleName { get; set; }
        public string TenantLastName { get; set; }
        public String TenantsEmailAddress { get; set; }
        public string TenantsPhoneNumber { get; set; }
        public int TenantsIDNumber { get; set; }
        public DateTime TenantsMoveInDate { get; set; }
        public string NextOfKinFirstName { get; set; }
        public string NextOfKinLastName { get; set; }
        public string NextOfKinPhoneNumber { get; set; }
        public string NextOfKinEmailAddress { get; set; }
        public int NextOfKinsIDNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }

    }
}
