using System;

namespace SampleApplication.Models
{
    /// <summary>
    /// Error View Model for Error UI
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
