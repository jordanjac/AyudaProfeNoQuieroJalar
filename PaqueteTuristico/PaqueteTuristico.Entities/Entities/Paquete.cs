using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
     public class Paquete
    {
        public int PaqueteId { get; set; }
        public string Name { get; set; }


        public List<Transporte> Transportes { get; set; }
        public List<Alimentacion> Alimentaciones { get; set; }
        public List<Hospedaje> Hospedajes { get; set; }



        public Paquete()
        {
            Transportes = new List<Transporte>();
            Alimentaciones = new List<Alimentacion>();
            Hospedajes = new List<Hospedaje>();
        }

    }
}
