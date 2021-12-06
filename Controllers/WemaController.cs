using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WemaAppartments.DTOs;
using WemaAppartments.Models;

namespace WemaAppartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WemaController : ControllerBase


    {
        private readonly WemaApartmentsContext _wemaApartmentsContext;

        public WemaController(WemaApartmentsContext wemaApartmentsContext)
        {
            _wemaApartmentsContext = wemaApartmentsContext;
        }
        [HttpPost("registerusers")]
        public ActionResult GetAuthentification(UsersViewModels vm)
        {
            //mapping
            var user = new WemaUsers
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Password = vm.Password,
                EmailAddress = vm.EmailAddress,
                CreatedBy = vm.CreatedBy
            };



            //insert to db
            _wemaApartmentsContext.Users.Add(user);
            //persist data
            _wemaApartmentsContext.SaveChanges();
            return Ok($"Added {user.FirstName}");
        }
        [HttpPost("Tenants")]
        public ActionResult CreateTenants(TenantViewModels vm)

        {
            var Tenants = new Tenants();
            Tenants.TenantFirstName = vm.TenantFirstName;
            Tenants.TenantMiddleName = vm.TenantMiddleName;
            Tenants.TenantLastName = vm.TenantLastName;
            Tenants.TenantsEmailAddress = vm.TenantsEmailAddress;
            Tenants.TenantsIDNumber = vm.TenantsIDNumber;
            Tenants.TenantsMoveInDate = vm.TenantsMoveInDate;
            Tenants.TenantsPhoneNumber = vm.TenantsPhoneNumber;
            Tenants.NextOfKinFirstName = vm.NextOfKinFirstName;
            Tenants.NextOfKinLastName = vm.NextOfKinLastName;
            Tenants.NextOfKinPhoneNumber = vm.NextOfKinPhoneNumber;
            Tenants.NextOfKinEmailAddress = vm.NextOfKinEmailAddress;
            Tenants.CreatedBy = vm.CreatedBy;

            //insert to db
            _wemaApartmentsContext.Tenants.Add(Tenants);
            //persist data
            _wemaApartmentsContext.SaveChanges();
            return Ok("Added");
        }

        [HttpPost("Payments")]
        public ActionResult CreatePayments(PaymentViewModels vm)
        {
            var payments = new Payments();
            payments.TenantId = vm.TenantId;
            payments.Narration = vm.Narration;
            payments.PaymentDate = vm.PaymentDate;
            payments.RentAmount = vm.RentAmount;
            payments.RentInArrears = vm.RentInArrears;
            payments.ModeOfPayment = vm.ModeOfPayment;
            payments.MpesaRef = vm.MpesaRef;
            payments.BankRef = vm.BankRef;
            payments.CreatedBy = vm.CreatedBy;

            //insert to db
            _wemaApartmentsContext.Payments.Add(payments);
            //persist data
            _wemaApartmentsContext.SaveChanges();
            return Ok("Added");
        }
        [HttpPost("Apartments")]
        public ActionResult CreateApartments(ApartmentViewodels vm)
        {
            var Apartment = new Apartment();
            Apartment.ApartmentName = vm.ApartmentName;
            Apartment.TenantId = vm.TenantId;
            Apartment.RentAMount = vm.RentAMount;
            Apartment.Location = vm.Location;
            Apartment.CreatedBy = vm.CreatedBy;
            Apartment.ModifiedBy = vm.ModifiedBy;

            //insert to db
            _wemaApartmentsContext.Apartments.Add(Apartment);
            //persist data
            _wemaApartmentsContext.SaveChanges();
            return Ok("Added");
        }
        [HttpPost("TenantsClaims")]
        public ActionResult CreateTenantsClaims(ClaimViewModels vm)
        {
            var Claims = new Claims();
            Claims.Narration = vm.Narration;
            Claims.TenantId = vm.TenantId;
            Claims.Amount = vm.Amount;
            Claims.CreatedBy = vm.CreatedBy;

            _wemaApartmentsContext.Claims.Add(Claims);

            _wemaApartmentsContext.SaveChanges();

            return Ok("TenantClaimAdded");
        }
        [HttpPost ("Repairs")]
        public ActionResult CreateTenantsRepairs(RepairsViewModels vw)
        {
            var repairs = new Repairs();
            repairs.ApartmentId = vw.ApartmentId;
            repairs.TenantId = vw.TenantId;
            repairs.RepairsDone = vw.RepairsDone;
            repairs.RepairsDate = vw.RepairsDate;
            repairs.TotalCost = vw.TotalCost;
            repairs.CreatedBy = vw.CreatedBy;

            _wemaApartmentsContext.Repairs.Add(repairs);
            _wemaApartmentsContext.SaveChanges();

                return Ok("ApartmentsRepairsAdded");
        }
    }
}
