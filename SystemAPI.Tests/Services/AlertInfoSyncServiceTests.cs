using System;
using System.Collections.Generic;
using System.Text;
using SystemAPI.Models;
using NUnit.Framework;

namespace SystemAPI.Tests.Services
{
    [TestFixture]
    public class AlertInfoSyncServiceTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(null, null)]
        public void SyncAlertInfoByAlertNameAndPackageInfo_EmptyParameters_ThrowsException(string alertName,
            PackageInfo packageInfo)
        {
            
        }
    }
}
