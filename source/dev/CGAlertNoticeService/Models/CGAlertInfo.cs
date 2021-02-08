using System.Collections.Generic;

namespace CGAlertNoticeService.Models
{
    public class CGAlertInfo
    {
        public string Id { get; set; }
        public PackageInfo AffectedComponent { get; set; }
        public string Description { get; set; }
        public ICollection<string> Locations { get; set; }
        public string Recommendation { get; set; }
    }
}