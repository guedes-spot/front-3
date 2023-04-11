using Teste.Domain.Interfaces.Services;

namespace Teste.Application.GetHelloWorld;

public class GetHelloWorldHandler : IRequestHandler<GetHelloWorldCommand, GetHelloWorldResult>
{
    private readonly ILogger<GetHelloWorldHandler> _logger;
    private readonly IMapper _mapper;
    private readonly IHelloWorldService _helloWorldService;


    public GetHelloWorldHandler(ILogger<GetHelloWorldHandler> logger,
                                    IMapper mapper,
                                    IHelloWorldService helloWorldService)
    {
        _logger = logger;
        _mapper = mapper;
        _helloWorldService = helloWorldService;
    }

    public async Task<GetHelloWorldResult> Handle(GetHelloWorldCommand request, CancellationToken cancellationToken)
    {
        _logger.LogDebug("Init Handle");

        var response = await Task.FromResult(_helloWorldService.GetByUserName(request.UserName));
        return _mapper.Map<GetHelloWorldResult>(response);
    }
}