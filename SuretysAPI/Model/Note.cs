using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class Note
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string NoteDetails { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }
        public bool IsActive { get; set; }
        public Guid? NoteStatusId { get; set; }
        public Guid? DealerGroupId { get; set; }
        public Guid? DealerShipId { get; set; }
        public Guid? LenderId { get; set; }

        public virtual DealerGroup DealerGroup { get; set; }
        public virtual DealerShip DealerShip { get; set; }
        public virtual Lender Lender { get; set; }
        public virtual NoteStatus NoteStatus { get; set; }
    }
}
