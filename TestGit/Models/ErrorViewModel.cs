using System;

namespace TestGit.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //Simple added comment for test

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}