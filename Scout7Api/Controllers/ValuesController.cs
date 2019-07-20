using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;



namespace Scout7Api.Controllers
{
    using System.Web;
    using Microsoft.AspNetCore.Mvc;
    using System.IO;
    using Newtonsoft.Json;
    using System.Net.Http;
    using Scout7Api.Model;
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private string fileName = "players.json";
        private readonly string _env;
        //public static IConfiguration Configuration { get; set; }

        // GET api/values
        [HttpGet]
        public string GetPlayers()
        {
            List<Player> player = new List<Player>();
            var lines = "";
            string _env = Environment.CurrentDirectory;
            
            string path = Path.Combine(_env, @"App_Data\", fileName);

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                lines = json;
            }

            return lines;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
