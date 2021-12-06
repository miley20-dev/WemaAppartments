using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WemaAppartments.DTOs
{
    public class UsersViewModels
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
    }

    public class TenantViewModels
    {
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
        public string CreatedBy { get; set; }
    }
    
    public class PaymentViewModels
    {
        public int RentAmount { get; set; }
        public int RentInArrears { get; set; }
        public int TenantId { get; set; }
        public String Narration { get; set; }
        public String ModeOfPayment { get; set; }
        public string MpesaRef { get; set; }
        public String BankRef { get; set; }
        public DateTime PaymentDate { get; set; }
        public String CreatedBy { get; set; }
    }

    public class ApartmentViewodels
    {
        public String ApartmentName { get; set; }
        public String TenantId { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
        public int RentAMount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class ClaimViewModels
    {
        public string Narration { get; set; }
        public int Amount { get; set; }
        public string TenantId { get; set; }
        public string CreatedBy { get; set; }
        
  
    
   }
    public class RepairsViewModels
    {
  
        public String ApartmentId { get; set; }
        public String RepairsDone { get; set; }
        public int TotalCost { get; set; }
        public string TenantId { get; set; }
        public DateTime RepairsDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
    }
}


