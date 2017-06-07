using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class TipoAlimentacion
    {
        public int TipoAlimentacionId { get; set; }
        public string Name { get; set; }



        public int AlimentacionId { get; set; }
        public Alimentacion Alimentacion { get; set; }
    }
}
