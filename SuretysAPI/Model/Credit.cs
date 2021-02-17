using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class Credit
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool BenchmarkTest { get; set; }
        public decimal Msrp { get; set; }
        public decimal NetCap { get; set; }
        public decimal Ltv { get; set; }
        public decimal RebatableFees { get; set; }
        public string Term { get; set; }
        public decimal MonthalyPayment { get; set; }
        public decimal ResidualValue { get; set; }
        public decimal MoneyFactor { get; set; }
        public decimal Taxes { get; set; }
        public decimal InterestRate { get; set; }
        public decimal DownPayment { get; set; }
        public bool IsActive { get; set; }
        public Guid? CreditTypeId { get; set; }
        public Guid? LenderId { get; set; }
        public Guid? VehicleId { get; set; }
        public decimal AddlProductsCosts { get; set; }
        public bool? AddlProductsUsed { get; set; }
        public decimal AddlRebatableCosts { get; set; }
        public decimal ResidualPercent { get; set; }
        public decimal RetailValue { get; set; }
        public decimal InterestFee { get; set; }
        public decimal AmountLeased { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal TotalFinanced { get; set; }
        public decimal TotalLeaseAmount { get; set; }

        public virtual CreditType CreditType { get; set; }
        public virtual Lender Lender { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
