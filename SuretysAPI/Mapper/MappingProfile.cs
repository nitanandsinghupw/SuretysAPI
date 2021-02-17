using AutoMapper;
using Suretys.Portal.AdditionalProductDetails.Dtos;
using Suretys.Portal.CretitDetails.Dtos;
using Suretys.Portal.CustomerDetails.Dtos;
using Suretys.Portal.PolicyDetails.Dtos;
using Suretys.Portal.VehicleDetails.Dtos;
using SuretysAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuretysAPI.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateOrEditPolicyDetailDto policyDetail = new CreateOrEditPolicyDetailDto(); ;
            // Add as many of these lines as you need to map your objects
            CreateMap <Vehicle, CreateOrEditVehicleDto>();
            CreateMap<CreateOrEditVehicleDto, Vehicle>();

            CreateMap<Credit, CreateOrEditCreditDto>();
            CreateMap<CreateOrEditCreditDto, Credit>();


            CreateMap<Customer, CreateOrEditCustomerDto>();
            CreateMap<CreateOrEditCustomerDto, Customer>();

            CreateMap<Policy, CreateOrEditPolicyDto>();
            CreateMap<CreateOrEditPolicyDto, Policy>();

            CreateMap<AdditionalProductsUsed, CreateOrEditAdditionalProductsUsedDto>();
            CreateMap<CreateOrEditAdditionalProductsUsedDto, AdditionalProductsUsed>();
        }
    }
}
