using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class TipoHospedajeRepository : Repository<TipoHospedaje>, ITipoHospedajeRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private TipoHospedajeRepository()
        {

        }

        public TipoHospedajeRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
