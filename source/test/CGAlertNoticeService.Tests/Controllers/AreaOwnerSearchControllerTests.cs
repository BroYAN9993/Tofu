using NUnit.Framework;
using CGAlertNoticeService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CGAlertNoticeService.Tests.Controllers
{
    [TestFixture] 
    public class AreaOwnerSearchControllerTests
    {
        private AreaOwnerSearchController _areaOwnerSearchController;

        [SetUp]
        public void Setup()
        {
            var logger = new LoggerFactory().CreateLogger<AreaOwnerSearchController>();
            _areaOwnerSearchController = new AreaOwnerSearchController(logger);                
        }

        public void Is
    }
}
