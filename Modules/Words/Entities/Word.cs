using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PolyCartaApi.Modules.Shared.Configurations.Database;

namespace PolyCartaApi.Modules.Words.Entities;

[DataBaseTable("words")]
internal sealed class Word
{
    [Column("id")]
    public long Id { get; set; }

    [Column("value"), MaxLength(200)]
    public required string Value { get; set; }

    // [Column("type"), MaxLength(20)]
    // public required string Type { get; set; }
}
