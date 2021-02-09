using System.Collections.Generic;
using System.Threading.Tasks;
using CGAlertNoticeService.Models;

namespace CGAlertNoticeService.Interfaces
{
    public interface IEntityService
    {
        public Task<ICollection<AreaOwnerInfo>> GetAreaOwnerInfosByPackageInfoAsync(PackageInfo packageInfo);
    }
}