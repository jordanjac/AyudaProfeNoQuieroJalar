using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class ServicioHospedajeRepository : Repository<ServicioHospedaje>, IServicioHospedajeRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private ServicioHospedajeRepository()
        {

        }

        public ServicioHospedajeRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}

