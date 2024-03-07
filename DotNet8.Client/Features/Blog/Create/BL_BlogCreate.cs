using DotNet8.Shared.Models;

namespace DotNet8.Client.Features.Blog.Create
{
    public class BL_BlogCreate
    {
        private readonly DL_BlogCreate _dL_blogCreate;

        public BL_BlogCreate(DL_BlogCreate dLBlogCreate)
        {
            _dL_blogCreate = dLBlogCreate;
        }

        public async Task BlogCreate(BlogCreateModel model)
        {
            await _dL_blogCreate.BlogCreate(model);
        }
    }
}
