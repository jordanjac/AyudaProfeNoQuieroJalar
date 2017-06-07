using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface IAlimentacionRepository : IRepository<Alimentacion>
    {
        IEnumerable<Alimentacion> GetAlimentacionByTipoAlimentacion(TipoAlimentacion tipoalimentacion);
        IEnumerable<Alimentacion> GetAlimentacionByCategoriaRestaurant(CategoriaRestaurant categoriarestaurant);
        IEnumerable<Alimentacion> GetAlimentacionByCalificacionAlimentacion(CalificacionAlimentacion calificacionalimentacion);
        IEnumerable<Alimentacion> GetAlimentacionByDireccion(Direccion direccion);

    }
}
