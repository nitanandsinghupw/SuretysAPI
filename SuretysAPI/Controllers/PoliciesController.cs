using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suretys.Portal.PolicyDetails.Dtos;
using SuretysAPI.Model;
using SuretysAPI.Repository;

namespace SuretysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliciesController : ControllerBase
    {
        private readonly IMapper _mapper;
        IDealerRepository dealerRepository;
        public PoliciesController(IDealerRepository _dealerRepository, IMapper mapper)
        {
            dealerRepository = _dealerRepository;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<SavePolicyDetailOutput> Save([FromBody] CreateOrEditPolicyDetailDto policyDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    #region Vehicle

                    if (!policyDetail.Vehicle.Id.HasValue || policyDetail.Vehicle.Id.Value == Guid.Empty)
                    {
                        var vehicle = _mapper.Map<Vehicle>(policyDetail.Vehicle);
                        vehicle.CreatorUserId = policyDetail.Vehicle.UserId;
                        vehicle.Id = System.Guid.NewGuid();
                        vehicle.CreationTime = System.DateTime.UtcNow;

                        policyDetail.Vehicle.Id = await dealerRepository.AddVehicle(vehicle);
                    }
                    else
                    {
                        var vehicle = dealerRepository.GetVehicle((Guid)policyDetail.Vehicle.Id);
                        _mapper.Map(policyDetail.Vehicle, vehicle);
                    }
                    Guid? vehicleId = policyDetail.Vehicle.Id;
                    #endregion

                    #region Credit
                    policyDetail.Credit.VehicleId = vehicleId;
                    Guid? creditId = policyDetail.Credit.Id;


                    if (!policyDetail.Credit.Id.HasValue || policyDetail.Credit.Id.Value == Guid.Empty)
                    {
                        var credit = _mapper.Map<Credit>(policyDetail.Credit);
                        credit.CreatorUserId = policyDetail.Vehicle.UserId;
                        credit.Id = System.Guid.NewGuid();
                        credit.CreationTime = System.DateTime.UtcNow;
                        creditId = await dealerRepository.AddCredit(credit);
                    }
                    else
                    {
                        var credit = dealerRepository.GetCredit((Guid)policyDetail.Credit.Id);
                        _mapper.Map(policyDetail.Credit, credit);
                    }

                    #endregion

                    #region Customer
                    policyDetail.Customer.VehicleId = vehicleId;
                    policyDetail.Customer.CreditId = creditId;
                    Guid? customerId;

                    Customer customer = dealerRepository.GetCustomer(policyDetail.Customer.Email);
                    if (customer != null)
                    {

                        policyDetail.Customer.Id = customer.Id;
                        policyDetail.Customer.Address1 = customer.Address1;
                        policyDetail.Customer.Address2 = customer.Address2;
                        policyDetail.Customer.FinicityiCustomerId = customer.FinicityiCustomerId;
                        policyDetail.Customer.ReferenceId = customer.ReferenceId;
                        policyDetail.Customer.StateId = customer.StateId;
                        policyDetail.Customer.AccountScoreId = customer.AccountScoreId;
                        policyDetail.Customer.AccountScoreCallDate = customer.AccountScoreCallDate;
                        policyDetail.Customer.CustomerHasBankDetails = customer.CustomerHasBankDetails.GetValueOrDefault();
                        policyDetail.Customer.LastProvider = customer.LastProvider;
                        _mapper.Map(policyDetail.Customer, customer);
                        customerId = customer.Id;
                    }

                    else
                    {
                        if (!policyDetail.Customer.Id.HasValue || policyDetail.Customer.Id.Value == Guid.Empty)
                        {
                            policyDetail.Customer.Id = Guid.NewGuid();
                        }
                        policyDetail.Customer.ReferenceId = Guid.NewGuid();
                        var customerInfo = _mapper.Map<Customer>(policyDetail.Customer);
                        customerInfo.CreatorUserId = policyDetail.Vehicle.UserId;                   
                        customerInfo.CreationTime = System.DateTime.UtcNow;
                        customerId = await dealerRepository.AddCustomer(customerInfo);
                    }
                    policyDetail.Customer.Id = customerId.GetValueOrDefault();

                    #endregion

                    #region Vehicle Edit


                    var vehicleData = dealerRepository.GetVehicle(vehicleId.Value);
                    policyDetail.Vehicle.CustomerId = customerId;
                    vehicleData.CustomerId = customerId;
                    vehicleData.LastModifierUserId = policyDetail.Vehicle.UserId;
                    vehicleData.LastModificationTime = System.DateTime.UtcNow;
                    await dealerRepository.updateVehicle(vehicleData);

                    #endregion 

                    #region Policy

                    var policyDetailsData = _mapper.Map<Policy>(policyDetail.Policy);
                    policyDetailsData.CreditId = creditId;
                    policyDetailsData.VehicleId = vehicleId;
                    policyDetailsData.CustomerId = customerId;
                    if (!policyDetail.Policy.Id.HasValue || policyDetail.Policy.Id.Value == Guid.Empty)
                    {
                        policyDetailsData.CreatorUserId = policyDetail.Vehicle.UserId;
                        policyDetailsData.Id = System.Guid.NewGuid();
                        policyDetailsData.CreationTime = System.DateTime.UtcNow;
                        policyDetailsData.AccountScoreReferenceNumber = Guid.NewGuid();
                        policyDetailsData.PolicyStage = "Vehicle";
                        policyDetailsData.PolicyStep = 2;
                        policyDetailsData.DealerShipId = policyDetail.Vehicle.DealerShipId;
                        policyDetail.Policy.Id = await dealerRepository.Addpolicy(policyDetailsData);
                    }
                    else
                    {
                        policyDetailsData.LastModificationTime = System.DateTime.UtcNow;
                        policyDetailsData.AccountScoreReferenceNumber = Guid.NewGuid();
                        policyDetailsData.PolicyStage = "Vehicle";
                        policyDetailsData.PolicyStep = 2;
                        policyDetailsData.LastModifierUserId = policyDetail.Vehicle.UserId;
                        policyDetailsData.IsEdit = true;
                        await dealerRepository.updarepolicy(policyDetailsData);
                    }
                    #endregion

                    #region AdditionalProducts

                    if (policyDetail.AdditionalProducts?.Any() == true)
                    {
                        policyDetail.AdditionalProducts.ForEach(a => a.CreditId = creditId);
                        var additionalProductsUsed = dealerRepository.getAdditionalProductsUseds(creditId.GetValueOrDefault());
                        foreach (var item in additionalProductsUsed)
                        {
                            dealerRepository.DeleteadditionalProductsUsed(item.Id);
                           
                        }

                        foreach (var item in policyDetail.AdditionalProducts)
                        {
                            if (item.Id == null)
                            {
                                var additionalProductUsed = _mapper.Map<AdditionalProductsUsed>(item);
                                if (!item.Id.HasValue || item.Id.Value == Guid.Empty)
                                {
                                    
                                    additionalProductUsed.Id = System.Guid.NewGuid();
                                   
                                }
                                additionalProductUsed.CreatorUserId = policyDetail.Vehicle.UserId;
                                 additionalProductUsed.CreationTime = System.DateTime.UtcNow;
                                await dealerRepository.InsertAdditionalProductsUsed(additionalProductUsed);
                            }
                        }

                        policyDetail.Customer.Status = policyDetail.Policy.PolicyStatus;
                    }

                    else if (policyDetail.IsProductUsed)
                    {
                        var additionalProductsUsed = dealerRepository.getAdditionalProductsUseds(creditId.GetValueOrDefault());

                        foreach (var item in additionalProductsUsed)
                        {
                            dealerRepository.DeleteadditionalProductsUsed(item.Id);
                        }

                        #endregion

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return new SavePolicyDetailOutput()
            {
                CustomerId = policyDetail.Customer.Id.GetValueOrDefault(),
                PolicyId = policyDetail.Policy.Id.GetValueOrDefault()
            };
        }
    }
}
