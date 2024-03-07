using Microsoft.EntityFrameworkCore;

namespace DotNet8.Client.Features.Blog.Delete
{
    public class DL_BlogDelete
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public DL_BlogDelete(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task BlogDelete(BlogDeleteModel model)
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
