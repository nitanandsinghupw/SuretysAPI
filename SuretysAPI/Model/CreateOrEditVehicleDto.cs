
using System;
 
using System.ComponentModel.DataAnnotations;

namespace Suretys.Portal.VehicleDetails.Dtos
{
    public class CreateOrEditVehicleDto  
    {
		public Guid? Id { get; set; }
		[Required]
		[StringLength(17, ErrorMessage = "VIN must be 17 digits")]
		public string VIN { get; set; }
		
		
		[Required]
		[RegularExpression(@"^[a-zA-Z0-9].*$", ErrorMessage = "Model can not start with special characters.")]
		public string Model { get; set; }
		
		
		[Required]
		[RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Make can not start with special characters.")]
		public string Make { get; set; }
		
		
		[Required]
		[RegularExpression(@"^[a-zA-Z0-9].*$", ErrorMessage = "Year can not start with special characters.")]
		public string Year { get; set; }

		[RegularExpression(@"^[a-zA-Z-0-9].*$", ErrorMessage = "Miles can not start with special characters.")]
		public string Miles { get; set; }

		[RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Status can not start with special characters.")]
		public string Status { get; set; }
		
		
		public bool IsActive { get; set; }
		
		
		public bool BenchmarkTest { get; set; }
		
		
		 public Guid? DealerShipId { get; set; }
		 
		 		 public long? UserId { get; set; }
		 
		 		 public Guid? CustomerId { get; set; }
		 
		 
    }
}