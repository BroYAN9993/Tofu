using NUnit.Framework;
using CGAlertNoticeService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlertNoticeService.Tests.Controllers
{
    [TestFixture] 
    public class AreaOwnerSearchControllerTests
    {
        private AreaOwnerSearchController _areaOwnerSearchController;

        [SetUp]
        public void Setup()
        {
            _areaOwnerSearchController = new AreaOwnerSearchController();                
        }

        [Test]
        public void IsThrowArgumentNull_SearchOwnerAsync()
        {
            Assert.ThrowsAsync<ArgumentNullException>(
                async () => await _areaOwnerSearchController.SearchOwnerAsync(null));
        }
    }
}
