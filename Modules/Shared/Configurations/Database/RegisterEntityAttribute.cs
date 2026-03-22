namespace PolyCartaApi.Modules.Shared.Configurations.Database;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class DataBaseTableAttribute(string tableName) : Attribute
{
    public string TableName { get; } = tableName;
}
