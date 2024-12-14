using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb;

[Table("order")]
public class OrderDb
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("idUser")]
    public Guid IdUser { get; set; }

    [Column("idProduct")]
    public Guid IdProduct { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("cost", TypeName = "numeric")]
    public decimal Cost { get; set; }

    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
}
