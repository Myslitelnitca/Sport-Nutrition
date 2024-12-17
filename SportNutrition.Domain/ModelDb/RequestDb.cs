using SportNutrition.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb;

[Table("request")]
public class RequestDb
{
    [Column("id")]
    public Guid Id { get; set; }
        
    [Column("id_user")]
    public Guid Id_user { get; set; }
        
    [Column("description")]
    public string Description { get; set; }
        
    [Column("path_img")]
    public string Path_img { get; set; }
        
    [Column("status")]
    public int Status { get; set; }
        
    [Column("createdAt", TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }
}