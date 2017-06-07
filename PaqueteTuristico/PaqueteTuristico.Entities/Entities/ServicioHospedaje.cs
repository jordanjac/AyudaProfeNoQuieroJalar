using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class ServicioHospedaje
    {
        public int ServicioHospedajeId { get; set; }
        public string Name { get; set; }


        public int HospedajeId { get; set; }
        public Hospedaje Hospedaje { get; set; }


    }
}
