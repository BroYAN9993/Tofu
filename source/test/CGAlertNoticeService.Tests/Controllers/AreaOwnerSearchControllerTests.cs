using NUnit.Framework;
using CGAlertNoticeService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CGAlertNoticeService.Interfaces;
using CGAlertNoticeService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CGAlertNoticeService.Tests.Controllers
{
    [TestFixture] 
    public class AreaOwnerSearchControllerTests
    {
        private AreaOwnerSearchController _areaOwnerSearchController;

        [SetUp]
        public void Setup()
        {
            var mockEntityService = new Mock<IEntityService>();
            _areaOwnerSearchController = new AreaOwnerSearchController(mockEntityService.Object);
            var packageInfo = new PackageInfo
            {
                PackageName = "Test",
                PackageRepoName = "Tofu.Test",
                PackageSource = PackageSource.Nuget
            };
            var areaOwnerInfo = new AreaOwnerInfo
            {
                PackageName = "Test",
                PackageSource = PackageSource.Nuget,
                OwnerName = "Yan Sun",
                Path = "\\source\\test\\path",
                Email = "yansun@test.com"
            };
            var areaOwnerInfos = new List<AreaOwnerInfo>();
            areaOwnerInfos.Add(areaOwnerInfo);
            mockEntityService.Setup(entity => entity.GetAreaOwnerInfosByPackageInfoAsync(packageInfo).Result).Returns(areaOwnerInfos);              
        }

        [Test]
        public void IsThrowArgumentNull_SearchOwnerAsync()
        {
            Assert.ThrowsAsync<ArgumentNullException>(
                async () => await _areaOwnerSearchController.SearchOwnerAsync(null));
        }

        [Test]
        public async Task IsReturnAreaOwnerInfos_SearchOwnerAsync()
        {
            var inputPackageInfo = new PackageInfo
            {
                PackageName = "Test",
                PackageRepoName = "Tofu.Test",
                PackageSource = PackageSource.Nuget
            };
            var result = await _areaOwnerSearchController.SearchOwnerAsync(inputPackageInfo).ConfigureAwait(false);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<ActionResult<IEnumerable<AreaOwnerInfo>>>(result);
        }
    }
}
