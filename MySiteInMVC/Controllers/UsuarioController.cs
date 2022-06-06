using Microsoft.AspNetCore.Mvc;

namespace MySiteInMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
