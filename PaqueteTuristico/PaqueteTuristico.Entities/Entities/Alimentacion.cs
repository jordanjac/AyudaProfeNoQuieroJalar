using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Alimentacion
    {
        public int AlimentacionId { get; set; }
        public string Name { get; set; }

        public int PaqueteId { get; set; }
        public Paquete Paquete { get; set; }

        public List<TipoAlimentacion> TipoAlimentaciones { get; set; }
        public List<CategoriaRestaurant> CategoriaRestaurantes { get; set; }
        public List<CalificacionAlimentacion> CalificacionAlimentaciones { get; set; }
        public List<Direccion> Direcciones { get; set; }

        public Alimentacion()
        {
            TipoAlimentaciones = new List<TipoAlimentacion>();
            CategoriaRestaurantes = new List<CategoriaRestaurant>();
            CalificacionAlimentaciones = new List<CalificacionAlimentacion>();
            Direcciones = new List<Direccion>();
        }

    }
}
