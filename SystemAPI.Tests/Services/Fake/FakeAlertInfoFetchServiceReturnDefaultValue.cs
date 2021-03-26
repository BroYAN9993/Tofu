using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;

namespace SystemAPI.Tests.Services.Fake
{
    internal class FakeAlertInfoFetchServiceReturnDefaultValue : IAlertInfoFetchService
    {
        public Task<AlertInfo> GetAlertInfoByIdAsync(int id) => null;

        public Task<IEnumerable<AlertInfo>> GetAlertInfosByRepoAsync(RepoInfo repoInfo) => null;
    }
}
