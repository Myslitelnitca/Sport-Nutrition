using Microsoft.AspNetCore.Mvc;
using SportNutrition.Domain.ViewModels;

namespace SportNutrition.Controllers;

public class ProfileController : Controller
{
    public IActionResult User()
    {
        return View();
    }
}