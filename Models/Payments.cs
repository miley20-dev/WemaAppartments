using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.Models
{
    public class Payments
    {
        public Guid Id { get; set; }
        public int RentAmount { get; set; }
        public int RentInArrears { get; set; }
        public int TenantId { get; set; }
        public String Narration  { get; set; }
        public String ModeOfPayment { get; set; }
        public string MpesaRef { get; set; }
        public String BankRef { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public String CreatedBy { get; set; }
    }
}
