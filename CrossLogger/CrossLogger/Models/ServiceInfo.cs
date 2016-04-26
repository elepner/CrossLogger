using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossLogger.Models
{
    public class ServiceInfo
    {
        public ServiceInfo()
        {
            Version = "1";
            Name = "CrossLogger";
        }

        public string Version;
        public string Name;
    }
}