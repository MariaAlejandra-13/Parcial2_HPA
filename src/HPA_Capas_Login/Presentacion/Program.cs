using System;
using System.Windows.Forms;
using Datos;
using Negocio;
using Negocio.Servicios;

namespace Presentacion
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            string usuarioAutenticado;
            string correoAutenticado;

            using (var login = new FrmLogin())
            {
                var generador = new Sha512HashService();
                var verificador = new Sha512VerificarHashService(generador);
                var negocio = new N_Usuario(new D_Usuario(), verificador);

                _ = new LoginPresenter(login, negocio);

                if (login.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                usuarioAutenticado = login.UsuarioAutenticado;
                correoAutenticado = login.CorreoAutenticado;
            }

            Application.Run(new FrmPrincipal(usuarioAutenticado, correoAutenticado));
        }
    }
}