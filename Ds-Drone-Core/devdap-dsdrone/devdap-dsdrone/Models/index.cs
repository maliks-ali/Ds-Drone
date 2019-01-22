using System;

namespace devdap_dsdrone.Models
{
    public class index
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}