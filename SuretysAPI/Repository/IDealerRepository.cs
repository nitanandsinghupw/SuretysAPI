using SuretysAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuretysAPI.Repository
{
    public interface IDealerRepository
    {
        Vehicle GetVehicle(Guid vehicleId);
        Task<Guid> AddVehicle(Vehicle vehicle);
        Task<Guid> updateVehicle(Vehicle vehicle);


        Credit GetCredit(Guid creditId);
        Task<Guid> AddCredit(Credit credit);


        Customer GetCustomer(string Email);
        Task<Guid> AddCustomer(Customer customer);



        Task<Guid> Addpolicy(Policy policy);
        Task<Guid> updarepolicy(Policy policy);

        List<AdditionalProductsUsed> getAdditionalProductsUseds(Guid creditId);
        void DeleteadditionalProductsUsed(Guid id);
        Task<Guid> InsertAdditionalProductsUsed(AdditionalProductsUsed additionalProductsUsed);
    }
}
