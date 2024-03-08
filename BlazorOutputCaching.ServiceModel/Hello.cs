using ServiceStack;

namespace BlazorOutputCaching.ServiceModel;

[Route("/hello/{Name}")]
public class Hello : IGet, IReturn<HelloResponse>
{
    public required string Name { get; set; }
}

public class HelloResponse
{
    public required string Result { get; set; }
}