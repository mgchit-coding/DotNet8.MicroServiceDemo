namespace DotNet8.Client.Features.Blog.Create
{
    public class DL_BlogCreate
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public DL_BlogCreate(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task BlogCreate(BlogCreateModel model)
        {
            try
            {
                await _publishEndpoint.Publish(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
