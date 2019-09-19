using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Persistence
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options): base(options) { }


        public DbSet<Condominio> Condominio { get; set; }
    }
}
