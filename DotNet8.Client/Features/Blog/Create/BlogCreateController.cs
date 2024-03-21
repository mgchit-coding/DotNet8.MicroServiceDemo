using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Create
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCreateController : BaseController
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public BlogCreateController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost, Route("Create")]
        public async Task<IActionResult> BlogCreate(BlogCreateModel model)
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
}
