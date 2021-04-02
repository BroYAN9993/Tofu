using System;
using System.Collections.Generic;
using System.Text;

namespace SystemAPI.Models
{
    public class AlertInfo
    {
        public string Name { get; set; }
        public PackageInfo PackageInfo { get; set; }
        public RepoInfo RepoInfo { get; set; }
        public IEnumerable<WorkItemInfo> WorkItemInfos { get; set; }
    }
}
