using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form, ILoginView
    {
        public FrmLogin()
        {
            InitializeComponent();

            AcceptButton = btnIngresar;
            btnIngresar.Click += (sender, e) =>
                IngresoSolicitado?.Invoke(this, EventArgs.Empty);
        }

        public string Usuario => txtUsuario.Text;
        public string Password => txtPassword.Text;

        public string UsuarioAutenticado { get; private set; }
            = string.Empty;
        public string CorreoAutenticado { get; private set; } = string.Empty;

        public event EventHandler? IngresoSolicitado;

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(this, mensaje, "Inicio de sesión",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void AceptarIngreso(string usuario, string correo)
        {
            UsuarioAutenticado = usuario;
            CorreoAutenticado = correo;
            txtPassword.Clear();
            DialogResult = DialogResult.OK;
        }
    }
}
