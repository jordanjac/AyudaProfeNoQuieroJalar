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
    public class PaqueteConfiguration : EntityTypeConfiguration<Paquete>
    {
        public PaqueteConfiguration()
        {
            ToTable("Paquete");

            HasKey(a => a.PaqueteId);

            Property(m => m.PaqueteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
