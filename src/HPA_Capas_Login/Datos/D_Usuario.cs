using System.Data;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Usuario
    {
        private readonly D_Conexion conexion = new D_Conexion();

        // Recupera el usuario. La contraseña se verifica en Negocio.
        public E_Usuario ObtenerPorNombre(string nombreUsuario)
        {
            using (SqlConnection cn = conexion.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(
                "dbo.usp_Usuario_ObtenerPorNombre", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    "@Usuario", SqlDbType.VarChar, 50
                ).Value = nombreUsuario;

                cn.Open();

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (!lector.Read())
                    {
                        return null;
                    }

                    return new E_Usuario
                    {
                        id = lector.GetInt32(
                            lector.GetOrdinal("id")),

                        dsId = lector.GetString(
                            lector.GetOrdinal("dsId")),

                        dsUsuario = lector.GetString(
                            lector.GetOrdinal("dsUsuario")),
                        dsCorreo = lector["dsCorreo"] as string ?? string.Empty,

                        dsPassword = (byte[])lector["dsPassword"],

                        dsEstado = lector.GetString(
                            lector.GetOrdinal("dsEstado")),

                        dsUsuarioCreacion = lector.GetString(
                            lector.GetOrdinal("dsUsuarioCreacion")),

                        dtFechaCreacion = lector.GetDateTime(
                            lector.GetOrdinal("dtFechaCreacion")),

                        dsUsuarioModificacion = lector.GetString(
                            lector.GetOrdinal("dsUsuarioModificacion")),

                        dtFechaModificacion = lector.GetDateTime(
                            lector.GetOrdinal("dtFechaModificacion"))
                    };
                }
            }
        }
    }
}