using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class TipoAlimentacionRepository : Repository<TipoAlimentacion>, ITipoAlimentacionRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private TipoAlimentacionRepository()
        {

        }

        public TipoAlimentacionRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
