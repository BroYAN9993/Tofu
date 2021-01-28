using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CGAlertNoticeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaOwnerSearvhController : ControllerBase
    {
        private readonly ILogger<AreaOwnerSearvhController> _logger;

        public AreaOwnerSearvhController(ILogger<AreaOwnerSearvhController> logger)
        {
            _logger = logger;
        }
        
    }
}