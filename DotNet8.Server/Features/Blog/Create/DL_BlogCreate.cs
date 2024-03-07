using Microsoft.EntityFrameworkCore;

namespace DotNet8.Server.Features.Blog.Create
{
    public class DL_BlogCreate
    {
        private readonly AppDbContext _context;

        public DL_BlogCreate(AppDbContext context)
        {
            _context = context;
        }

        public async Task BlogCreate(BlogDataModel model)
        {
            try
            {
                await _context.Blog.AddAsync(model);
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
