using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Models;

namespace SystemAPI.Interfaces
{
    public interface IAlertNoticeService
    {
        Task NoticeAllOwnersByAlertNameAndPackageInfoAsync(string alertName, PackageInfo packageInfo);
    }
}
