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
    public class TransporteConfiguration : EntityTypeConfiguration<Transporte>
    {
        public TransporteConfiguration()
        {
            ToTable("Transporte");

            HasKey(a => a.TransporteId);

            Property(m => m.TransporteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
