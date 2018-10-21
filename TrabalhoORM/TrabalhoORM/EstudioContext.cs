using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoORM
{
    public class EstudioContext : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Atuacao> Atuacoes { get; set; }
        public DbSet<DirecaoFilme> Direcoes { get; set; }
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Documentario> Documentarios { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<LongaMetragem> Longas { get; set; }
        public DbSet<ProducaoFilme> Producoes { get; set; }
        public DbSet<Produtor> Produtores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TrabalhoORM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
