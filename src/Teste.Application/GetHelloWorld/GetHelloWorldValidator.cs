namespace Teste.Application.GetHelloWorld;

public class GetHelloWorldValidator : AbstractValidator<GetHelloWorldCommand>
{
    public GetHelloWorldValidator()
    {
        RuleFor(command => command.UserName)
        .NotNull()
        .NotEmpty();
    }
}