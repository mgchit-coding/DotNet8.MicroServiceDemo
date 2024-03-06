using DotNet8.Client.Models;
using DotNet8.Server.Services;
using MassTransit;

namespace DotNet8.Server.Features.Consumers
{
    public class BlogCreate : IConsumer<BlogCreateModel>
    {
        private readonly AppDbContext _appDbContext;

        public BlogCreate(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task Consume(ConsumeContext<BlogCreateModel> context)
        {
            var model = context.Message;
            return Task.CompletedTask;
        }
    }
}
