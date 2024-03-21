using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Update
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogUpdateController : BaseController
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public BlogUpdateController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost, Route("Update")]
        public async Task<IActionResult> BlogUpdate(BlogUpdateModel model)
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
