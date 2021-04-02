using System;
using System.Collections.Generic;
using System.Text;
using SystemAPI.Constants;

namespace SystemAPI.Models
{
    public class PackageInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public PackageSource PackageSource { get; set; }
    }
}
