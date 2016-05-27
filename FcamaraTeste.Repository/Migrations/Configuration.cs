namespace FcamaraTeste.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FcamaraTeste.Repository.EF.ProdutoContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FcamaraTeste.Repository.EF.ProdutoContexto context)
        {

            context.Produtos.AddOrUpdate(p => p.NM_Produto, new Domain.Entidades.Produto { NM_Produto = "Produto 1", DS_Produto = "Produto 1", VL_Unitario = decimal.Parse("1,10") },
                                                          new Domain.Entidades.Produto
                                                          {
                                                              NM_Produto = "Produto 2",
                                                              DS_Produto = "Produto 2",
                                                              VL_Unitario = decimal.Parse("1,20")
                                                          },
                                                          new Domain.Entidades.Produto { NM_Produto = "Produto 3", DS_Produto = "Produto 3", VL_Unitario = decimal.Parse("1,10") },
                                                          new Domain.Entidades.Produto { NM_Produto = "Produto 4", DS_Produto = "Produto 4", VL_Unitario = decimal.Parse("6,10") },
                                                          new Domain.Entidades.Produto { NM_Produto = "Produto 5", DS_Produto = "Produto 4", VL_Unitario = decimal.Parse("8,10") });

            ////
            ////    context.People.AddOrUpdate(
            ////      p => p.FullName,
            ////      new Person { FullName = "Andrew Peters" },
            ////      new Person { FullName = "Brice Lambson" },
            ////      new Person { FullName = "Rowan Miller" }
            ////    );
            ////
        }
    }
}
