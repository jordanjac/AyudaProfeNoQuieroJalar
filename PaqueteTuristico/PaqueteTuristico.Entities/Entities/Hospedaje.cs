using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Hospedaje
    {
        public int HospedajeId { get; set; }
        public int Name { get; set; }

        public int PaqueteId { get; set; }
        public Paquete Paquete { get; set; }

        public List<Direccion> Direcciones { get; set; }
        public List<ServicioHospedaje> ServicioHospedajes { get; set; }
        public List<CalificacionHospedaje> CalificacionHospedajes { get; set; }
        public List<CategoriaHospedaje> CategoriaHospedajes { get; set; }
        public List<TipoHospedaje> TipoHospedajes { get; set; }

        public Hospedaje()
        {
            Direcciones = new List<Direccion>();
            ServicioHospedajes = new List<ServicioHospedaje>();
            CalificacionHospedajes = new List<CalificacionHospedaje>();
            CategoriaHospedajes = new List<CategoriaHospedaje>();
            TipoHospedajes = new List<TipoHospedaje>();
        }


    }
}
