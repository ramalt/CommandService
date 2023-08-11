using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers;

[Route("api/command/[controller]")]
[ApiController]
public class PlatformController : ControllerBase
{
    public PlatformController()
    {

    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("🔽 -> received POST message!");

        return Ok("alright! platform service is requested");
    }
}
