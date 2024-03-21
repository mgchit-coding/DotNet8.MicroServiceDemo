using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.MicroServiceDemo.Client.Features.Blog.Get;

[Route("api/[controller]")]
[ApiController]
public class BlogListController : BaseController
{
    private readonly AppDbContext _context;

    public BlogListController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> BlogList()
    {
        try
        {
            var result = await _context.Blog.AsNoTracking().ToListAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return InternalServerError(ex);
        }
    }
}
