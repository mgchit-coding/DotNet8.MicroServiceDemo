using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Client.Features.Blog.Get
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogListController : ControllerBase
    {
        private readonly BL_BlogList _Bl_BlogList;

        public BlogListController(BL_BlogList bl_BlogList)
        {
            _Bl_BlogList = bl_BlogList;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var result = await _Bl_BlogList.BlogList();
            return Ok(result);
        }
    }
}
