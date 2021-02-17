
using System;
 
using System.ComponentModel.DataAnnotations;

namespace Suretys.Portal.CustomerDetails.Dtos
{
    public class CreateOrEditCustomerDto
    {
        public Guid? Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First Name must be alphabets.")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First Name must be alphabets.")]
        public string MiddleName { get; set; }


        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last Name must be alphabets.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "PhoneNumber code must be 10 digits")]
        public string PhoneNumber { get; set; }

        // [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Contact Method must be alphabets.")]
        public string ContactMethod { get; set; }
        public bool IsActive { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? CreditId { get; set; }
        public long? UserId { get; set; }
        [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Status can not start with special characters.")]
        public string Status { get; set; }
        public bool BenchmarkTest { get; set; }
        public string TestStatus { get; set; }
        [RegularExpression(@"^[a-zA-Z-9].*$", ErrorMessage = "Address1 can not start with special characters.")]
        public string Address1 { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9].*$", ErrorMessage = "Address2 can not start with special characters.")]
        public string Address2 { get; set; }
        [StringLength(5, ErrorMessage = "Zip code must be 5 digits")]
        public string Zip { get; set; }
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "City must be alphabets.")]
        public string City { get; set; }
        public virtual Guid? StateId { get; set; }
        public virtual Guid? DriverStateId { get; set; }
        public string DriverLicenseNumber { get; set; }
        public Guid? ReferenceId { get; set; }
        public DateTime? AccountScoreCallDate { get; set; }
        public Guid? AccountScoreId { get; set; }
        public string FinicityiCustomerId { get; set; }
        public bool CustomerHasBankDetails { get; set; }
        public string LastProvider { get; set; }
    }
}