using Dapper;
using EmpresadeViajes.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadeViajes
{
    class Db
    {
        static string sqlConnectionString = @"Data Source = localhost;initial catalog=EmpresaViajes; persist security info=True;Integrated Security=SSPI;";
        public static List<T> GetAll<T>(string query)
        {
            List<T> results = new List<T>();

            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                results = connection.Query<T>(query).ToList();
                connection.Close();
            }

            return results;
        }

        public static int InsertParticular(Particular particular)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();

                var affectedRows = connection.Execute("exec [sp_insertcliente_particular] @Nacionalidad, @Provincia, " +
                                                                                         "@Direccion, @Telefono, @Dni, @Nombre, @Apellido"
                    , new
                    {
                        Nacionalidad = particular.nacionalidad,
                        Provincia = particular.provincia,
                        Direccion = particular.direccion,
                        Telefono = particular.telefono,
                        Dni = particular.dni,
                        Nombre = particular.nombre,
                        Apellido = particular.apellido
                    });

                connection.Close();
                return affectedRows;
            }
        }

        public static int InsertCorporativo(Corporativo corporativo)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();

                var affectedRows = connection.Execute("exec [sp_insertcliente_corporativo] @Nacionalidad, @Provincia, " +
                                                                                           "@Direccion, @Telefono, @Cuit, @RazonSocial"
                    , new
                    {
                        Nacionalidad = corporativo.nacionalidad,
                        Provincia = corporativo.provincia,
                        Direccion = corporativo.direccion,
                        Telefono = corporativo.telefono,
                        Cuit = corporativo.cuit,
                        RazonSocial = corporativo.razonsocial
                    });

                connection.Close();
                return affectedRows;
            }
        }

        public static int UpdateParticular(Particular particular)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(
                    "exec [sp_update_cliente_particular] @ClienteId, @ParticularId, @Nacionalidad, @Provincia, " +
                    "@Direccion, @Telefono, @Dni, @Nombre, @Apellido",
                    new
                    {
                        ClienteId = particular.cliente_id,
                        ParticularId = particular.particular_id,
                        Nacionalidad = particular.nacionalidad,
                        Provincia = particular.provincia,
                        Direccion = particular.direccion,
                        Telefono = particular.telefono,
                        Dni = particular.dni,
                        Nombre = particular.nombre,
                        Apellido = particular.apellido
                    });
                connection.Close();
                return affectedRows;
            }
        }

        public static int UpdateCorporativo(Corporativo corporativo)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(
                    "exec [sp_update_cliente_corporativo] @ClienteId, @ParticularId, @Nacionalidad, @Provincia, " +
                    "@Direccion, @Telefono, @Cuit, @RazonSocial",
                    new
                    {
                        ClienteId = corporativo.cliente_id,
                        ParticularId = corporativo.corporativo_id,
                        Nacionalidad = corporativo.nacionalidad,
                        Provincia = corporativo.provincia,
                        Direccion = corporativo.direccion,
                        Telefono = corporativo.telefono,
                        Cuit = corporativo.cuit,
                        RazonSocial = corporativo.razonsocial
                    });
                connection.Close();
                return affectedRows;
            }
        }


    }
}
