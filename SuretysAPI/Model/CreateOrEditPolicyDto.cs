
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Suretys.Portal.PolicyDetails.Dtos
{
    public class CreateOrEditPolicyDto  
    {
        public Guid? Id { get; set; }
        public bool BenchmarkTest { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Policy Status must be alphabets.")]
        public string PolicyStatus { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Suretys Status must be alphabets.")]
        public string SuretysStatus { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Customer Status must be alphabets.")]
        public string CustomerStatus { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Total Premium must be positive number.")]
        public decimal TotalPremium { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Monthaly Premium must be positive number.")]
        public decimal MonthalyPremium { get; set; }

        [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Policy Form can not start with special characters.")]
        public string PolicyForm { get; set; }

        [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Decline Form can not start with special characters.")]
        public string DeclineForm { get; set; }
        public bool IsActive { get; set; }
        public decimal DeclineQualifyMonthly { get; set; }
        public string ESignature { get; set; }
        public bool ReadDocs { get; set; }
        public long? UserId { get; set; }
        public Guid? CreditId { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? DealerShipId { get; set; }
        public Guid? DealerGroupId { get; set; }
        public Guid? LenderId { get; set; }
        public string PolicyNumber { get; set; }
        public string TestStatus { get; set; }
        public string PolicyPdfString { get; set; }
        public string CustomerSurplusLinetaxPdfString { get; set; }
        public string SLEightFormUrl { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9].*$", ErrorMessage = "Deal Number can not start with special characters.")]
        public string DealNumber { get; set; }
       // [RegularExpression(@"^[a-zA-Z09].*$", ErrorMessage = "Control Number can not start with special characters.")]
        public string ControlNumber { get; set; }
        public bool IsManualReview { get; set; }
        [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Manual Review Text can not start with special characters.")]
        public string ManualReviewText { get; set; }
        [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Terminate Reason Text can not start with special characters.")]
        public string TerminateReason { get; set; }

        public string PolicyStage { get; set; }
        public string DataProvider { get; set; }
        public int policyStep { get; set; }
        public Guid AccountScoreReferenceNumber { get; set; }
        public bool IsITIN { get; set; }
        public bool FurtherReview { get; set; }
        public string FurtherReviewStatus { get; set; }
        public string ManualUWStatus { get; set; }

        public DateTime ManualStartTime { get; set; }
        public DateTime ManualEndTime { get; set; }
    }
}