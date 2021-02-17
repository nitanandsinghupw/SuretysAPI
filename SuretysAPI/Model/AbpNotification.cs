﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpNotification
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public string Data { get; set; }
        public string DataTypeName { get; set; }
        public string EntityId { get; set; }
        public string EntityTypeAssemblyQualifiedName { get; set; }
        public string EntityTypeName { get; set; }
        public string ExcludedUserIds { get; set; }
        public string NotificationName { get; set; }
        public byte Severity { get; set; }
        public string TenantIds { get; set; }
        public string UserIds { get; set; }
    }
}
