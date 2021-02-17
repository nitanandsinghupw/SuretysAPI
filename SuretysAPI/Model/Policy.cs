using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class Policy
    {
        public Policy()
        {
            PolicyDeclineReasons = new HashSet<PolicyDeclineReason>();
        }

        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool BenchmarkTest { get; set; }
        public string PolicyStatus { get; set; }
        public string SuretysStatus { get; set; }
        public string CustomerStatus { get; set; }
        public decimal TotalPremium { get; set; }
        public decimal MonthalyPremium { get; set; }
        public string PolicyForm { get; set; }
        public string DeclineForm { get; set; }
        public bool IsActive { get; set; }
        public long? UserId { get; set; }
        public Guid? CreditId { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? DealerGroupId { get; set; }
        public Guid? DealerShipId { get; set; }
        public Guid? LenderId { get; set; }
        public decimal DeclineQualifyMonthly { get; set; }
        public string Esignature { get; set; }
        public bool? ReadDocs { get; set; }
        public string PolicyNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string TestStatus { get; set; }
        public string DealNumber { get; set; }
        public string SleightFormUrl { get; set; }
        public string ControlNumber { get; set; }
        public bool? IsManualReview { get; set; }
        public string ManualReviewText { get; set; }
        public string ManualUwstatus { get; set; }
        public bool? IsEdit { get; set; }
        public long? ApproverUserId { get; set; }
        public DateTime ManualActionTime { get; set; }
        public DateTime ManualEndTime { get; set; }
        public DateTime ManualStartTime { get; set; }
        public string DataProvider { get; set; }
        public string PolicyStage { get; set; } = "Vehicle";
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string TerminateReason { get; set; }
        public int PolicyStep { get; set; } = 2;
        public Guid AccountScoreReferenceNumber { get; set; }= Guid.NewGuid();
        public Guid CustomerReferenceNumber { get; set; }
        public bool? IsItin { get; set; }
        public bool? FurtherReview { get; set; }
        public string FurtherReviewStatus { get; set; }
        public DateTime DateUnderwritingRun { get; set; }

        public virtual AbpUser ApproverUser { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DealerGroup DealerGroup { get; set; }
        public virtual DealerShip DealerShip { get; set; }
        public virtual Lender Lender { get; set; }
        public virtual AbpUser User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<PolicyDeclineReason> PolicyDeclineReasons { get; set; }
    }
}
