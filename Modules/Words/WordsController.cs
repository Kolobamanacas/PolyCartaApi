using PolyCartaApi.Modules.Shared.Types;

namespace PolyCartaApi.Modules.Words;

internal static class WordsController
{
    private const string ModulePath = "/api/v1/words";

    public static void MapWords(this IEndpointRouteBuilder app)
    {
        app.MapPost($"{ModulePath}/add", () =>
        {
            return ApiResponse.Ok("Payload example.");
        });
    }
}
