using Microsoft.EntityFrameworkCore;

namespace DotNet8.Server.Features.Blog.Delete;

public class DL_BlogDelete
{
    private readonly AppDbContext _context;

    public DL_BlogDelete(AppDbContext context)
    {
        _context = context;
    }

    public async Task BlogDelete(BlogDeleteModel model)
    {
        try
        {
            var blog = await _context.Blog
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.BlogId == model.BlogId);
            if (blog == null) return;
            _context.Blog.Remove(blog);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
