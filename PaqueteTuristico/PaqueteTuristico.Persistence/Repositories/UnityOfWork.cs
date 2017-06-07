using PaqueteTuristico.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly PaqueteTuristicoDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAlimentacionRepository Alimentaciones { get; private set; }
        public ICalificacionAlimentacionRepository CalificacionAlimentaciones { get; private set; }
        public ICalificacionHospedajeRepository CalificacionHospedajes { get; private set; }
        public ICategoriaHospedajeRepository CategoriaHospedajes { get; private set; }
        public ICategoriaRestaurantRepository CategoriaRestaurantes { get; private set; }
        public ICategoriaTransporteRepository CategoriaTransportes { get; private set; }
        public IDepartamentoRepository Departamentos { get; private set; }
        public IDireccionRepository Direcciones { get; private set; }
        public IDistritoRepository Distritos { get; private set; }
        public IEstadoTransporteRepository EstadoTransportes { get; private set; }
        public IHospedajeRepository Hospedajes { get; private set; }
        public IMarcaTransporteRepository MarcaTransportes { get; private set; }
        public IModeloTransporteRepository ModeloTransportes { get; private set; }
        public IPaqueteRepository Paquetes { get; private set; }
        public IProvinciaRepository Provincias { get; private set; }
        public IServicioHospedajeRepository ServicioHospedajes { get; private set; }
        public ITipoAlimentacionRepository TipoAlimentaciones { get; private set; }
        public ITipoHospedajeRepository TipoHospedajes { get; private set; }
        public ITipoTransporteRepository TipoTransportes { get; private set; }
        public ITransporteRepository Transportes { get; private set; }
        public IUbigeoRepository Ubigeos { get; private set; }



        private UnityOfWork()
        {
            _Context = new PaqueteTuristicoDbContext();

            Alimentaciones = new AlimentacionRepository(_Context);
            CalificacionAlimentaciones = new CalificacionAlimentacionRepository(_Context);
            CalificacionHospedajes = new CalificacionHospedajeRepository(_Context);
            CategoriaHospedajes = new CategoriaHospedajeRepository(_Context);
            CategoriaRestaurantes = new CategoriaRestaurantRepository(_Context);
            CategoriaTransportes = new CategoriaTransporteRepository(_Context);
            Departamentos = new DepartamentoRepository(_Context);
            Direcciones = new DireccionRepository(_Context);
            Distritos = new DistritoRepository(_Context);
            EstadoTransportes = new EstadoTransporteRepository(_Context);
            Hospedajes = new HospedajeRepository(_Context);
            MarcaTransportes = new MarcaTransporteRepository(_Context);
            ModeloTransportes = new ModeloTransporteRepository(_Context);
            Paquetes = new PaqueteRepository(_Context);
            Provincias = new ProvinciaRepository(_Context);
            ServicioHospedajes = new ServicioHospedajeRepository(_Context);
            TipoAlimentaciones = new TipoAlimentacionRepository(_Context);
            TipoHospedajes = new TipoHospedajeRepository(_Context);
            TipoTransportes = new TipoTransporteRepository(_Context);
            Transportes = new TransporteRepository(_Context);
            Ubigeos = new UbigeoRepository(_Context);
        }


        public static UnityOfWork Instance
        {
            get
            {
                lock(_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }
                return _Instance;
            }

        }


        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }


        public void StateModified (object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
