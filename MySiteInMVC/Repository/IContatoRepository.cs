using MySiteInMVC.Models;
using System.Collections.Generic;

namespace MySiteInMVC.Repository
{
    public interface IContatoRepository 
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
