using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
