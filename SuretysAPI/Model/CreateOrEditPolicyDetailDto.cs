using Suretys.Portal.AdditionalProductDetails.Dtos;
using Suretys.Portal.CretitDetails.Dtos;
using Suretys.Portal.CustomerDetails.Dtos;
using Suretys.Portal.VehicleDetails.Dtos;
using System.Collections.Generic;

namespace Suretys.Portal.PolicyDetails.Dtos {
    public class CreateOrEditPolicyDetailDto {
        public CreateOrEditVehicleDto Vehicle { get; set; }
        public CreateOrEditCreditDto Credit { get; set; }
        public CreateOrEditCustomerDto Customer { get; set; }
        public CreateOrEditPolicyDto Policy { get; set; }
        public List<CreateOrEditAdditionalProductsUsedDto> AdditionalProducts { get; set; }
        public bool IsProductUsed { get; set; }
    }
}
