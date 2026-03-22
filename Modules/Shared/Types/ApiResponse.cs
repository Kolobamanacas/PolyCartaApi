namespace PolyCartaApi.Modules.Shared.Types;

internal static class ApiResponse
{
    public static IResult Ok<TResponse>(TResponse? data)
    {
        return Results.Ok(new ApiResponsePayload<TResponse>
        {
            Code = ApiResponseCode.Ok,
            Data = data,
        });
    }
}

internal sealed class ApiResponsePayload<TResponse>()
{
    public ApiResponseCode Code { get; set; }
    public string? Message { get; set; }
    public TResponse? Data { get; set; }
}
