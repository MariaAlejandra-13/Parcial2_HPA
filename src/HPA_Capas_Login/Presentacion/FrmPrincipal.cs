using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            tmrReloj.Tick += (sender, e) => ActualizarReloj();

            Shown += (sender, e) =>
            {
                ActualizarReloj();
                tmrReloj.Start();
                CargarBajoStock();
            };
        }
        public FrmPrincipal(string usuario, string correo) : this()
        {
            lblSesion.Text = string.IsNullOrWhiteSpace(correo)
                ? usuario
                : $"{usuario}{Environment.NewLine}{correo}";
        }
        private void CargarBajoStock()
        {
            try
            {
                var productos = new Negocio.N_Producto().ObtenerBajoStock();

                dgvBajoStock.AutoGenerateColumns = false;
                dgvBajoStock.DataSource = productos;
            }
            catch (System.Data.Common.DbException ex)
            {
                MessageBox.Show(
                    this,
                    "No se pudieron cargar los productos bajo stock.\n" + ex.Message,
                    "Productos bajo stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ActualizarReloj()
        {
            DateTime ahora = DateTime.Now;

            lblHora.Text = ahora.ToString("HH:mm:ss");
            lblFecha.Text = ahora.ToString(
                "dddd, d 'de' MMMM 'de' yyyy",
                System.Globalization.CultureInfo.GetCultureInfo("es-PA"));
        }
    }
}
