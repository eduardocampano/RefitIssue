using ComposerContract;
using Refit;

namespace RandomUser;

public class RandomUserComposer : IComposer
{
    public async Task<string> Compose()
    {
        var nameGeneratorClient = RestService.For<INameGeneratorClient>("https://randomuser.me");
        // ^--- this line throws when

        var result = await nameGeneratorClient.Generate();
        return $"{result.Results[0].Name.First} {result.Results[0].Name.Last}";
    }
}