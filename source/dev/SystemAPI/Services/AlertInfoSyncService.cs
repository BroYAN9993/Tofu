using System;
using System.Collections.Generic;
using System.Text;
using SystemAPI.Interfaces;

namespace SystemAPI.Services
{
    public class AlertInfoSyncService : IAlertInfoSyncService
    {
        public IEntityService EntitiyService { get; set; }
        public IAlertInfoFetchService AlertInfoFetchService { get; set; }
        public AlertInfoSyncService(IEntityService entityService, IAlertInfoFetchService alertInfoFetchService)
        {
            EntitiyService = entityService;
            AlertInfoFetchService = alertInfoFetchService;
        }
    }
}
