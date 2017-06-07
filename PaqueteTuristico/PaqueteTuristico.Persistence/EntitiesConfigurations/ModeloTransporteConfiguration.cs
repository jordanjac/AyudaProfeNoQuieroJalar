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
    public class ModeloTransporteConfiguration : EntityTypeConfiguration<ModeloTransporte>
    {
        public ModeloTransporteConfiguration()
        {
            ToTable("ModeloTransporte");

            HasKey(a => a.ModeloTransporteId);

            Property(m => m.ModeloTransporteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
