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
        public IAlertSourceService AlertSourceService { get; set; }
        public AlertInfoSyncService(IEntityService entityService, IAlertSourceService alertSourceService)
        {
            EntityService = entityService;
            AlertSourceService = alertSourceService;
        }

        public async Task<int> SyncAlertInfoByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo)
        {
            AlertInfo alertInfo;
            if (alertName == null)
            {
                throw new ArgumentNullException(nameof(alertName), "empty alert name");
            }
            if (packageInfo == null)
            {
                throw new ArgumentNullException(nameof(packageInfo), "empty alert name");
            }

            try
            {
                var alertId = await EntityService.GetAlertIdByAlertNameAndPackageInfoAsync(alertName, packageInfo);
                alertInfo = await AlertSourceService.GetAlertInfoByIdAsync(alertId);
            }
            catch (ArgumentOutOfRangeException)
            {
                alertInfo = await AlertSourceService.GetAlertInfoByAlertNameAndPackageInfoAsync(alertName, packageInfo);
            }
            var id = await EntityService.SaveAlertAsync(alertInfo);
            return id;
        }
    }
}
