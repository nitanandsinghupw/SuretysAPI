using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AdditionalProductsToDealer
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public Guid? AdditionalProductsMasterId { get; set; }
        public Guid? DealerShipId { get; set; }

        public virtual AdditionalProductsMaster AdditionalProductsMaster { get; set; }
        public virtual DealerShip DealerShip { get; set; }
    }
}
