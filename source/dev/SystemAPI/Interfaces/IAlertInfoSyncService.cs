using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Models;

namespace SystemAPI.Interfaces
{
    public interface IAlertInfoSyncService
    {
        public Task<int> SyncAlertInfoByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo);
    }
}
