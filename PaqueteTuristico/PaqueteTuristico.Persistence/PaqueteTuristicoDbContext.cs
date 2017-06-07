using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities;
using PaqueteTuristico.Persistence.EntitiesConfigurations;

namespace PaqueteTuristico.Persistence
{
    public class PaqueteTuristicoDbContext : DbContext
    {
        public DbSet<Alimentacion> Alimentaciones { get; set; }
        public DbSet<CalificacionAlimentacion> CalificacionAlimentaciones { get; set; }
        public DbSet<CalificacionHospedaje> CalificacionHospedajes { get; set; }
        public DbSet<CategoriaHospedaje> CategoriaHospedajes { get; set; }
        public DbSet<CategoriaRestaurant> CategoriaRestaurantes { get; set; }
        public DbSet<CategoriaTransporte> CategoriaTransportes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<EstadoTransporte> EstadoTransportes { get; set; }
        public DbSet<Hospedaje> Hospedajes { get; set; }
        public DbSet<MarcaTransporte> MarcaTransportes { get; set; }
        public DbSet<ModeloTransporte> ModeloTransportes { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<ServicioHospedaje> ServicioHospedajes { get; set; }
        public DbSet<TipoAlimentacion> TipoAlimentaciones { get; set; }
        public DbSet<TipoHospedaje> TipoHospedajes { get; set; }
        public DbSet<TipoTransporte> TipoTransportes { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }


        public PaqueteTuristicoDbContext() : base ("PaqueteTuristico")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlimentacionConfiguration());
            modelBuilder.Configurations.Add(new CalificacionAlimentacionConfiguration());
            modelBuilder.Configurations.Add(new CalificacionHospedajeConfiguration());
            modelBuilder.Configurations.Add(new CategoriaHospedajeConfiguration());
            modelBuilder.Configurations.Add(new CategoriaRestaurantConfiguration());
            modelBuilder.Configurations.Add(new CategoriaTransporteConfiguration());
            modelBuilder.Configurations.Add(new DepartamentoConfiguration());
            modelBuilder.Configurations.Add(new DireccionConfiguration());
            modelBuilder.Configurations.Add(new DistritoConfiguration());
            modelBuilder.Configurations.Add(new EstadoTransporteConfiguration());
            modelBuilder.Configurations.Add(new HospedajeConfiguration());
            modelBuilder.Configurations.Add(new MarcaTransporteConfiguration());
            modelBuilder.Configurations.Add(new ModeloTransporteConfiguration());
            modelBuilder.Configurations.Add(new PaqueteConfiguration());
            modelBuilder.Configurations.Add(new ProvinciaConfiguration());
            modelBuilder.Configurations.Add(new ServicioHospedajeConfiguration());
            modelBuilder.Configurations.Add(new TipoAlimentacionConfiguration());
            modelBuilder.Configurations.Add(new TipoHospedajeConfiguration());
            modelBuilder.Configurations.Add(new TipoTransporteConfiguration());
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new UbigeoConfiguration());



            base.OnModelCreating(modelBuilder);
        }

    }
}
