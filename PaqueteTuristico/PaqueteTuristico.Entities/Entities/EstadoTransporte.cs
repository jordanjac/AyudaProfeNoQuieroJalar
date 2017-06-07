using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class EstadoTransporte
    {
        public int EstadoTransporteId { get; set; }
        public string Name { get; set; }


        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }



    }
}
