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
        public AreaOwnerSearchController()
        {
        }
        
        [HttpGet]
        public Task<ActionResult<IEnumerable<AreaOwnerInfo>>> SearchOwnerAsync([FromBody] PackageInfo packageInfo)
        {
            if (packageInfo is null) throw new ArgumentNullException();
            throw new NotImplementedException();
        }
    }
}