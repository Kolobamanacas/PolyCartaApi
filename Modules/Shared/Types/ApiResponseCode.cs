using System.Text.Json.Serialization;

namespace modules.Shared.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ApiResponseCode
{
    Ok,
    BadRequest,
}
