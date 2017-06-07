﻿using PaqueteTuristico.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Persistence.EntitiesConfigurations
{
    public class CategoriaHospedajeConfiguration : EntityTypeConfiguration<CategoriaHospedaje>
    {
        public CategoriaHospedajeConfiguration()
        {
            ToTable("CategoriaHospedaje");

            HasKey(a => a.CategoriaHospedajeId);

            Property(m => m.CategoriaHospedajeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(v => v.Name).IsRequired();

        }
    }
}
