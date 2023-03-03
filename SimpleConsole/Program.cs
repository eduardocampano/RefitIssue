using RandomUser;
using Refit;

var nameGeneratorClient = RestService.For<INameGeneratorClient>("https://randomuser.me");
var result = await nameGeneratorClient.Generate();
Console.WriteLine($"{result.Results[0].Name.First} {result.Results[0].Name.Last}");