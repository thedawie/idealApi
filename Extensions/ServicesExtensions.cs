using Microsoft.OpenApi.Models;

namespace IdealRepositoryBase.Extensions;

public static class ServicesExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo() { Title = "SimpleApi", Version = "v1" });
        });
    }
}
