using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Name { get; set; }

        public int AlimentacionId { get; set; }
        public Alimentacion Alimentacion { get; set; }

        public int HospedajeId { get; set; }
        public Hospedaje Hospedaje { get; set; }

        public List<Ubigeo> Ubigeos { get; set; }

        public Direccion()
        {
            Ubigeos = new List<Ubigeo>();
        }



    }
}
