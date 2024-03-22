using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace dotNetParadise_SourceLink.MinimalApis.Extensions;

public static class IEndpointRouteBuilderExtensions
{
    /// <summary>
    /// 接口路由分组
    /// </summary>
    /// <param name="endpointRouteBuilder"></param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    public static RouteGroupBuilder MapGroupWithTags(this IEndpointRouteBuilder endpointRouteBuilder, string prefix)
    {
        return endpointRouteBuilder.MapGroup(prefix).WithTags(prefix);
    }
}
