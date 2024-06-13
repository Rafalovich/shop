using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using shop;

namespace WebApi.controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public List<Product> Get()
        {

            return Product.GetAll();
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return Product.GetById(id);
        }

        // POST: api/Product
        public void Post([FromBody]Product value)
        {
            value.Pid = -1;
            value.Save();
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]Product value)
        {
            value.Pid = id;
            value.Save();
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            Product.DeleteById(id);
        }
    }
}
