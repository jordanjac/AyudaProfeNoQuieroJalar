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
    public class CategoriaTransporteConfiguration :  EntityTypeConfiguration<CategoriaTransporte>
    {
        public CategoriaTransporteConfiguration()
        {
            ToTable("CategoriaTransporte");

            HasKey(a => a.CategoriaTransporteId);

            Property(m => m.CategoriaTransporteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();
        }
    }
}
