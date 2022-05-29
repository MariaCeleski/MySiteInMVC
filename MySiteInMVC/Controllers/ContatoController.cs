using Microsoft.AspNetCore.Mvc;
using MySiteInMVC.Models;
using MySiteInMVC.Repository;

namespace MySiteInMVC.Controllers
{
    
    public class ContatoController : Controller

    {
        private readonly IContatoRepository _ContatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _ContatoRepository = contatoRepository;
        }
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
            _ContatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
