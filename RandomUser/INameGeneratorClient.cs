using Refit;

namespace RandomUser;

public interface INameGeneratorClient
{
    [Get("/api")]
    Task<GenerateResponse> Generate();
}

public record GenerateResponse(Person[] Results);
public record Person(string Gender, PersonName Name);
public record PersonName(string Title, string First, string Last);