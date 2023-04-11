namespace Teste.Application.GetHelloWorld;

public class GetHelloWorldCommand : IRequest<GetHelloWorldResult>
{
    public string UserName { get; set; } = default!;
}