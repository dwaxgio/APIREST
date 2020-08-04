using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIREST.Controllers
{
    // Valores de muestra para los metodos de HTTP
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Models.Juegos> Get()
        {
            // 1. Agregar modelo para mapearlo con entity framework
            // 2. Agregar controlador (se puede usar el que se construye automaticamente cuando se genera el proyecto
            // 2.2 Se emplea el contexto ya creado por Entity Framework

            IEnumerable<Models.Juegos> lst;
            using(Models.ApiRestDBEntities db = new Models.ApiRestDBEntities())
            {
                lst = db.Juegos.ToList(); // Para retornar todos los valores de la tabla elejida
            }

            return lst;
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
