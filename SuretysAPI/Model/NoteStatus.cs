using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class NoteStatus
    {
        public NoteStatus()
        {
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
