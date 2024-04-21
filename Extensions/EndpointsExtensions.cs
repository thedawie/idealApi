
namespace IdealRepositoryBase.Extensions;

public static class EndpointsExtensions
{
    public static void RegisterEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/", SayHello);
    }
    
    internal static IResult SayHello () => Results.Ok("Helllo");
}
