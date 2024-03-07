using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Delete
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDeleteController : ControllerBase
    {
        private readonly BL_BlogDelete _bL_BlogDelete;

        public BlogDeleteController(BL_BlogDelete bL_BlogDelete)
        {
            _bL_BlogDelete = bL_BlogDelete;
        }

        [HttpPost, Route("Delete")]
        public async Task<IActionResult> BlogDelete(BlogDeleteModel model)
        {
            await _bL_BlogDelete.BlogDelete(model);
            return Ok();
        }
    }
}
