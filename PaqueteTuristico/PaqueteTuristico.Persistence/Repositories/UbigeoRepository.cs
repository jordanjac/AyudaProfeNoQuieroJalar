using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class UbigeoRepository:Repository<Ubigeo>, IUbigeoRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private UbigeoRepository()
        {

        }

        public UbigeoRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Ubigeo> GetUbigeoByDistrito(Distrito distrito)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ubigeo> GetUbigeoByProvincia(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ubigeo> GetUbigeoByDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}
