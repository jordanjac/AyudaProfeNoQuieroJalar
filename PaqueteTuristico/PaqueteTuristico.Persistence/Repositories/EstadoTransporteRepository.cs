﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class EstadoTransporteRepository : Repository<EstadoTransporte>, IEstadoTransporteRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private EstadoTransporteRepository()
        {

        }

        public EstadoTransporteRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
