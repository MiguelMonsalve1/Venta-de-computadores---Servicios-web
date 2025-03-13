using ServicioREST.Clases;
using ServicioREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicios_Jue.Controllers
{
    [RoutePrefix("api/Computadores")]
    public class ComputadoresController : ApiController
    {
     
        [HttpGet] 
        [Route("ConsultarTodos")] 
        public List<Computador> ConsultarTodos()
        {
           
            Computadores computador = new Computadores();
            return computador.ConsultarTodos();
        }
        
        [HttpGet]
        [Route("ConsultarXID")]
        public Computador ConsultarXID(int id)
        {

            Computadores computador = new Computadores();
            return computador.Consultar(id); 
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Computador computador)
        {
  
            Computadores COMPUTADOR = new Computadores();

            COMPUTADOR.computador = computador;
           
            return COMPUTADOR.Ingresar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Computador computador)
        {
            Computadores COMPUTADOR = new Computadores();

            COMPUTADOR.computador = computador;

            return COMPUTADOR.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Computador computador)
        {
            Computadores COMPUTADOR = new Computadores();

            COMPUTADOR.computador = computador;

            return COMPUTADOR.Eliminar();
        }

    }
}