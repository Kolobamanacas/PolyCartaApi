namespace modules.Shared.Types;

public class ApiResponsePayload<DataType>()
{
    public ApiResponseCode Code { get; set; }
    public string? Message { get; set; }
    public DataType? Data { get; set; }
}

public static class ApiResponse
{
    public static IResult Ok<DataType>(DataType? data)
    {
        return Results.Ok(new ApiResponsePayload<DataType>
        {
            Code = ApiResponseCode.Ok,
            Data = data,
        });
    }
}
