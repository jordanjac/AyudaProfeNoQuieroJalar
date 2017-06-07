﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class ProvinciaRepository : Repository<Provincia>, IProvinciaRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private ProvinciaRepository()
        {

        }

        public ProvinciaRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
