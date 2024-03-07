using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.GetById
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogByIdController : ControllerBase
    {
        private readonly BL_BlogById _bL_BlogById;

        public BlogByIdController(BL_BlogById bl_BlogById)
        {
            _bL_BlogById = bl_BlogById;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> BlogById(int id)
        {
            var result = await _bL_BlogById.BlogById(id);
            return Ok(result);
        }
    }
}
