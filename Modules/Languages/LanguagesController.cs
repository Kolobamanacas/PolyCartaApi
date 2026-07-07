using PolyCartaApi.Modules.Shared.Configurations.Routing;
using PolyCartaApi.Modules.Shared.Types;

namespace PolyCartaApi.Modules.Languages;

[Controller]
internal static class LanguagesController
{
    private const string ModulePath = "/api/v1/languages";

    public static void MapLanguages(this IEndpointRouteBuilder app)
    {
        app.MapPost($"{ModulePath}/add", () =>
        {
            return ApiResponse.Ok("Payload example.");
        });
    }
}
