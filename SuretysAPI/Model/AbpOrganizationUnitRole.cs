﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpOrganizationUnitRole
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }
        public int RoleId { get; set; }
        public long OrganizationUnitId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
