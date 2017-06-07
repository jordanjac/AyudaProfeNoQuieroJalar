using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class CategoriaHospedajeRepository : Repository<CategoriaHospedaje>, ICategoriaHospedajeRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private CategoriaHospedajeRepository()
        {

        }

        public CategoriaHospedajeRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
