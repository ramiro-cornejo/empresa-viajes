using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadeViajes.Dominio
{
    class Corporativo: Cliente
    {
        public int corporativo_id { get; set; }
        public string razonsocial { get; set; }
        public string cuit { get; set; }
        public int corporativo_cliente_id { get; set; }

    }
}
