using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
   public class TipoTransporteRepository : Repository<TipoTransporte>, ITipoTransporteRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private TipoTransporteRepository()
        {

        }

        public TipoTransporteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<TipoTransporte> GetTipoTransporteByCategoriaTransporte(CategoriaTransporte categoriatransporte)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoTransporte> GetTipoTransporteByMarcaTransporte(MarcaTransporte marcatransporte)
        {
            throw new NotImplementedException();
        }
    }
}
