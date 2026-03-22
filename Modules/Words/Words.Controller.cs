using modules.Shared.Types;

namespace PolyCartaApi.Modules.Words;

public static class WordsController
{
    private static readonly string ModulePath = "/api/v1/words";

    public static void MapWords(this IEndpointRouteBuilder app)
    {
        app.MapPost($"{ModulePath}/add", () =>
        {
            return ApiResponse.Ok("Payload example.");
        });
    }
}
