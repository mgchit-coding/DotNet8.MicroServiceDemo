using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Delete;

[Route("api/[controller]")]
[ApiController]
public class BlogDeleteController : BaseController
{
    private readonly IPublishEndpoint _publishEndpoint;

    public BlogDeleteController(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost, Route("Delete")]
    public async Task<IActionResult> BlogDelete(BlogDeleteModel model)
    {
        try
        {
            await _publishEndpoint.Publish(model);
            return Ok();
        }
        catch (Exception ex)
        {
            return InternalServerError(ex);
        }
    }
}
