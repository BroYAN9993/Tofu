using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;
using DatabaseService.Contexts;

namespace DatabaseService.Services
{
    public class DatabaseService : IEntityService
    {
        public async Task<int> GetAlertIdByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo)
        {
            if (alertName == null)
            {
                throw new ArgumentNullException(nameof(alertName));
            }

            if (packageInfo == null)
            {
                throw new ArgumentNullException(nameof(packageInfo));
            }

            var packageName = packageInfo.Name;
            var packageVersion = packageInfo.Version;

            await using var context = new SqliteDatabaseContext();
            try
            {
                var id = await context.CGAlertPackages
                    .Include(ap => ap.CGAlert)
                    .Include(ap => ap.Package)
                    .Where(ap =>
                        ap.CGAlert.AlertName == alertName && ap.Package.PackageName == packageName &&
                        ap.Package.Version == packageVersion)
                    .Select(ap => ap.CGAlertId)
                    .SingleAsync();
                return id;
            }
            catch (InvalidOperationException)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public Task<int> SaveAlertAsync(AlertInfo alertInfo)
        {
            throw new NotImplementedException();
        }

        public Task<AlertInfo> GetAlertInfoByIdAsync(int alertId)
        {
            throw new NotImplementedException();
        }

        public Task RecordAlertNoticeEmailsAsync(IEnumerable<AlertNoticeEmail> emails)
        {
            throw new NotImplementedException();
        }
    }
}
