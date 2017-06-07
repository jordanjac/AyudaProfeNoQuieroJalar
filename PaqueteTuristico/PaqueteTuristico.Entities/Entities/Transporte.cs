using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Transporte
    {
        public int TransporteId { get; set; }
        public string Name { get; set; }
        public string PlacaTransporte { get; set; }

        public int PaqueteId { get; set; }
        public Paquete Paquete { get; set; }


        public List<TipoTransporte> TipoTransportes { get; set; }
        public List<MarcaTransporte> MarcaTransportes { get; set; }
        public List<EstadoTransporte> EstadoTransportes { get; set; }



        public Transporte()
        {
            TipoTransportes = new List<TipoTransporte>();
            MarcaTransportes = new List<MarcaTransporte>();
            EstadoTransportes = new List<EstadoTransporte>();
        }


    }
}
