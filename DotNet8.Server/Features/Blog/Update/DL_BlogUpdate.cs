using Microsoft.EntityFrameworkCore;

namespace DotNet8.Server.Features.Blog.Update
{
    public class DL_BlogUpdate
    {
        private readonly AppDbContext _context;

        public DL_BlogUpdate(AppDbContext context)
        {
            _context = context;
        }

        public async Task BlogUpdate(BlogUpdateModel model)
        {
            try
            {
                var blog = await _context.Blog
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.BlogId == model.Id);
                if (blog == null) return;

                blog.BlogAuthor = model.BlogAuthor;
                blog.BlogContent = model.BlogContent;
                _context.Blog.Update(blog);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
