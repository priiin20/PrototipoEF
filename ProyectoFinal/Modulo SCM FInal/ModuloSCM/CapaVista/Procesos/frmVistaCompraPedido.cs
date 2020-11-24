using CapaControladorModuloSCM.ControlProcesos;
using CapaVistaModuloSCM.MDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Procesos
{
    public partial class frmVistaCompraPedido : Form
    {
        clsControladorGestionCompraPedido controladorGestionCompraPedido = new clsControladorGestionCompraPedido();
        Form formPrincipal;
        public frmVistaCompraPedido(Form formMDI)
        {
            InitializeComponent();
            formPrincipal = formMDI;
        }

        private void cargarDatosCompra()
        {
            dgvVistaDatos.DataSource = controladorGestionCompraPedido.obtenerDatosCompras();
        }
        private void cargarDatosPedido()
        {
            dgvVistaDatos.DataSource = controladorGestionCompraPedido.obtenerDatosPedido();
        }
        private void cargarDatosExistencia()
        {
            dgvVistaDatos.DataSource = controladorGestionCompraPedido.obtenerDatosExistencias();
        }
        private void cargarDatosInventario()
        {
            dgvVistaDatos.DataSource = controladorGestionCompraPedido.obtenerDatosInventario();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCompras);
            if (frmFormulario != null)
            {
                frmFormulario.BringToFront();
                return;
            }

            frmFormulario = new frmCompras();
            frmFormulario.MdiParent = formPrincipal;
            frmFormulario.Show();
        }

        private void rbtnCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCompras.Checked)
            {
                dgvVistaDatos.DataSource = null;
                cargarDatosCompra();
            }
        }

        private void btnPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPedido.Checked)
            {
                dgvVistaDatos.DataSource = null;
                cargarDatosPedido();
            }
        }

        private void frmVistaCompraPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasModuloSCM/AyudasSCMASII.chm", "VistaCompras.html");
        }

        private void rbtnInventario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInventario.Checked)
            {
                dgvVistaDatos.DataSource = null;
                cargarDatosInventario();
            }
        }

        private void rbtnExistencias_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExistencias.Checked)
            {
                dgvVistaDatos.DataSource = null;
                cargarDatosExistencia();
            }
        }
    }
}
