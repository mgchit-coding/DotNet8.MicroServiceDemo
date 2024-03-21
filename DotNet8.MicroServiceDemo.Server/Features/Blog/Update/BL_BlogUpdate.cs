namespace DotNet8.MicroServiceDemo.Server.Features.Blog.Update;

public class BL_BlogUpdate
{
    private readonly DL_BlogUpdate _dL_BlogUpdate;

    public BL_BlogUpdate(DL_BlogUpdate dLBlogUpdate)
    {
        _dL_BlogUpdate = dLBlogUpdate;
    }

    public async Task BlogUpdate(BlogUpdateModel model)
    {
        await _dL_BlogUpdate.BlogUpdate(model);
    }
}
