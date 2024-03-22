using System.Reflection;
using dotNetParadise_SourceLink.MinimalApis.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace dotNetParadise_SourceLink.MinimalApis.Extensions;

public static class UseEndPointsExtensions
{
    public static WebApplication RegisterEndPoints(this WebApplication app)
    {
        var types = Assembly.GetEntryAssembly()?.GetTypes()?.Where(type => type.IsAssignableTo(typeof(IEndPoint)) && type is { IsAbstract: false, IsInterface: false });
        if (types?.Count() > 0)
        {
            foreach (var type in types)
            {
                var ep = ActivatorUtilities.CreateInstance(app.Services, type);
                (ep as IEndPoint)!.MapEndPoints(app);
        
            }
        }
        return app;
    }
}
