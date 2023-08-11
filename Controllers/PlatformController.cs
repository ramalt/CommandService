using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers;

[Route("api/command/[controller]")]
[ApiController]
public class PlatformController : ControllerBase
{
    public PlatformController()
    {

    }

    [HttpGet]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("-> inbound post service");

        return Ok("inbouund working");
    }
}
