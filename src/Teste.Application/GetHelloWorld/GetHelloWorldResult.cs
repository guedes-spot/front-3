using Teste.Application.Common.Mappings;

namespace Teste.Application.GetHelloWorld;

public class GetHelloWorldResult : IMapFrom<HelloWorldResponse>
{
    public Guid Id { get; set; }
    public string UserName { get; set; } = default!;
    public UserLevel Level { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<HelloWorldResponse, GetHelloWorldResult>()
            .ForMember(d => d.Level, opt => opt.MapFrom(s => (UserLevel)s.Level))
            .ForMember(d => d.Id, opt => opt.MapFrom(s => s.UserId));
    }
}