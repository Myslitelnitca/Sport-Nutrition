using SportNutrition.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb
{
    [Table("user")]
    public class UserDb
    {
        [Column("id")]
        public Guid Id { get; set; }
        
        [Column("login")]
        public string Login { get; set; }
        
        [Column("password")]
        public string Password { get; set; }
        
        [Column("email")]
        public string Email { get; set; }
        
        [Column("role")]
        public Role Role { get; set; }
        
        [Column("pathimage")]
        public string PathImaage { get; set; }
        
        [Column("createdAt", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; }
    }
}