namespace Teste.Domain.Interfaces.Services;

public interface IHelloWorldService
{
    Task<HelloWorldResponse> Create(string userName, int userLevel);
    HelloWorldResponse? GetByUserName(string userName);
}