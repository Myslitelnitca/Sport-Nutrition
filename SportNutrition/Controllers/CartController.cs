using Microsoft.AspNetCore.Mvc;
using SportNutrition.Domain.ViewModels;

namespace SportNutrition.Controllers;

public class CartController : Controller
{
    public IActionResult Cartss()
    {
        List<CatalogViewModel> g = new List<CatalogViewModel>();
        g.Add(new CatalogViewModel()
        {
            Name = "test",
            Description = "test",
            Image = "/catalog/test.jpg"
        });
        
        g.Add(new CatalogViewModel()
        {
            Name = "test2",
            Description = "test2",
            Image = "/catalog/test2.jpg"
        });
        
        return View();
    }
}