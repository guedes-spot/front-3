using Teste.Infrastructure.Services;

namespace Teste.Infrastructure.UnitTests.Services;

public class HelloWorldServiceTests
{
    private readonly HelloWorldService _helloWorldService;

    public HelloWorldServiceTests()
    {
        _helloWorldService = new HelloWorldService(default);
    }

    [Fact]
    public async Task Should_Create_Returns_Ok()
    {
        //arrange
        string userName = "test";
        int userLevel = (int)UserLevel.Admin;

        //act
        var result = await _helloWorldService.Create(userName, userLevel);
        //assert
        Assert.IsType<Guid>(result.UserId);
    }
}