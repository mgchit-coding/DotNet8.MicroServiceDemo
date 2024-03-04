using DotNet8.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Server.Services;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<BlogDataModel> Blog { get; set; }
}