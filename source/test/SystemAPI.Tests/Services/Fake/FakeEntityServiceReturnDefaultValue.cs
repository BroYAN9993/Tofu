using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;
using NSubstitute.Core;

namespace SystemAPI.Tests.Services.Fake
{
    internal class FakeEntityServiceReuturnDefaultValue : IEntityService
    {
        public async Task<int> GetAlertIdByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo) => 0;

        public async Task<int> SaveAlertAsync(AlertInfo alertInfo) => 0;
    }
}
