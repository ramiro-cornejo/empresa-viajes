using EmpresadeViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadeViajes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Probando sistema de viajes");
            List<Particular> particulares = Db.GetAll<Particular>("select * from clientes_particulares");

            List<Corporativo> corporativos = Db.GetAll<Corporativo>("select * from clientes_corporativos"
                );


            Particular particular = new Particular()
            {
                nacionalidad = "Argentina",
                provincia = "Jujuy",
                telefono = "3112-6678",
                direccion = "",
                dni = "45666565",
                nombre = "Pablo",
                apellido = "Maury"
            };

            Corporativo corporativo = new Corporativo()
            {
                nacionalidad = "Argentina",
                provincia = "La Pampa",
                telefono = "3112-6678",
                direccion = "",
                cuit = "30-45666565",
                razonsocial = "Lier Sa"
            };

            var part = particulares[2];

            part.apellido = "cambio el apellido";

            int update = Db.UpdateParticular(part);

            var corp = corporativos[1];

            corp.razonsocial = "nueva razon social";
            Db.UpdateCorporativo(corp);
        }
    }
}
