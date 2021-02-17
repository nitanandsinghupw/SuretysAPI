using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class PolicyDeclineReason
    {
        public Guid Id { get; set; }
        public Guid? PolicyId { get; set; }
        public string Reason { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
