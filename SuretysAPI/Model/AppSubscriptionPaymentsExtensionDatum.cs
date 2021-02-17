using System;
using System.Collections.Generic;

#nullable disable

namespace SuretysAPI.Model
{
    public partial class AppSubscriptionPaymentsExtensionDatum
    {
        public long Id { get; set; }
        public long SubscriptionPaymentId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
    }
}
