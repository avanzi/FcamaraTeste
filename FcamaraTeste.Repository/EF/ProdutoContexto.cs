using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FcamaraTeste.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;


namespace FcamaraTeste.Repository.EF
{
    public class ProdutoContexto : DbContext
    {
        public ProdutoContexto() : base("name=ProdutoContexto")
        {
            Database.SetInitializer<ProdutoContexto>(null);

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
