using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Provincia
    {   
        public int ProvinciaId { get; set; }
        public string Name { get; set; }

        public int DistritoId { get; set; }
        public Distrito Distrito { get; set; }

        public int UbigeoId { get; set; }
        public Ubigeo Ubigeo { get; set; }

        public List<Departamento> Departamentos { get; set; }

        public Provincia()
        {
            Departamentos = new List<Departamento>();
        }
    }
}
