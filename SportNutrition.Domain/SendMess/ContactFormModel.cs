using System.ComponentModel.DataAnnotations;
namespace SportNutrition.Domain.SendMess;

public class ContactFormModel
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(1000, MinimumLength = 10)]
    public string Messager { get; set; }
}