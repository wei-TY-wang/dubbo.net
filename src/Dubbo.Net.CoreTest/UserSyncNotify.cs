﻿
using Dubbo.Net.Common.Attributes;

namespace Dubbo.Net.CoreTest
{
    [Refer("com.mc.userconnect.api.contract.request.UserSyncNotify")]
    public class UserSyncNotify
    {
        public string version { get; set; }
        public string merchantId { get; set; }
        public string mid { get; set; }
        public string uid { get; set; }
        public string status { get; set; }
        public string token { get; set; }
        public string signature { get; set; }
    }
}
