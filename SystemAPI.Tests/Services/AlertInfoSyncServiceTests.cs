using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using SystemAPI.Interfaces;
using SystemAPI.Models;
using SystemAPI.Services;
using SystemAPI.Tests.Services.Fake;
using NSubstitute;
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

        [Test]
        public void SyncAlertInfoByAlertNameAndPackageInfo_EmptyParameters_ThrowsException()
        {
            var stubEntityService = new FakeEntityServiceReuturnDefaultValue();
            var stubFetchService = new FakeAlertInfoFetchServiceReturnDefaultValue();
            var syncService = new AlertInfoSyncService(stubEntityService, stubFetchService);
            var ex = Assert.CatchAsync<Exception>(async () =>
                await syncService.SyncAlertInfoByAlertNameAndPackageInfoAsync(null, null));
            StringAssert.Contains("empty alert name", ex.Message);
        }

        [Test]
        public async Task SyncAlertInfoByAlertNameAndPackageInfo_ExistAlertName_CallEntityServiceMethods()
        {
            var exampleAlertName = "ExistAlertName";
            var emptyPackageInfo = new PackageInfo();
            var emptyAlertInfo = new AlertInfo();
            var mockEntityService = Substitute.For<IEntityService>();
            var stubFetchService = new FakeAlertInfoFetchServiceReturnDefaultValue();
            var syncService = new AlertInfoSyncService(mockEntityService, stubFetchService);
            _ = await syncService.SyncAlertInfoByAlertNameAndPackageInfoAsync(exampleAlertName, emptyPackageInfo);
            await mockEntityService.Received().GetAlertIdByAlertNameAndPackageInfoAsync(exampleAlertName, emptyPackageInfo);
            await mockEntityService.ReceivedWithAnyArgs().SaveAlertAsync(emptyAlertInfo);
        }

        [Test]
        public async Task SyncAlertInfoByAlertNameAndPackageInfo_ExistAlertName_CallFetchServiceMethods()
        {
            var exampleAlertName = "ExistAlertName";
            var emptyPackageInfo = new PackageInfo();
            var stubEntityService = new FakeEntityServiceReuturnDefaultValue();
            var mockFetchService = Substitute.For<IAlertInfoFetchService>();
            var syncService = new AlertInfoSyncService(stubEntityService, mockFetchService);
            _ = await syncService.SyncAlertInfoByAlertNameAndPackageInfoAsync(exampleAlertName, emptyPackageInfo);
            await mockFetchService.ReceivedWithAnyArgs().GetAlertInfoByIdAsync(1);
        }

        [Test]
        public async Task SyncAlertInfoByAlertNameAndPackageInfo_NewAlertName_CallEntityServiceMethods()
        {
            var exampleAlertName = "NewAlertName";
            var emptyPackageInfo = new PackageInfo();
            var emptyAlertInfo = new AlertInfo();
            var mockEntityService = Substitute.For<IEntityService>();
            var stubFetchService = new FakeAlertInfoFetchServiceReturnDefaultValue();
            var syncService = new AlertInfoSyncService(mockEntityService, stubFetchService);
            _ = await syncService.SyncAlertInfoByAlertNameAndPackageInfoAsync(exampleAlertName, emptyPackageInfo);
            await mockEntityService.ReceivedWithAnyArgs().SaveAlertAsync(emptyAlertInfo);
            await mockEntityService.Received().GetAlertIdByAlertNameAndPackageInfoAsync(exampleAlertName, emptyPackageInfo);
        }
    }
}
