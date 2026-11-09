using System.Data;
using Datos;

namespace Negocio
{
    public class N_Producto
    {
        public DataTable ObtenerBajoStock()
        {
            return new D_Producto().ObtenerBajoStock();
        }
    }
}
