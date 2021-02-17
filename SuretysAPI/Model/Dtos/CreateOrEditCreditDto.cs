
using System;
 
using System.ComponentModel.DataAnnotations;

namespace Suretys.Portal.CretitDetails.Dtos
{
    public class CreateOrEditCreditDto 
    {
        public Guid? Id { get; set; }
        public bool BenchmarkTest { get; set; }
        [Required]
        [Range(0.00000, double.MaxValue, ErrorMessage = "Sales Price must be positive number.")]
        public decimal MSRP { get; set; }
        
        [Range(0.00000, double.MaxValue, ErrorMessage = "Net Cap must be positive number.")]
        public decimal NetCap { get; set; }
        
        [Range(0.00000, 100, ErrorMessage = "LTV must be between 0.00 to 100.")]
        public decimal LTV { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Rebatable Fees must be positive number.")]
        public decimal RebatableFees { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Use letters and digits only please.")]
        public string Term { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Monthaly Payment must be positive number.")]
        public decimal MonthalyPayment { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Residual Value must be positive number.")]
        public decimal ResidualValue { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Money Factor must be positive number.")]
        public decimal MoneyFactor { get; set; }
        [Required]
        [Range(0.00000, double.MaxValue, ErrorMessage = "Taxes must be positive number.")]
        public decimal Taxes { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Interest Rate be positive number.")]
        public decimal InterestRate { get; set; }
        [Required]
        [Range(0.00000, double.MaxValue, ErrorMessage = "Down Payment be positive number.")]
        public decimal DownPayment { get; set; }
        public bool IsActive { get; set; }
        public bool AddlProductsUsed { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Additional Product Costs must be positive number.")]
        public decimal AddlProductsCosts { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Additional Rebatable Costs must be positive number.")]
        public decimal AddlRebatableCosts { get; set; }
        public Guid? CreditTypeId { get; set; }
        public Guid? LenderId { get; set; }
        public Guid? VehicleId { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Residual Percent must be positive number.")]
        public decimal ResidualPercent { get; set; }

        public decimal RetailValue { get; set; }

        [Range(0.00000, double.MaxValue, ErrorMessage = "Loan Amount must be positive number.")]

        public virtual decimal AmountLeased { get; set; }
        [Range(0.00000, double.MaxValue, ErrorMessage = "Interest Fee must be positive number.")]

        public virtual decimal InterestFee { get; set; }
        [Range(0.00000, double.MaxValue, ErrorMessage = "Total Payment must be positive number.")]

        public virtual decimal TotalLeaseAmount { get; set; }
        [Range(0.00000, double.MaxValue, ErrorMessage = "Total Financed must be positive number.")]

        public virtual decimal TotalFinanced { get; set; }
        [Range(0.00000, double.MaxValue, ErrorMessage = "Monthly Interest must be positive number.")]

        public virtual decimal MonthlyInterest { get; set; }



    }
}