using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class TipoTransporte
    {
        public int TipoTransporteId { get; set; }
        public string Name { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }


        public List<CategoriaTransporte> CategoriaTransportes { get; set; }
        public List<MarcaTransporte> MarcaTransportes { get; set; }



        public TipoTransporte()
        {
            CategoriaTransportes = new List<CategoriaTransporte>();
            MarcaTransportes = new List<MarcaTransporte>();
        }

      
    }
}
