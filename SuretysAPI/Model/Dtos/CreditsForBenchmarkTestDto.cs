using System;
using System.Collections.Generic;
using System.Text;

namespace Suretys.Portal.CretitDetails.Dtos
{
    public class CreditsForBenchmarkTestDto
    {
        public Guid Id { get; set; }
        public string CreditType { get; set; }
        public string Term { get; set; }
        public decimal NetCap { get; set; }
        public decimal LTV { get; set; }
        public decimal DownPayment { get; set; }
        public decimal MSRP { get; set; }
        public decimal Taxes { get; set; }
        public decimal ResidualValue { get; set; }
        public decimal MoneyFactor { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthalyPayment { get; set; }

        public decimal AmountLease { get; set; }
        public decimal InterestFees { get; set; }
        public decimal TotalLeaseAmount { get; set; }
        public decimal TotalFinanced { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal RetailValue { get; set; }
        public decimal ResidualPercent { get; set; }
        public decimal AddlProductsCosts { get; set; }
        public decimal AddlRebatableCosts { get; set; }
    }
}
