using System.Collections.Generic;
using System.Threading.Tasks;
using CGAlertNoticeService.Models;

namespace CGAlertNoticeService.Interfaces
{
    public interface IEntityService
    {
        public Task<IEnumerable<AreaOwnerInfo>> GetAreaOwnerInfosByPackageInfoAsync(PackageInfo packageInfo);
    }
}