
using System;


namespace Suretys.Portal.CretitDetails.Dtos
{
    public class CreditDto  
    {
		public bool BenchmarkTest { get; set; }

		public decimal MSRP { get; set; }

		public decimal NetCap { get; set; }

		public decimal LTV { get; set; }

		public decimal RebatableFees { get; set; }

		public string Term { get; set; }

		public decimal MonthalyPayment { get; set; }

		public decimal ResidualValue { get; set; }

		public decimal MoneyFactor { get; set; }

		public decimal Taxes { get; set; }

		public decimal InterestRate { get; set; }

		public decimal DownPayment { get; set; }

		public bool IsActive { get; set; }

		public bool AddlProductsUsed { get; set; }

		public decimal AddlProductsCosts { get; set; }

		public decimal AddlRebatableCosts { get; set; }


		 public Guid? CreditTypeId { get; set; }

		 		 public Guid? LenderId { get; set; }

		 		 public Guid? VehicleId { get; set; }

		 
    }
}