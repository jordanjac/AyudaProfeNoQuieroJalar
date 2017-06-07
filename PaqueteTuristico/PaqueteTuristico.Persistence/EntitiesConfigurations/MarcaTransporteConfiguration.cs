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
    public class MarcaTransporteConfiguration : EntityTypeConfiguration<MarcaTransporte>
    {
        public MarcaTransporteConfiguration()
        {
            ToTable("MarcaTransporte");

            HasKey(a => a.MarcaTransporteId);

            Property(m => m.MarcaTransporteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
