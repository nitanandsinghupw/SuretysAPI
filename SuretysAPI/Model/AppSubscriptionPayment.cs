using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AppSubscriptionPayment
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int DayCount { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int EditionId { get; set; }
        public int Gateway { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string SuccessUrl { get; set; }
        public int? PaymentPeriodType { get; set; }
        public int Status { get; set; }
        public int TenantId { get; set; }
        public string InvoiceNo { get; set; }
        public string Description { get; set; }
        public string ErrorUrl { get; set; }
        public string ExternalPaymentId { get; set; }
        public bool? IsRecurring { get; set; }
        public int EditionPaymentType { get; set; }

        public virtual AbpEdition Edition { get; set; }
    }
}
