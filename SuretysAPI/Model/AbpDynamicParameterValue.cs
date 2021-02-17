using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpDynamicParameterValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int? TenantId { get; set; }
        public int DynamicParameterId { get; set; }

        public virtual AbpDynamicParameter DynamicParameter { get; set; }
    }
}
