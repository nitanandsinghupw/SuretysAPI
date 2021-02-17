using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class Customer
    {
        public Customer()
        {
            AbpUsers = new HashSet<AbpUser>();
            CustomerValidations = new HashSet<CustomerValidation>();
            Policies = new HashSet<Policy>();
            Vehicles = new HashSet<Vehicle>();
        }

        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactMethod { get; set; }
        public bool IsActive { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? CreditId { get; set; }
        public long? UserId { get; set; }
        public bool? BenchmarkTest { get; set; }
        public string TestStatus { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Guid? StateId { get; set; }
        public string Zip { get; set; }
        public string DriverLicenseNumber { get; set; }
        public Guid? DriverStateId { get; set; }
        public string MiddleName { get; set; }
        public DateTime? AccountScoreCallDate { get; set; }
        public Guid? AccountScoreId { get; set; }
        public Guid? ReferenceId { get; set; }
        public string FinicityiCustomerId { get; set; }
        public bool? CustomerHasBankDetails { get; set; }
        public string LastProvider { get; set; }

        public virtual State DriverState { get; set; }
        public virtual State State { get; set; }
        public virtual AbpUser User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<AbpUser> AbpUsers { get; set; }
        public virtual ICollection<CustomerValidation> CustomerValidations { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
