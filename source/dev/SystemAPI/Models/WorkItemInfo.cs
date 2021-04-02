using System;
using System.Collections.Generic;
using System.Text;

namespace SystemAPI.Models
{
    public class WorkItemInfo
    {
        public string Name { get; set; }
        public OwnerInfo OwnerInfo { get; set; }
        public string Location { get; set; }
    }
}
