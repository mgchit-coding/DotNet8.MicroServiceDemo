using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Update
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogUpdateController : ControllerBase
    {
        private readonly BL_BlogUpdate _bL_BlogUpdate;

        public BlogUpdateController(BL_BlogUpdate bL_BlogUpdate)
        {
            _bL_BlogUpdate = bL_BlogUpdate;
        }
        [HttpPost, Route("Update")]
        public async Task<IActionResult> BlogUpdate(BlogUpdateModel model)
        {
            await _bL_BlogUpdate.BlogUpdate(model);
            return Ok();
        }
    }
}
