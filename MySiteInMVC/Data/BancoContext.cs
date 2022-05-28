﻿using Microsoft.EntityFrameworkCore;
using MySiteInMVC.Models;

namespace MySiteInMVC.Data
{
    public class BancoContext :DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
