using PaqueteTuristico.Entities;
using PaqueteTuristico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Persistence.Repositories
{

    public class AlimentacionRepository : Repository<Alimentacion>, IAlimentacionRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private AlimentacionRepository()
        {

        }

        public AlimentacionRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }



        public IEnumerable<Alimentacion> GetAlimentacionByCalificacionAlimentacion(CalificacionAlimentacion calificacionalimentacion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alimentacion> GetAlimentacionByCategoriaRestaurant(CategoriaRestaurant categoriarestaurant)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alimentacion> GetAlimentacionByDireccion(Direccion direccion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alimentacion> GetAlimentacionByTipoAlimentacion(TipoAlimentacion tipoalimentacion)
        {
            throw new NotImplementedException();
        }
    }
}
