using dotNetParadise_SourceLink.MinimalApis.Abstractions;
using dotNetParadise_SourceLink.MinimalApis.Extensions;

namespace SourceLink_Debug.EndPoints;

public class TodoApi : IEndPoint
{
    public void MapEndPoints(IEndpointRouteBuilder app)
    {
        var group = app.MapGroupWithTags("Todo");
        group.MapGet("sayhello", (string name) => $"hello {name}");
    }
}
