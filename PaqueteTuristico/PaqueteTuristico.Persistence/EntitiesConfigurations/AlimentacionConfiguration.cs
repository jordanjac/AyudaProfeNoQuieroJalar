using PaqueteTuristico.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;



namespace PaqueteTuristico.Persistence.EntitiesConfigurations
{
    public class AlimentacionConfiguration : EntityTypeConfiguration<Alimentacion>
    {
        public AlimentacionConfiguration()
        {
            ToTable("Alimentacion");

            HasKey(a=>a.AlimentacionId);

            Property(m => m.AlimentacionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v=>v.Name).IsRequired();

            

        }
    }
}
