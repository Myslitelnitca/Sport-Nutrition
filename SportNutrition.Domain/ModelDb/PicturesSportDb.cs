namespace SportNutrition.Domain.ModelDb;
using SportNutrition.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

[Table("request")]
public class PicturesSportDb
{
    [Column("id")]
    public Guid Id { get; set; }
        
    [Column("id_sport")]
    public Guid Id_sport { get; set; }
        
    [Column("description")]
    public string Description { get; set; }
        
    [Column("path_img")]
    public string Path_img { get; set; }
        
    [Column("status")]
    public int Status { get; set; }
        
    [Column("createdAt", TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }
}