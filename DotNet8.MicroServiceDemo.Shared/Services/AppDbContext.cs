using DotNet8.MicroServiceDemo.Shared.Models.Blog;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.MicroServiceDemo.Shared.Services;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<BlogDataModel> Blog { get; set; }
}