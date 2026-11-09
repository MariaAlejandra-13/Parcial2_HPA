using System;

namespace Presentacion
{
    public interface ILoginView
    {
        string Usuario { get; }
        string Password { get; }

        event EventHandler IngresoSolicitado;

        void MostrarMensaje(string mensaje);
        void AceptarIngreso(string usuario, string correo);
    }
}
