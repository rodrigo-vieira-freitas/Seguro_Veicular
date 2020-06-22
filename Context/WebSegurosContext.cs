using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSeguros.Models;

namespace WebSeguros.Context
{
    public class WebSegurosContext : DbContext
    {
        //public WebSegurosContext(DbContextOptions<WebSegurosContext> options)
        //    : base(options)
        //{
        //}

        //public DbSet<WebSeguros.Models.Cliente> Cliente { get; set; }


        //public DbSet<WebSeguros.Models.Carro> Carro { get; set; }

        //public DbSet<WebSeguros.Models.Calculo> Calculo { get; set; }

        //public DbSet<WebSeguros.Models.Localizar> Localizar { get; set; }

        public DbSet<Cliente>Cliente { get; set; }

        public DbSet<Carro> Carro { get; set; }

        public DbSet<Calculo> Calculo { get; set; }

        public DbSet<Localizar> Localizar { get; set; }
    }
}
