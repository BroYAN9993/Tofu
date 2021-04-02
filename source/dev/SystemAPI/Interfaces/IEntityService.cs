using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Models;

namespace SystemAPI.Interfaces
{
    public interface IEntityService
    {
        Task<int> GetAlertIdByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo);
        Task<int> SaveAlertAsync(AlertInfo alertInfo);
        Task<AlertInfo> GetAlertInfoByIdAsync(int alertId);
        Task RecordAlertNoticeEmailsAsync(IEnumerable<AlertNoticeEmail> emails);
    }
}
