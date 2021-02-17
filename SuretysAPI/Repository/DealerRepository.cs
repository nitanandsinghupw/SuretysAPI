using SuretysAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuretysAPI.Repository
{
    public class DealerRepository : IDealerRepository

    {

        SuretysPortalDBV1Context db;
        public DealerRepository(SuretysPortalDBV1Context _db)
        {
            db = _db;
        }

        //Vehicle
        public Vehicle GetVehicle(Guid vehicleId)
        {
            if (db != null)
            {
                return db.Vehicles.Where(x => x.Id == vehicleId).FirstOrDefault();
            }

            return null;
        }
        public async Task<Guid> AddVehicle(Vehicle vehicle)
        {
            try
            {
                if (db != null)
                {
                    await db.Vehicles.AddAsync(vehicle);
                    await db.SaveChangesAsync();

                    return vehicle.Id;
                }
            }
            catch (Exception ex)
            {

                throw;
            }


            return vehicle.Id;
        }
        public async Task<Guid> updateVehicle(Vehicle vehicle)
        {
            if (db != null)
            {
                db.Vehicles.Update(vehicle);
                await db.SaveChangesAsync();

                return vehicle.Id;
            }

            return vehicle.Id;
        }

        //Credit
        public Credit GetCredit(Guid creditId)
        {
            if (db != null)
            {
                return db.Credits.Where(x => x.Id == creditId).FirstOrDefault();
            }

            return null;
        }
        public async Task<Guid> AddCredit(Credit credit)
        {
            if (db != null)
            {
                await db.Credits.AddAsync(credit);
                await db.SaveChangesAsync();

                return credit.Id;
            }

            return credit.Id;
        }


        ///Customer

        public async Task<Guid> AddCustomer(Customer customer)
        {
            if (db != null)
            {
                await db.Customers.AddAsync(customer);
                await db.SaveChangesAsync();

                return customer.Id;
            }

            return customer.Id;
        }

        public Customer GetCustomer(string Email)
        {
            if (db != null)
            {
                return db.Customers.Where(x => x.Email == Email && !x.IsDeleted).FirstOrDefault();
            }

            return null;
        }


        //Policy

        public async Task<Guid> Addpolicy(Policy policy)
        {
            if (db != null)
            {
                await db.Policies.AddAsync(policy);
                await db.SaveChangesAsync();

                return policy.Id;
            }

            return policy.Id;
        }

        public async Task<Guid> updarepolicy(Policy policy)
        {
            if (db != null)
            {
                db.Policies.Update(policy);
                await db.SaveChangesAsync();

                return policy.Id;
            }

            return policy.Id;
        }



        public List<AdditionalProductsUsed> getAdditionalProductsUseds(Guid creditId)
        {
            return db.AdditionalProductsUseds.ToList().
                   Where(e => e.CreditId == creditId && !e.IsDeleted).ToList();
        }
        public void DeleteadditionalProductsUsed(Guid Id)
        {
            var res = db.AdditionalProductsUseds.
                   Where(e => e.Id == Id).FirstOrDefault();
            db.AdditionalProductsUseds.Remove(res);
            db.SaveChanges();
                             
        }

        public async Task<Guid> InsertAdditionalProductsUsed(AdditionalProductsUsed additionalProductsUsed)
        {
            if (db != null)
            {
                await db.AdditionalProductsUseds.AddAsync(additionalProductsUsed);
                await db.SaveChangesAsync();

                return additionalProductsUsed.Id;
            }

            return additionalProductsUsed.Id;
        }


    }
}
