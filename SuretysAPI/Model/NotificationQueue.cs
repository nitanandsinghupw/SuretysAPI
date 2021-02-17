using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class NotificationQueue
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string Type { get; set; }
        public string ToMail { get; set; }
        public string ToPhoneNumber { get; set; }
        public string PolicyNumber { get; set; }
    }
}
