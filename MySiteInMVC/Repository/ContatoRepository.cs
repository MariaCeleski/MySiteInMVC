using MySiteInMVC.Data;
using MySiteInMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace MySiteInMVC.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        private object _context;

        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        ContatoModel ListarPorId(int id)
        {
            return _context.Contatos

        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
           _bancoContext.Contatos.Add(contato);
           _bancoContext.SaveChanges();
             
            return contato;

        }

        
    }
}
