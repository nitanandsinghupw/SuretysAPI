using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class DeclineReasonMaster
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }
    }
}
