using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class Claims
    {
        public Guid Id { get; set; }
        public string Narration { get; set; }
        public int Amount { get; set; }
        public string TenantId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
