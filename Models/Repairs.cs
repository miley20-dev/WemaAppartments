using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class Repairs
    {
        public Guid Id { get; set; }
        public String  ApartmentId { get; set; }
        public String RepairsDone { get; set; }
        public int TotalCost { get; set; }
        public string TenantId { get; set; }
        public DateTime RepairsDate { get; set; }
        public DateTime  ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
    }
}
