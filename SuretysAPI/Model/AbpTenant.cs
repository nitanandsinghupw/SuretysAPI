using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpTenant
    {
        public int Id { get; set; }
        public string ConnectionString { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public Guid? CustomCssId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? EditionId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string LogoFileType { get; set; }
        public Guid? LogoId { get; set; }
        public string Name { get; set; }
        public string TenancyName { get; set; }
        public bool? IsInTrialPeriod { get; set; }
        public DateTime? SubscriptionEndDateUtc { get; set; }
        public int SubscriptionPaymentType { get; set; }

        public virtual AbpUser CreatorUser { get; set; }
        public virtual AbpUser DeleterUser { get; set; }
        public virtual AbpEdition Edition { get; set; }
        public virtual AbpUser LastModifierUser { get; set; }
    }
}
