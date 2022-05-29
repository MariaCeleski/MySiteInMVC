﻿using MySiteInMVC.Data;
using MySiteInMVC.Models;

namespace MySiteInMVC.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        
        public ContatoModel Adicionar(ContatoModel contato)
        {
           _bancoContext.Contatos.Add(contato);
           _bancoContext.SaveChanges();
             
            return contato;

        }
    }
}