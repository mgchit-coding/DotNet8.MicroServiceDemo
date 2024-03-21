using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Client.Features.Blog.GetById;

[Route("api/[controller]")]
[ApiController]
public class BlogByIdController : BaseController
{
    private readonly AppDbContext _context;

    public BlogByIdController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BlogById(int id)
    {
        try
        {
            var result = await _context.Blog
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.BlogId == id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return InternalServerError(ex);
        }
    }
}
