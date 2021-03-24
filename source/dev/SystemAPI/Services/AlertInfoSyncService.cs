using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;

namespace SystemAPI.Services
{
    public class AlertInfoSyncService : IAlertInfoSyncService
    {
        public IEntityService EntityService { get; set; }
        public IAlertInfoFetchService AlertInfoFetchService { get; set; }
        public AlertInfoSyncService(IEntityService entityService, IAlertInfoFetchService alertInfoFetchService)
        {
            EntityService = entityService;
            AlertInfoFetchService = alertInfoFetchService;
        }

        public async Task<int> SyncAlertInfoByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo)
        {
            var alertId = await EntityService.GetAlertIdByAlertNameAndPackageInfoAsync(alertName, packageInfo);
            var alertInfo = await AlertInfoFetchService.GetAlertInfoByIdAsync(alertId);
            var id = await EntityService.SaveAlertAsync(alertInfo);
            return id;
        }
    }
}
