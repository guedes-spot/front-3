using Teste.Domain.Interfaces.Services;
using Teste.Infrastructure.Persistence;
using Teste.Domain.Models;

namespace Teste.Infrastructure.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        private readonly ApplicationDbContext _context;

        public HelloWorldService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<HelloWorldResponse> Create(string userName, int userLevel)
        {
            await Add(userName, userLevel);
            await Task.Delay(2000);
            return new HelloWorldResponse
            {
                UserId = Guid.NewGuid(),
                Level = userLevel,
                UserName = userName
            };
        }

        public HelloWorldResponse? GetByUserName(string userName)
        {
            return _context.HelloWorld?.FirstOrDefault(p => p.UserName == userName);
        }

        private async Task<HelloWorldResponse> Add(string userName, int userLevel)
        {
            var response = new HelloWorldResponse
            {
                UserId = Guid.NewGuid(),
                Level = userLevel,
                UserName = userName
            };

            await _context.HelloWorld.AddAsync(response);
            await _context.SaveChangesAsync();

            return response;
        }
    }
}