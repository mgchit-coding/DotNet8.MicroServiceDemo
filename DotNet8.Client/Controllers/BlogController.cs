namespace DotNet8.Client.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IPublishEndpoint _publishEndpoint;

    public BlogController(AppDbContext context, IPublishEndpoint publishEndpoint)
    {
        _context = context;
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost, Route("Create")]
    public async Task<IActionResult> BlogCreate(BlogCreateModel model)
    {
        await _publishEndpoint.Publish(model);
        return Ok();
    }

    [HttpPost, Route("Update")]
    public async Task<IActionResult> BlogUpdate(BlogUpdateModel model)
    {
        await _publishEndpoint.Publish(model);
        return Ok();
    }

    [HttpPost, Route("Delete")]
    public async Task<IActionResult> BlogDelete(BlogDeleteModel model)
    {
        await _publishEndpoint.Publish(model);
        return Ok();
    }
}