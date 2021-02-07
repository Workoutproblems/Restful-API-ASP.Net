using System;

namespace ParkyWeb.Models
{
    public class ErrorViewModel
    {
        // Model
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
