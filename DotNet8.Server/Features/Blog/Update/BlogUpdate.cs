namespace DotNet8.Server.Features.Blog.Update
{
    public class BlogUpdate : IConsumer<BlogUpdateModel>
    {
        private readonly BL_BlogUpdate _bL_BlogUpdate;

        public BlogUpdate(BL_BlogUpdate bLBlogUpdate)
        {
            _bL_BlogUpdate = bLBlogUpdate;
        }

        public async Task Consume(ConsumeContext<BlogUpdateModel> context)
        {
            await _bL_BlogUpdate.BlogUpdate(context.Message);
        }
    }
}
