using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface ITransporteRepository : IRepository<Transporte>
    {
        IEnumerable<Transporte> GetTransporteByTipoTransporte(TipoTransporte tipotransporte);
        IEnumerable<Transporte> GetTransporteByMarcaTransporte(MarcaTransporte marcatransporte);
        IEnumerable<Transporte> GetTransporteByEstadoTransporte(EstadoTransporte estadotransporte);
    }
}
