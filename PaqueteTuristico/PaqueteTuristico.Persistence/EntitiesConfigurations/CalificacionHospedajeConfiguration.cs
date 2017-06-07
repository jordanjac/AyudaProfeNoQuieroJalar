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
    public class CalificacionHospedajeConfiguration : EntityTypeConfiguration<CalificacionHospedaje>
    {
        public CalificacionHospedajeConfiguration()
        {
            ToTable("CalificacionHospedaje");

            HasKey(a => a.CalificacionHospedajeId);

            Property(m => m.CalificacionHospedajeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();

        }
    }
}
