using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class PaqueteRepository : Repository<Paquete>, IPaqueteRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private PaqueteRepository()
        {

        }

        public PaqueteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Paquete> GetPaqueteByTransporte(Transporte transporte)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paquete> GetPaqueteByAlimentacion(Alimentacion alimentacion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paquete> GetPaqueteByHospedaje(Hospedaje hospedaje)
        {
            throw new NotImplementedException();
        }
    }
}
