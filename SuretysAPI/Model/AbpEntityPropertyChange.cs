using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AbpEntityPropertyChange
    {
        public long Id { get; set; }
        public long EntityChangeId { get; set; }
        public string NewValue { get; set; }
        public string OriginalValue { get; set; }
        public string PropertyName { get; set; }
        public string PropertyTypeFullName { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpEntityChange EntityChange { get; set; }
    }
}
