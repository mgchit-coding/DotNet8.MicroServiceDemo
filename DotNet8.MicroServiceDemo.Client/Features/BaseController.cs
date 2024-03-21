using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.MicroServiceDemo.Client.Features;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    public IActionResult InternalServerError(Exception ex)
    {
        return StatusCode(500, new
        {
            IsSuccess = false,
            Message = ex.ToString()
        });
    }
}
