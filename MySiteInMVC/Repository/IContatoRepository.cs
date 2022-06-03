using MySiteInMVC.Models;
using System.Collections.Generic;

namespace MySiteInMVC.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel BuscarPorID(int id);
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
