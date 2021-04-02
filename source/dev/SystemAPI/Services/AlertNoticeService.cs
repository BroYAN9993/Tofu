using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;
using SystemAPI.Utils.Implementation;

namespace SystemAPI.Services
{
    public class AlertNoticeService : IAlertNoticeService
    {
        private IAlertInfoSyncService SyncService { get; set; }
        private IAlertSourceService FetchService { get; set; }
        private IEntityService EntityService { get; set; }
        private INoticeMessageProcessor MessageProcessor { get; set; }

        public AlertNoticeService(IAlertInfoSyncService syncService, IAlertSourceService fetchService,
            IEntityService entityService, INoticeMessageProcessor messageProcessor)
        {
            SyncService = syncService;
            FetchService = fetchService;
            EntityService = entityService;
            MessageProcessor = messageProcessor;
        }

        public async Task NoticeAllOwnersByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo)
        {
            var alertId = await SyncService.SyncAlertInfoByAlertNameAndPackageInfoAsync(alertName, packageInfo);
            var alertInfo = await EntityService.GetAlertInfoByIdAsync(alertId);
            var emails = MessageProcessor.GenerateEmailsByAlertInfo(alertInfo);
            await MessageProcessor.SendAlertNoticeEmailsAsync(emails);
            await EntityService.RecordAlertNoticeEmailsAsync(emails);
        }
    }
}
