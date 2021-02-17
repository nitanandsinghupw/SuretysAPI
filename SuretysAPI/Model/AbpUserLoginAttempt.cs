﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpUserLoginAttempt
    {
        public long Id { get; set; }
        public string BrowserInfo { get; set; }
        public string ClientIpAddress { get; set; }
        public string ClientName { get; set; }
        public DateTime CreationTime { get; set; }
        public byte Result { get; set; }
        public string TenancyName { get; set; }
        public int? TenantId { get; set; }
        public long? UserId { get; set; }
        public string UserNameOrEmailAddress { get; set; }
    }
}
