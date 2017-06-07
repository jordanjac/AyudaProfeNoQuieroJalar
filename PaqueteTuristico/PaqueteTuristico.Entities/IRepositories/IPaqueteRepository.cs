using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface IPaqueteRepository : IRepository<Paquete>
    {
        IEnumerable<Paquete> GetPaqueteByTransporte(Transporte transporte);
        IEnumerable<Paquete> GetPaqueteByAlimentacion(Alimentacion alimentacion);
        IEnumerable<Paquete> GetPaqueteByHospedaje(Hospedaje hospedaje);
    }
}
