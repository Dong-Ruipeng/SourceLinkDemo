using Microsoft.AspNetCore.Routing;

namespace dotNetParadise_SourceLink.MinimalApis.Abstractions;

public interface IEndPoint
{
    void MapEndPoints(IEndpointRouteBuilder app);
}
