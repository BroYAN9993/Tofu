using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Models;

namespace SystemAPI.Utils.Implementation
{
    public interface INoticeMessageProcessor
    {
        IEnumerable<AlertNoticeEmail> GenerateEmailsByAlertInfo(AlertInfo alertInfo);
        Task SendAlertNoticeEmailsAsync(IEnumerable<AlertNoticeEmail> emails);
    }
}
