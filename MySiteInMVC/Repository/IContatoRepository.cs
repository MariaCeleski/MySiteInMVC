using MySiteInMVC.Models;

namespace MySiteInMVC.Repository
{
    public interface IContatoRepository 
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
