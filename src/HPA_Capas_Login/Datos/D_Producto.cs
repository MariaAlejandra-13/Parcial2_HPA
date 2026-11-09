using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class D_Producto
    {
        public DataTable ObtenerBajoStock()
        {
            using var conexion = new D_Conexion().CrearConexion();
            using var comando = new SqlCommand(
                "dbo.usp_Productos_BajoStock", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            using var adaptador = new SqlDataAdapter(comando);
            var tabla = new DataTable();
            adaptador.Fill(tabla);

            return tabla;
        }
    }
}
