using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Models;

namespace SystemAPI.Interfaces
{
    public interface IAlertInfoFetchService
    {
        public Task<AlertInfo> GetAlertInfoByIdAsync(int id);
        public Task<AlertInfo> GetAlertInfoByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo);
        public Task<IEnumerable<AlertInfo>> GetAlertInfosByRepoAsync(RepoInfo repoInfo);
    }
}
