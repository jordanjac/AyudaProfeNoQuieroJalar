using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class ModeloTransporteRepository : Repository<ModeloTransporte>, IModeloTransporteRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private ModeloTransporteRepository()
        {

        }

        public ModeloTransporteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
