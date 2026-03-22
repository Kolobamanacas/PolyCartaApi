using System.Text.Json.Serialization;

namespace PolyCartaApi.Modules.Shared.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ApiResponseCode
{
    Ok,
    BadRequest,
}
