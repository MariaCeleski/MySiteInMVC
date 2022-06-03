using MySiteInMVC.Models;
using System.Collections.Generic;

namespace MySiteInMVC.Repository
{
    public interface IContatoRepository 
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
