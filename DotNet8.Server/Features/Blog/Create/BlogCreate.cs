namespace DotNet8.Server.Features.Blog.Create;

public class BlogCreate : IConsumer<BlogCreateModel>
{
    private readonly BL_BlogCreate _bL_BlogCreate;

    public BlogCreate(BL_BlogCreate bLBlogCreate)
    {
        _bL_BlogCreate = bLBlogCreate;
    }

    public async Task Consume(ConsumeContext<BlogCreateModel> context)
    {
        await _bL_BlogCreate.BlogCreate(context.Message);
    }
}