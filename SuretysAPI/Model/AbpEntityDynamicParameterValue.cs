using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpEntityDynamicParameterValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string EntityId { get; set; }
        public int EntityDynamicParameterId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpEntityDynamicParameter EntityDynamicParameter { get; set; }
    }
}
