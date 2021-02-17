using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpEntityDynamicParameter
    {
        public AbpEntityDynamicParameter()
        {
            AbpEntityDynamicParameterValues = new HashSet<AbpEntityDynamicParameterValue>();
        }

        public int Id { get; set; }
        public string EntityFullName { get; set; }
        public int DynamicParameterId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpDynamicParameter DynamicParameter { get; set; }
        public virtual ICollection<AbpEntityDynamicParameterValue> AbpEntityDynamicParameterValues { get; set; }
    }
}
