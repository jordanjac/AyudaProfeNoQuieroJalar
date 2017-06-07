using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class ModeloTransporte
    {
        public int ModeloTransporteId { get; set; }
        public string Name { get; set; }

        public int MarcaTransporteId { get; set; }
        public MarcaTransporte MarcaTransporte { get; set; }

       

    }
}
