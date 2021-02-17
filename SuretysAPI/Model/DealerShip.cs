using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class DealerShip
    {
        public DealerShip()
        {
            AbpUsers = new HashSet<AbpUser>();
            AdditionalProductsToDealers = new HashSet<AdditionalProductsToDealer>();
            DealerToLenders = new HashSet<DealerToLender>();
            Notes = new HashSet<Note>();
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
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public Guid? DealerGroupId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual DealerGroup DealerGroup { get; set; }
        public virtual ICollection<AbpUser> AbpUsers { get; set; }
        public virtual ICollection<AdditionalProductsToDealer> AdditionalProductsToDealers { get; set; }
        public virtual ICollection<DealerToLender> DealerToLenders { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
