using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Distrito
    {
        public int DistritoId { get; set; }
        public string Name { get; set; }

        public int UbigeoId { get; set; }
        public Ubigeo Ubigeo { get; set; }

        public List<Provincia> Provincias { get; set; }

        public Distrito()
        {
            Provincias = new List<Provincia>();
        }

    }
}
