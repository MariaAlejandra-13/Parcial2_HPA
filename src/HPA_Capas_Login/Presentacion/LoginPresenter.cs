using System;
using System.Data.Common;
using Negocio;

namespace Presentacion
{
    public class LoginPresenter
    {
        private readonly ILoginView vista;
        private readonly N_Usuario negocio;

        public LoginPresenter(ILoginView vista, N_Usuario negocio)
        {
            this.vista = vista;
            this.negocio = negocio;

            vista.IngresoSolicitado += IniciarSesion;
        }

        private void IniciarSesion(object? sender, EventArgs e)
        {
            try
            {
                var usuario = negocio.IniciarSesion(
                    vista.Usuario, vista.Password);

                if (usuario == null)
                {
                    vista.MostrarMensaje(
                        "Usuario o contraseña incorrectos.");
                    return;
                }

                vista.AceptarIngreso(usuario.dsUsuario, usuario.dsCorreo);
            }
            catch (ArgumentException ex)
            {
                vista.MostrarMensaje(ex.Message);
            }
            catch (DbException ex)
            {
                vista.MostrarMensaje(
                    "No se pudo completar el acceso a SQL Server.\n" +
                    ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                vista.MostrarMensaje(ex.Message);
            }
        }
    }
}

