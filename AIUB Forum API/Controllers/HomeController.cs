﻿using System.Collections.Generic;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Home/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
