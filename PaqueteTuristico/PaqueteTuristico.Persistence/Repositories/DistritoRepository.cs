using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class DistritoRepository : Repository<Distrito>, IDistritoRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private DistritoRepository()
        {

        }

        public DistritoRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
