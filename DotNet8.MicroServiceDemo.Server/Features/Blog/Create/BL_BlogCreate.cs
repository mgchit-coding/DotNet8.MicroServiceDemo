using DotNet8.MicroServiceDemo.Shared.Models;

namespace DotNet8.MicroServiceDemo.Server.Features.Blog.Create;

public class BL_BlogCreate
{
    private readonly DL_BlogCreate _dL_blogCreate;

    public BL_BlogCreate(DL_BlogCreate dLBlogCreate)
    {
        _dL_blogCreate = dLBlogCreate;
    }

    public async Task BlogCreate(BlogCreateModel model)
    {
        await _dL_blogCreate.BlogCreate(model.Change());
    }
}
