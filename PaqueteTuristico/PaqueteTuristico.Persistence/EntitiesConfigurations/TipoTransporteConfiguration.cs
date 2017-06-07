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
    public class TipoTransporteConfiguration : EntityTypeConfiguration<TipoTransporte>
    {
        public TipoTransporteConfiguration()
        {
            ToTable("TipoTransporte");

            HasKey(a => a.TipoTransporteId);

            Property(m => m.TipoTransporteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
