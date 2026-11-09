using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class D_Conexion
    {
        // Devuelve una conexión nueva, todavía cerrada.
        public SqlConnection CrearConexion()
        {
            ConnectionStringSettings configuracion =
                ConfigurationManager.ConnectionStrings["ConexionHPA"];

            if (configuracion == null ||
                string.IsNullOrWhiteSpace(configuracion.ConnectionString))
            {
                throw new InvalidOperationException(
                    "No se encontró la conexión ConexionHPA en App.config.");
            }

            return new SqlConnection(configuracion.ConnectionString);
        }
    }
}