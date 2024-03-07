using Microsoft.EntityFrameworkCore;

namespace DotNet8.Client.Features.Blog.Update
{
    public class DL_BlogUpdate
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public DL_BlogUpdate(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task BlogUpdate(BlogUpdateModel model)
        {
            try
            {
                await _publishEndpoint.Publish(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
