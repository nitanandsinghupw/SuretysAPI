using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AdditionalProductsMaster
    {
        public AdditionalProductsMaster()
        {
            AdditionalProductsToDealers = new HashSet<AdditionalProductsToDealer>();
            AdditionalProductsUseds = new HashSet<AdditionalProductsUsed>();
        }

        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string ProductName { get; set; }
        public bool Rebatable { get; set; }
        public decimal CostRate { get; set; }
        public string ProductDescription { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<AdditionalProductsToDealer> AdditionalProductsToDealers { get; set; }
        public virtual ICollection<AdditionalProductsUsed> AdditionalProductsUseds { get; set; }
    }
}
