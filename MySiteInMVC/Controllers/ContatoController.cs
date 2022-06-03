using Microsoft.AspNetCore.Mvc;
using MySiteInMVC.Models;
using MySiteInMVC.Repository;
using System.Collections.Generic;

namespace MySiteInMVC.Controllers
{
    
    public class ContatoController : Controller

    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.BuscarTodos();
                
            return View(contatos);
        }

        public IActionResult Criar()
        {

            return View();
        }

        public IActionResult Editar(int Id)
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
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
