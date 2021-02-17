using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class CustomerValidation
    {
        public Guid Id { get; set; }
        public string Ssn { get; set; }
        public DateTime DateSsnvalidated { get; set; }
        public string CustomerNameValidated { get; set; }
        public bool IsNameMatchSsn { get; set; }
        public DateTime DateNameMatchSsn { get; set; }
        public string CustomerAdressValidated { get; set; }
        public bool IsAddressMatchSsn { get; set; }
        public DateTime DateAddressMatchSsn { get; set; }
        public Guid? CustomerId { get; set; }
        public long? UserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool? IsSsnvalidated { get; set; }
        public int CreditScore { get; set; }
        public DateTime DateCrsrun { get; set; }
        public bool? IsCrscalled { get; set; }
        public bool? IsItin { get; set; }
        public bool? IsOverride { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual AbpUser User { get; set; }
    }
}
