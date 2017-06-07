using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class CalificacionHospedajeRepository : Repository<CalificacionHospedaje>, ICalificacionHospedajeRepository
    {

        private readonly PaqueteTuristicoDbContext _Context;

        private CalificacionHospedajeRepository()
        {

        }

        public CalificacionHospedajeRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
