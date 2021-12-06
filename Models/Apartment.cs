using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class Apartment
    {
        public Guid  Id { get; set; }
        public String ApartmentName { get; set; }
        public String TenantId { get; set; }
        public string  Unit { get; set; }
        public string Location { get; set; }
        public string  Size { get; set; }
        public int  RentAMount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string  CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string  ModifiedBy { get; set; }
    }
}
