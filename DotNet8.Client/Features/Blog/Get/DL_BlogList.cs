using Microsoft.EntityFrameworkCore;

namespace DotNet8.Client.Features.Blog.Get
{
    public class DL_BlogList
    {
        private readonly AppDbContext _context;

        public DL_BlogList(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BlogDataModel>> BlogList()
        {
            try
            {
                var blogList = await _context.Blog.AsNoTracking().ToListAsync();
                return blogList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
