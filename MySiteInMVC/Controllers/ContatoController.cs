using Microsoft.AspNetCore.Mvc;
using MySiteInMVC.Models;

namespace MySiteInMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Criar()
        {

            return View();
        }

        public IActionResult Editar()
        {

            return View();
        }

        public IActionResult ApagarConfirmacao()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            return View(contato);
        }

    }
}
