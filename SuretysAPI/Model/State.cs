using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class State
    {
        public State()
        {
            AbpUsers = new HashSet<AbpUser>();
            CustomerDriverStates = new HashSet<Customer>();
            CustomerStates = new HashSet<Customer>();
            SurplusLinesTaxes = new HashSet<SurplusLinesTaxis>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }

        public virtual ICollection<AbpUser> AbpUsers { get; set; }
        public virtual ICollection<Customer> CustomerDriverStates { get; set; }
        public virtual ICollection<Customer> CustomerStates { get; set; }
        public virtual ICollection<SurplusLinesTaxis> SurplusLinesTaxes { get; set; }
    }
}
