using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadeViajes.Dominio
{
    class Cliente
    {
        public int cliente_id { get; set; }
        public string nacionalidad { get; set; }
        public string provincia { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
