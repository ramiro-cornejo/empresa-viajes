using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadeViajes.Dominio
{
    class Particular: Cliente
    {
        public int particular_id { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string particular_cliente_id { get; set; }
    }
}
