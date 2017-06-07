using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaqueteTuristico.Entities.IRepositories;
using PaqueteTuristico.Entities;

namespace PaqueteTuristico.Persistence.Repositories
{
    public class CategoriaRestaurantRepository : Repository<CategoriaRestaurant>,ICategoriaRestaurantRepository
    {
        private readonly PaqueteTuristicoDbContext _Context;

        private CategoriaRestaurantRepository()
        {

        }

        public CategoriaRestaurantRepository(PaqueteTuristicoDbContext context)
        {
            _Context = context;
        }
    }
}
