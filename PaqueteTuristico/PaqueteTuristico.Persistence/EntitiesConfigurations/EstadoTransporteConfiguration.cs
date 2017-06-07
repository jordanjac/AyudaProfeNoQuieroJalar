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
    public class EstadoTransporteConfiguration : EntityTypeConfiguration<EstadoTransporte>
    {
        public EstadoTransporteConfiguration()
        {
            ToTable("EstadoTransporte");

            HasKey(a => a.EstadoTransporteId);

            Property(m => m.EstadoTransporteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
