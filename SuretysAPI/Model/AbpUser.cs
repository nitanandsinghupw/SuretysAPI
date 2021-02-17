using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpUser
    {
        public AbpUser()
        {
            AbpPermissions = new HashSet<AbpPermission>();
            AbpRoleCreatorUsers = new HashSet<AbpRole>();
            AbpRoleDeleterUsers = new HashSet<AbpRole>();
            AbpRoleLastModifierUsers = new HashSet<AbpRole>();
            AbpSettings = new HashSet<AbpSetting>();
            AbpTenantCreatorUsers = new HashSet<AbpTenant>();
            AbpTenantDeleterUsers = new HashSet<AbpTenant>();
            AbpTenantLastModifierUsers = new HashSet<AbpTenant>();
            AbpUserClaims = new HashSet<AbpUserClaim>();
            AbpUserLogins = new HashSet<AbpUserLogin>();
            AbpUserOrganizationUnits = new HashSet<AbpUserOrganizationUnit>();
            AbpUserRoles = new HashSet<AbpUserRole>();
            AbpUserTokens = new HashSet<AbpUserToken>();
            CustomerValidations = new HashSet<CustomerValidation>();
            Customers = new HashSet<Customer>();
            InverseCreatorUser = new HashSet<AbpUser>();
            InverseDeleterUser = new HashSet<AbpUser>();
            InverseLastModifierUser = new HashSet<AbpUser>();
            PolicyApproverUsers = new HashSet<Policy>();
            PolicyUsers = new HashSet<Policy>();
            Vehicles = new HashSet<Vehicle>();
        }

        public long Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string AuthenticationSource { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string EmailAddress { get; set; }
        public string EmailConfirmationCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsLockoutEnabled { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public string Name { get; set; }
        public string NormalizedEmailAddress { get; set; }
        public string NormalizedUserName { get; set; }
        public string Password { get; set; }
        public string PasswordResetCode { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? ProfilePictureId { get; set; }
        public string SecurityStamp { get; set; }
        public bool ShouldChangePasswordOnNextLogin { get; set; }
        public string Surname { get; set; }
        public int? TenantId { get; set; }
        public string UserName { get; set; }
        public string SignInToken { get; set; }
        public DateTime? SignInTokenExpireTimeUtc { get; set; }
        public string GoogleAuthenticatorKey { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public bool? BenchmarkTest { get; set; }
        public string City { get; set; }
        public string ContactRole { get; set; }
        public string ContactStatus { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? DealerGroupId { get; set; }
        public Guid? DealerShipId { get; set; }
        public bool? Edelivery { get; set; }
        public string EdeliveryPreference { get; set; }
        public Guid? LenderId { get; set; }
        public Guid? UserTypeId { get; set; }
        public string Zip { get; set; }
        public bool? IsUnderwritingUser { get; set; }
        public Guid? StateId { get; set; }
        public DateTime? Dob { get; set; }
        public string MiddleName { get; set; }
        public bool? IsLivedinAddress6Months { get; set; }

        public virtual AbpUser CreatorUser { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DealerGroup DealerGroup { get; set; }
        public virtual DealerShip DealerShip { get; set; }
        public virtual AbpUser DeleterUser { get; set; }
        public virtual AbpUser LastModifierUser { get; set; }
        public virtual Lender Lender { get; set; }
        public virtual State State { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<AbpPermission> AbpPermissions { get; set; }
        public virtual ICollection<AbpRole> AbpRoleCreatorUsers { get; set; }
        public virtual ICollection<AbpRole> AbpRoleDeleterUsers { get; set; }
        public virtual ICollection<AbpRole> AbpRoleLastModifierUsers { get; set; }
        public virtual ICollection<AbpSetting> AbpSettings { get; set; }
        public virtual ICollection<AbpTenant> AbpTenantCreatorUsers { get; set; }
        public virtual ICollection<AbpTenant> AbpTenantDeleterUsers { get; set; }
        public virtual ICollection<AbpTenant> AbpTenantLastModifierUsers { get; set; }
        public virtual ICollection<AbpUserClaim> AbpUserClaims { get; set; }
        public virtual ICollection<AbpUserLogin> AbpUserLogins { get; set; }
        public virtual ICollection<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }
        public virtual ICollection<AbpUserRole> AbpUserRoles { get; set; }
        public virtual ICollection<AbpUserToken> AbpUserTokens { get; set; }
        public virtual ICollection<CustomerValidation> CustomerValidations { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<AbpUser> InverseCreatorUser { get; set; }
        public virtual ICollection<AbpUser> InverseDeleterUser { get; set; }
        public virtual ICollection<AbpUser> InverseLastModifierUser { get; set; }
        public virtual ICollection<Policy> PolicyApproverUsers { get; set; }
        public virtual ICollection<Policy> PolicyUsers { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
