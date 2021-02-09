using CGAlertNoticeService.Interfaces;
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
        private IEntityService EntityService { get; set; }
        public AreaOwnerSearchController(IEntityService entityService)
        {
            EntityService = entityService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaOwnerInfo>>> SearchOwnerAsync([FromBody] PackageInfo packageInfo)
        {
            if (packageInfo is null) throw new ArgumentNullException();
            var OwnerInfos = await EntityService.GetAreaOwnerInfosByPackageInfoAsync(packageInfo).ConfigureAwait(false);
            return Ok(OwnerInfos);
        }
    }
}