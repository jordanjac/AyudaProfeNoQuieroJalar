using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class MarcaTransporte
    {
        public int MarcaTransporteId { get; set; }
        public string Name { get; set; }

        public int TipoTransporteId { get; set; }
        public TipoTransporte TipoTransporte { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }


        public List<ModeloTransporte> ModeloTransportes { get; set; }


        public MarcaTransporte()
        {
            ModeloTransportes = new List<ModeloTransporte>();
        }




    }
}
