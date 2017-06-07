using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaqueteTuristico.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Name { get; set; }

        public int UbigeoId { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public int PronvinciaId { get; set; }
        public Provincia Provincia { get; set; }


    }
}
