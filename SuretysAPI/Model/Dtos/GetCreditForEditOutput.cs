using System;
 
using System.ComponentModel.DataAnnotations;

namespace Suretys.Portal.CretitDetails.Dtos
{
    public class GetCreditForEditOutput
    {
		public CreateOrEditCreditDto Credit { get; set; }

		public string CreditTypeType { get; set;}

		public string LenderName { get; set;}

		public string VehicleVIN { get; set;}


    }
}