namespace DotNet8.Server.Features.Blog.Delete
{
    public class BlogDelete : IConsumer<BlogDeleteModel>
    {
        private readonly BL_BlogDelete _bL_BlogDelete;

        public BlogDelete(BL_BlogDelete bLBlogDelete)
        {
            _bL_BlogDelete = bLBlogDelete;
        }

        public async Task Consume(ConsumeContext<BlogDeleteModel> context)
        {
            await _bL_BlogDelete.BlogDelete(context.Message);
        }
    }
}
