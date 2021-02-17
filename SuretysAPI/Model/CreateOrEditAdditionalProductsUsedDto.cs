
using System;
 
using System.ComponentModel.DataAnnotations;

namespace Suretys.Portal.AdditionalProductDetails.Dtos
{
    public class CreateOrEditAdditionalProductsUsedDto  
    {
        [Range(0.00000, double.MaxValue, ErrorMessage = "Additional Product Cost must be positive number.")]
        public decimal AdditionalProductCost { get; set; }

        public Guid? Id { get; set; }
        public bool IsActive { get; set; }


        public Guid? AdditionalProductsMasterId { get; set; }

        public Guid? CreditId { get; set; }


    }
}