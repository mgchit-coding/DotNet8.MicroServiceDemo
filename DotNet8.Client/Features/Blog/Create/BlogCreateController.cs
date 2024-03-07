using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Create
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCreateController : ControllerBase
    {
        private readonly BL_BlogCreate _bL_BlogCreate;

        public BlogCreateController(BL_BlogCreate bL_BlogCreate)
        {
            _bL_BlogCreate = bL_BlogCreate;
        }

        [HttpPost, Route("Create")]
        public async Task<IActionResult> BlogCreate(BlogCreateModel model)
        {
            await _bL_BlogCreate.BlogCreate(model);
            return Ok();
        }
    }
}
