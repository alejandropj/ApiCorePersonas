using ApiCorePersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorePersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;

        public PersonasController()
        {
            this.personas = new List<Persona>();
            Persona p = new Persona
            {
                IdPersona = 1,
                Nombre = "Alumno",
                Email = "alumno@mail.com",
                Edad = 22
            };
            this.personas.Add(p);
            p = new Persona
            {
                IdPersona = 1,
                Nombre = "Lucia",
                Email = "alumnoo@mail.com",
                Edad = 22
            };
            this.personas.Add(p);
            p = new Persona
            {
                IdPersona = 1,
                Nombre = "Annie",
                Email = "annie@mail.com",
                Edad = 28
            };
            this.personas.Add(p);
            p = new Persona
            {
                IdPersona = 1,
                Nombre = "Pedro",
                Email = "pedrito@mail.com",
                Edad = 89
            };
            this.personas.Add(p);
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }        
        [HttpGet]
        public ActionResult<Persona> FindPersona(int id)
        {
            return this.personas.FirstOrDefault(x=>x.IdPersona == id);
        }
    }
}
