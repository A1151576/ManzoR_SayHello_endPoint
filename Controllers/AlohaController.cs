/*                      Rafael Manzo
                    Say Hello 'End Points'
                                                            10/25/2022
    Peer Review: John Magpantay   notes : code is clean and simple, doin what i's suppose to do. Perfect API practice, Good work overall! */




using Microsoft.AspNetCore.Mvc;

namespace ManzoR_SayHello_endPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AlohaController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    public string SayHello(string name)
    {
        return $"Hello {name}";
    }
}
