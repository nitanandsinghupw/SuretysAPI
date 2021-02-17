using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Credits = new HashSet<Credit>();
            Customers = new HashSet<Customer>();
            Policies = new HashSet<Policy>();
        }

        public Guid Id { get; set; } 
        public DateTime CreationTime { get; set; } 
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Miles { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public bool? BenchmarkTest { get; set; }
        public Guid? DealerShipId { get; set; }
        public Guid? CustomerId { get; set; }
        public long? UserId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual DealerShip DealerShip { get; set; }
        public virtual AbpUser User { get; set; }
        public virtual ICollection<Credit> Credits { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
    }
}
