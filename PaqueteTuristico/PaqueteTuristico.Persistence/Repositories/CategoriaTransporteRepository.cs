using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class CategoriaTransporteRepository : Repository<CategoriaTransporte>, ICategoriaTransporteRepository
    {

        private readonly PaqueteTuristicoDbContext _Context;

        private CategoriaTransporteRepository()
        {

        }

        public CategoriaTransporteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }

    }
}
