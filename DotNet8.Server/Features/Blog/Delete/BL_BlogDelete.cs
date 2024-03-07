namespace DotNet8.Server.Features.Blog.Delete
{
    public class BL_BlogDelete
    {
        private readonly DL_BlogDelete _dL_BlogDelete;

        public BL_BlogDelete(DL_BlogDelete dLBlogDelete)
        {
            _dL_BlogDelete = dLBlogDelete;
        }

        public async Task BlogDelete(BlogDeleteModel model)
        {
            await _dL_BlogDelete.BlogDelete(model);
        }
    }
}
