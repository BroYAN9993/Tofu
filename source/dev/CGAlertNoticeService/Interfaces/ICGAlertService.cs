using System.Collections.Generic;
using System.Threading.Tasks;
using CGAlertNoticeService.Models;

namespace CGAlertNoticeService.Interfaces
{
    public interface ICGAlertService
    {
        public Task<CGAlertInfo> GetCGAlertInfoByPackageInfoAsync(PackageInfo packageInfo);
        public Task<CGAlertInfo> GetCGAlertInfoByAlertIdAsync(string alertId);
    }
}