using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class MarcaTransporteRepository : Repository<MarcaTransporte>, IMarcaTransporteRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private MarcaTransporteRepository()
        {

        }

        public MarcaTransporteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
