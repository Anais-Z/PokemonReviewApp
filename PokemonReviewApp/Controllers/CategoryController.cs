using Microsoft.AspNetCore.Mvc;

namespace PokemonReviewApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
