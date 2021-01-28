using CGAlertNoticeService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CGAlertNoticeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaOwnerSearchController : ControllerBase
    {
        private readonly ILogger<AreaOwnerSearchController> _logger;

        public AreaOwnerSearchController(ILogger<AreaOwnerSearchController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public Task<ActionResult<IEnumerable<AreaOwnerInfo>>> SerachOwnerAsync([FromBody] PackageInfo packageInfo)
        {
            throw new NotImplementedException();
        }
    }
}