using PaqueteTuristico.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Persistence.EntitiesConfigurations
{
    public class ServicioHospedajeConfiguration : EntityTypeConfiguration<ServicioHospedaje>
    {
        public ServicioHospedajeConfiguration()
        {
            ToTable("ServicioHospedaje");

            HasKey(a => a.ServicioHospedajeId);

            Property(m => m.ServicioHospedajeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
