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
    public class TipoHospedajeConfiguration : EntityTypeConfiguration<TipoHospedaje>
    {
        public TipoHospedajeConfiguration()
        {
            ToTable("TipoHospedaje");

            HasKey(a => a.TipoHospedajeId);

            Property(m => m.TipoHospedajeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
