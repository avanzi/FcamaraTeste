using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FcamaraTeste.Domain.Entidades;
using FcamaraTeste.Repository;

namespace FcamaraTeste.Services.Controllers
{
    public class ProdutoController : ApiController
    {
        // GET: api/Produto
        public List<Produto> Get()
        {
            var teste = new ProdutoRepository().GetAll().ToList();
            return teste;
        }

        // GET: api/Produto/5
        public Produto Get(int id)
        {
            return new ProdutoRepository().FindBy(e => e.ID_Produto == id).FirstOrDefault();
        }

        // POST: api/Produto
        public void Post([FromBody] Produto _produto)
        {
            var _rep = new ProdutoRepository();
            _rep.Add(_produto);
            _rep.Save();
        }

        // PUT: api/Produto/5
        public void Put([FromBody] Produto _produto)
        {
            var _rep = new ProdutoRepository();
            _rep.Edit(_produto);
            _rep.Save();
        }

        // DELETE: api/Produto/5
        public void Delete(int id)
        {
            Produto _produto = new ProdutoRepository().FindBy(e => e.ID_Produto == id).FirstOrDefault();
            new ProdutoRepository().Remove(_produto);
        }
    }
}
