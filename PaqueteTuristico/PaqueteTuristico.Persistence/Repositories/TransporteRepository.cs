using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private TransporteRepository()
        {

        }

        public TransporteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Transporte> GetTransporteByTipoTransporte(TipoTransporte tipotransporte)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> GetTransporteByMarcaTransporte(MarcaTransporte marcatransporte)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> GetTransporteByEstadoTransporte(EstadoTransporte estadotransporte)
        {
            throw new NotImplementedException();
        }
    }
}
