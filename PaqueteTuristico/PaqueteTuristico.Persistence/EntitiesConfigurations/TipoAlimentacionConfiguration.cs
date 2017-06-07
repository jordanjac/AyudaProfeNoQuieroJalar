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
    public class TipoAlimentacionConfiguration : EntityTypeConfiguration<TipoAlimentacion>
    {
        public TipoAlimentacionConfiguration()
        {
            ToTable("TipoAlimentacion");

            HasKey(a => a.TipoAlimentacionId);

            Property(m => m.TipoAlimentacionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
