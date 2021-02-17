using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class SurplusLinesTaxis
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Tax { get; set; }
        public decimal StampingFee { get; set; }
        public decimal StampingFeeAmount { get; set; }
        public string StateFeesTaxesDescription { get; set; }
        public Guid? StateId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public Guid? StampingFeesInstructionId { get; set; }
        public Guid? SurplusLinesTaxInstructionId { get; set; }
        public bool? IsArchive { get; set; }

        public virtual StampingFeesInstruction StampingFeesInstruction { get; set; }
        public virtual State State { get; set; }
        public virtual SurplusLinesTaxInstruction SurplusLinesTaxInstruction { get; set; }
    }
}
