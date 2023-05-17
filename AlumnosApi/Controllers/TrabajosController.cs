using AlumnosApi.Business;
using AlumnosApi.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace AlumnosApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TrabajosController : Controller
    {



        [HttpGet]
        public List<Trabajo> Trabajo()
        {
            var business = new TrabajoBusiness();

            var misTrabajos = business.ObtenerTrabajos();

            return misTrabajos;
        }

        [HttpGet("{id}")]
        public Trabajo Trabajos(int id)
        {
            var business = new TrabajoBusiness();

            var misTrabajos = business.ObtenerTrabajos();

            var trabajo = misTrabajos.Where(x => x.Id == id).FirstOrDefault();

            return trabajo;
        }

        [HttpPost]
        public void CrearTrabajo(Trabajo trabajo)
        {
            var business = new TrabajoBusiness();

            business.CrearTrabajo(trabajo);


        }

        [HttpDelete("{id}")]
        public void EliminarTrabajo(int id)
        {
            var business = new TrabajoBusiness();

            business.EliminarTrabajo(id);


        }

        [HttpPut]
        public void ActualizarTrabajo(Trabajo trabajo)
        {
            var business = new TrabajoBusiness();

            business.ActualizarTrabajo(trabajo);


        }
    }   
}
