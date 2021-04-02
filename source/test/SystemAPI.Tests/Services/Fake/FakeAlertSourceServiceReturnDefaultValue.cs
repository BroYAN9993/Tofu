using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;

namespace SystemAPI.Tests.Services.Fake
{
    public class FakeAlertSourceServiceReturnDefaultValue : IAlertSourceService
    {
        public async Task<AlertInfo> GetAlertInfoByIdAsync(int id) => null;

        public async Task<AlertInfo> GetAlertInfoByAlertNameAndPackageInfoAsync(string alertName,
            PackageInfo packageInfo) => null;
        public async Task<IEnumerable<AlertInfo>> GetAlertInfosByRepoAsync(RepoInfo repoInfo) => null;
    }
}
