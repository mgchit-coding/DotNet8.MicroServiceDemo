using DotNet8.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Client.Services;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<BlogDataModel> Blog { get; set; }
}