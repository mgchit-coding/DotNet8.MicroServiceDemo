namespace DotNet8.Server.Features.Blog.Create;

public class BlogCreate : IConsumer<BlogCreateModel>
{
    private readonly AppDbContext _appDbContext;

    public BlogCreate(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Task Consume(ConsumeContext<BlogCreateModel> context)
    {
        var model = context.Message;
        return Task.CompletedTask;
    }
}