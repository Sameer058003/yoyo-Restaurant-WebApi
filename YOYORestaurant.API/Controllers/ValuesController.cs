using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YOYORestaurant.API.Data;
using YOYORestaurant.API.Models;

namespace YOYORestaurant.API.Controllers
{
    public class ValuesController : ApiController
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET api/values
        public List<Customer> GetCustomerList()
        {
          return  context.Customers.ToList();

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
