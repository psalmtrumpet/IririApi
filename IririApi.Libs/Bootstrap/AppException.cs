﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IririApi.Libs.Bootstrap
{
    public class AppException : Exception
    {
        public AppException(string message, string friendlyMessage, Exception innerException)
           : base(message, innerException)
        {
            FriendlyMessage = friendlyMessage;
        }

        public AppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AppException(string message, string friendlyMessage)
            : base(message)
        {
            FriendlyMessage = friendlyMessage;
        }

        public AppException(string message)
            : base(message)
        {
        }

        public string FriendlyMessage { get; set; }
    }
}
