using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb;

[Table("Category")]
public class CategoryDb
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("idImg")]
    public string IdImg { get; set; }

    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
}
