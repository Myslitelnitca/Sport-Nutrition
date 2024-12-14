using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb;


[Table("photo")]
public class PicturesSportDb
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("idProduct")]
    public Guid IdProduct { get; set; }

    [Column("pathImg")]
    public string PathImg { get; set; }
}
