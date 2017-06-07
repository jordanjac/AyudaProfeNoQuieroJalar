using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class DireccionRepository : Repository<Direccion>, IDireccionRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private DireccionRepository()
        {

        }

        public DireccionRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
