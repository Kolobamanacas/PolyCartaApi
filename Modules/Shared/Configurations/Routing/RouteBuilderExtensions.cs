using System.Reflection;

namespace PolyCartaApi.Modules.Shared.Configurations.Routing;

internal static class RouteBuilderExtensions
{
    public static void MapHttpControllers(this IEndpointRouteBuilder app)
    {
        var moduleTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetCustomAttribute<ControllerAttribute>() != null);

        foreach (var type in moduleTypes)
        {
            var mappingMethods = type
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(
                    m => m.GetParameters() is [var parameter]
                    && parameter.ParameterType == typeof(IEndpointRouteBuilder))
                .ToArray();

            if (mappingMethods.Length == 0)
            {
                throw new InvalidOperationException(
                    $"No endpoint mapping method found on {type.FullName}.");
            }

            foreach (var method in mappingMethods)
            {
                method.Invoke(null, [app]);
            }
        }
    }
}
