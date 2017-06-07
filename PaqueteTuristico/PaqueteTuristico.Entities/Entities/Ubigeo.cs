using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Ubigeo
    {
        public int UbigeoId { get; set; }
        public string Name { get; set; }


        public int DireccionId { get; set; }
        public Direccion Direccion { get; set; }

        public List<Distrito> Distritos { get; set; }
        public List<Provincia> Provincias { get; set; }
        public List<Departamento> Departamentos { get; set; }

        public Ubigeo()
        {
            Distritos = new List<Distrito>();
            Provincias = new List<Provincia>();
            Departamentos = new List<Departamento>();
        }


    }
}
