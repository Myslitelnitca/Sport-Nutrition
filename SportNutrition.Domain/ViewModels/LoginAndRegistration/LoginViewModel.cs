using System.ComponentModel.DataAnnotations;

namespace SportNutrition.Domain.ViewModels.LoginAndRegistration;

public class LoginViewModel
{
    [Required(ErrorMessage = "Введите почту")]
    [EmailAddress(ErrorMessage = "Некорректный адрес электронной почты")]
    
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Введите пароль")]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    
    public string Password { get; set; }
}