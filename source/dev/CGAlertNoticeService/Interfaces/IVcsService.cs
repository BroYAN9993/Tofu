using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CGAlertNoticeService.Models;

namespace CGAlertNoticeService.Interfaces
{
    public interface IVcsService
    {
        public Task<ICollection<UserInfo>> GetUserInfosByPackageLocationAsync(PackageLocation packageLocation);
    }
}