using Microsoft.AspNetCore.Mvc;
using RepositorioTurnos.Models;
using RepositorioTurnos.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase



    {
        private readonly IServicioService _servicioService;

        public ServiciosController(IServicioService servicioService)
        {
            _servicioService = servicioService;
        }


        // GET: api/<ServiciosController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            { 
                return Ok(_servicioService.ObtenerServicio());
            }
            catch (Exception) 
            {
                return StatusCode(500, "Ha ocurrido un error");
            }
        }

        [HttpGet("ByName/{name}")]

        public IActionResult GetByName(string name) 
        {
            return Ok(_servicioService.GetByName(name));
        }


        //// GET api/<ServiciosController>/5
        [HttpGet("ById/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_servicioService.GetByID(id));
        }

        //// POST api/<ServiciosController> 
        [HttpPost]
        public IActionResult Post([FromBody] TServicio servicio)
        {
            try
            {
                if (IsValid(servicio))
                {
                    _servicioService.registarServicio(servicio);
                    return Ok("Servicio Insertado");
                }
                else
                {
                    return BadRequest("El servicio no es valido o incompleto");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Ha ocurrido un error");
            }

        }

        private bool IsValid(TServicio servicio)
        {
            return servicio.Id != 0 && !string.IsNullOrEmpty(servicio.Nombre) && servicio.Costo != 0 && !string.IsNullOrEmpty(servicio.EnPromocion); 
        }

        //// PUT api/<ServiciosController>/5
        [HttpPut]
        public IActionResult Put([FromBody]TServicio servicio)
        {
            var servicioUpdate = _servicioService.GetByID(servicio.Id);

            if (servicioUpdate != null)
            {
                servicioUpdate.Nombre = servicio.Nombre;
                servicioUpdate.EnPromocion = servicio.EnPromocion;
                servicioUpdate.Costo = servicio.Costo;

                _servicioService.editarServicio(servicioUpdate);

                return Ok("Servicio Actualizado Correctamente");
            }
            else
            {
                return BadRequest("No se pudo actualizar el servicio");
            }

        }

        // DELETE api/<ServiciosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            try
            {
                _servicioService.eliminarServicio(id);
                return Ok("Servicio Eliminado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Ha ocurrido un error");
            }


        }
    }
}
