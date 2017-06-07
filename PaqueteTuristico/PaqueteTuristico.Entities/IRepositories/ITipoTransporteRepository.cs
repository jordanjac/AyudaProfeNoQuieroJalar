using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface ITipoTransporteRepository : IRepository<TipoTransporte>
    {
        IEnumerable<TipoTransporte> GetTipoTransporteByCategoriaTransporte(CategoriaTransporte categoriatransporte);
        IEnumerable<TipoTransporte> GetTipoTransporteByMarcaTransporte(MarcaTransporte marcatransporte);

    }
}
