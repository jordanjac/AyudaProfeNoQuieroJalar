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
    public class CalificacionAlimentacionConfiguration : EntityTypeConfiguration<CalificacionAlimentacion>
    {
        public CalificacionAlimentacionConfiguration()
        {
            ToTable("CalificacionAlimentacion");

            HasKey(a => a.CalificacionAlimentacionId);

            Property(m => m.CalificacionAlimentacionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
