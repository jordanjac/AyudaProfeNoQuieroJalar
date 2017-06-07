using PaqueteTuristico.Entities;
using PaqueteTuristico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class CalificacionAlimentacionRepository : Repository<CalificacionAlimentacion>, ICalificacionAlimentacionRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private CalificacionAlimentacionRepository()
        {

        }

        public CalificacionAlimentacionRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }


    }
}
