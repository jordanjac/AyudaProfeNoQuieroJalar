using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAlimentacionRepository Alimentaciones { get; }
        ICalificacionAlimentacionRepository CalificacionAlimentaciones { get; }
        ICalificacionHospedajeRepository CalificacionHospedajes { get; }
        ICategoriaHospedajeRepository CategoriaHospedajes { get; }
        ICategoriaRestaurantRepository CategoriaRestaurantes { get; }
        ICategoriaTransporteRepository CategoriaTransportes { get; }
        IDepartamentoRepository Departamentos { get; }
        IDireccionRepository Direcciones { get; }
        IDistritoRepository Distritos { get; }
        IEstadoTransporteRepository EstadoTransportes { get; }
        IHospedajeRepository Hospedajes { get; }
        IMarcaTransporteRepository MarcaTransportes { get; }
        IModeloTransporteRepository ModeloTransportes { get; }
        IPaqueteRepository Paquetes { get; }
        IProvinciaRepository Provincias { get; }
        IServicioHospedajeRepository ServicioHospedajes { get; }
        ITipoAlimentacionRepository TipoAlimentaciones { get; }
        ITipoHospedajeRepository TipoHospedajes { get; }
        ITipoTransporteRepository TipoTransportes { get; }
        ITransporteRepository Transportes { get; }
        IUbigeoRepository Ubigeos { get; }

        int SaveChanges();

        void StateModified(object entity);
    }
}
