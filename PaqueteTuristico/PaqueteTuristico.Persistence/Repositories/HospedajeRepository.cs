using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class HospedajeRepository : Repository<Hospedaje>, IHospedajeRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private HospedajeRepository()
        {

        }

        public HospedajeRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Hospedaje> GetHospedajeByDireccion(Direccion direccion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospedaje> GetHospedajeByServicioHospedaje(ServicioHospedaje serviciohospedaje)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospedaje> GetHospedajeByCalificacionHospedaje(CalificacionHospedaje calificacionhospedaje)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospedaje> GetHospedajeByCategoriaHospedaje(CategoriaHospedaje categoriahospedaje)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospedaje> GetHospedajeByTipoHospedaje(TipoHospedaje tipohospedaje)
        {
            throw new NotImplementedException();
        }
    }
}
