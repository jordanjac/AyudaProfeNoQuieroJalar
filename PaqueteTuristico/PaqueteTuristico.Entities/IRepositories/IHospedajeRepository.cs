using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface IHospedajeRepository : IRepository<Hospedaje>
    {
        IEnumerable<Hospedaje> GetHospedajeByDireccion(Direccion direccion);
        IEnumerable<Hospedaje> GetHospedajeByServicioHospedaje(ServicioHospedaje serviciohospedaje);
        IEnumerable<Hospedaje> GetHospedajeByCalificacionHospedaje(CalificacionHospedaje calificacionhospedaje);
        IEnumerable<Hospedaje> GetHospedajeByCategoriaHospedaje(CategoriaHospedaje categoriahospedaje);
        IEnumerable<Hospedaje> GetHospedajeByTipoHospedaje(TipoHospedaje tipohospedaje);
    }
}
