using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class CategoriaTransporte
    {
        public int CategoriaTransporteId { get; set; }
        public string Name { get; set; }

        public int TipoTransporteId { get; set; }
        public TipoTransporte TipoTransporte { get; set; }


    }
}
