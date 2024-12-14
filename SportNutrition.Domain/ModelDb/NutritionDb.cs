using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb;

[Table("Nutrition")]
public class NutritionDb
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("idCategories")]
    public Guid IdCategories { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("cost", TypeName = "numeric")]
    public decimal Cost { get; set; }

    [Column("idImg")]
    public Guid IdImg { get; set; }

    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
}