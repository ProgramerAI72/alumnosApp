using AlumnosApi.Modelos;
using AlumnosApi.Repository;
using AlumnosApi.Controllers;

namespace AlumnosApi.Business
{
    public class TrabajoBusiness
    {
        TrabajoRepository trabajoRepository = new  TrabajoRepository();

        public Trabajo ObtenerTrabajo(int id)
        {
            var trabajo = new Trabajo();

            trabajo.Entrega = "Argentina";

            return trabajo;
        }

        public List<Trabajo> ObtenerTrabajos()
        {
            var lista = new List<Trabajo>();



            lista = trabajoRepository.ObtenerTrabajos();

            return lista;
        }

        public void CrearTrabajo(Trabajo trabajo)
        {

            trabajoRepository.CrearTrabajo(trabajo);
        }

        public void EliminarTrabajo(int id)
        {
            trabajoRepository.EliminarTrabajo(id);
        }
        public void ActualizarTrabajo(Trabajo trabajo)
        {
            trabajoRepository.ActualizarTrabajo(trabajo);
        }

    }
}
