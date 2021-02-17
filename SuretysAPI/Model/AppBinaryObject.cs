using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AppBinaryObject
    {
        public Guid Id { get; set; }
        public byte[] Bytes { get; set; }
        public int? TenantId { get; set; }
    }
}
