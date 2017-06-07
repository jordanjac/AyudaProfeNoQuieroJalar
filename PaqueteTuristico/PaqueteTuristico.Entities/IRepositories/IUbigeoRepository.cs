using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities.IRepositories
{
    public interface IUbigeoRepository : IRepository<Ubigeo>
    {
        IEnumerable<Ubigeo> GetUbigeoByDistrito(Distrito distrito);
        IEnumerable<Ubigeo> GetUbigeoByProvincia(Provincia provincia);
        IEnumerable<Ubigeo> GetUbigeoByDepartamento(Departamento departamento);
    }
}
