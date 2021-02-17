using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpEdition
    {
        public AbpEdition()
        {
            AbpFeatures = new HashSet<AbpFeature>();
            AbpTenants = new HashSet<AbpTenant>();
            AppSubscriptionPayments = new HashSet<AppSubscriptionPayment>();
        }

        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string DisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string Name { get; set; }
        public string Discriminator { get; set; }
        public decimal? AnnualPrice { get; set; }
        public int? ExpiringEditionId { get; set; }
        public decimal? MonthlyPrice { get; set; }
        public int? TrialDayCount { get; set; }
        public int? WaitingDayAfterExpire { get; set; }
        public decimal? DailyPrice { get; set; }
        public decimal? WeeklyPrice { get; set; }

        public virtual ICollection<AbpFeature> AbpFeatures { get; set; }
        public virtual ICollection<AbpTenant> AbpTenants { get; set; }
        public virtual ICollection<AppSubscriptionPayment> AppSubscriptionPayments { get; set; }
    }
}
