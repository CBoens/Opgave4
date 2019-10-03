using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Opgave4REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BogController : ControllerBase
    {

        private static List<Bog> list = new List<Bog>()
        {
            new Bog("Departemantet", "Idrissa Elba", 456, "1234567890123"),
            new Bog("Mars' Geologi", "Vail Corona", 667, "1234567890124"),
            new Bog("Zappas ministerium", "Enoca Surbina", 234, "1234567890125"),
            new Bog("El Coronel Porro", "Jela Duarte Quintero", 750, "1234567890126"),
            new Bog("Klodernes Kamp", "H.G. Wells", 326, "1234567890127"),
            new Bog("1q84", "Haruki Murakami", 989, "1234567890128"),
            new Bog("Tosser", "landsby tossen", 657, "1234567890122")

        };


        // GET: api/Bog
        [HttpGet]
        public IEnumerable<Bog> Get()
        {
            return list;
        }

        // GET: api/Bog/5
        [HttpGet("{id}", Name = "Get")]
        public Bog Get(string id)
        {
            return list.Find(b=> b.ISBN13 == id);
        }

        // POST: api/Bog
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
            list.Add(value);
        }

        // PUT: api/Bog/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Bog value)
        {
            Bog bog = Get(id);
            if (bog != null)
            {
                bog.Titel = value.Titel;
                bog.Forfatter = value.Forfatter;
                bog.Sidetal = value.Sidetal;
                bog.ISBN13 = value.ISBN13;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string Isbn13id)
        {
            Bog bog = Get(Isbn13id);
            if (bog != null)
            {
                list.Remove(bog);
            }
        }
    }
}
