using Microsoft.EntityFrameworkCore;

namespace DotNet8.Client.Features.Blog.GetById
{
    public class DL_BlogById
    {
        private readonly AppDbContext _context;

        public DL_BlogById(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BlogDataModel> BlogById(int id)
        {
            try
            {
                var blog = await _context.Blog
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x=> x.BlogId == id);
                return blog;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
