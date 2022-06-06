using Microsoft.AspNetCore.Mvc;
using MySiteInMVC.Models;
using MySiteInMVC.Repository;
using System.Collections.Generic;

namespace MySiteInMVC.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepository.BuscarTodos();

            return View(usuarios);
        }

    }
}
