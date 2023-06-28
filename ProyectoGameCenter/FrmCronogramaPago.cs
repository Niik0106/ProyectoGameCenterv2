using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace ProyectoGameCenter
{
    public partial class FrmCronogramaPago : Form
    {
        
        public FrmCronogramaPago()
        {
            InitializeComponent();
            LlenarDatosEstadoPago();
            ListarMetodoPago();
            txtIDOrdenVenta.Text = FrmOrdenVenta.nOrdenVenta;
            txtTotal.Text = FrmOrdenVenta.totalCR;
            txtIDCliente.Text = FrmOrdenVenta.idCliente;
            ListarCronograma();
        }

        public void ListarMetodoPago()
        {
            cboMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
            cboMetodoPago.DisplayMember = "DES_METODO_PAGO";
            cboMetodoPago.ValueMember = "ID_METODO_PAGO";
        }

        public void LlenarDatosEstadoPago()
        {
            cboEstadoPago.DataSource = logEstadoPago.Instancia.ListaEstadoPago();
            cboEstadoPago.DisplayMember = "DES_ESTADO_PAGO";
            cboEstadoPago.ValueMember = "ID_ESTADO_PAGO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ListarCronograma()
        {
            dgvCronogramaPago.DataSource = logCronograma.Instancia.ListaCronograma();
        }

        private void LimpiarVariables()
        {
            txtIDCronogramaPago.Clear();
            dtimeFechaVenta.ResetText();
            dtimePlazoPago.ResetText();
            txtNumeroCuotas.Clear();
            txtIDOrdenVenta.Clear();
            txtIDCliente.Clear();
            txtTotal.Clear();
            cboEstadoPago.ResetText();
            cboMetodoPago.ResetText();
            txtObservaciones.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroCuotas.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entCronograma c = new entCronograma();
                    c.FECHA_VENTA = dtimeFechaVenta.Value;
                    c.NUM_ORDEN_VENTA = Convert.ToInt32(txtIDOrdenVenta.Text.Trim());
                    c.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text.Trim());
                    c.TOTAL = Convert.ToDecimal(txtTotal.Text.Trim());
                    c.NUM_CUOTAS = Convert.ToInt32(txtNumeroCuotas.Text.Trim());
                    c.ID_METODO_PAGO = Convert.ToInt32(cboMetodoPago.SelectedValue);
                    c.ID_ESTADO_PAGO = Convert.ToInt32(cboEstadoPago.SelectedValue);
                    c.OBSERVACIONES = txtObservaciones.Text.Trim();
                    logCronograma.Instancia.InsertaCronograma(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarCronograma();
            LimpiarVariables();
        }

        private void btnPagado_Click(object sender, EventArgs e)
        {
            if (txtIDCronogramaPago.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un cronograma", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entCronograma Crono = new entCronograma();
                Crono.ID_CRONOGRAMA_PAGO = Convert.ToInt32(txtIDCronogramaPago.Text);
                logCronograma.Instancia.CambiaEstadoCrono(Crono);
                MessageBox.Show("Conograma establecido como Pagado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarCronograma();
                LimpiarVariables();
                gbCronogramaPago.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvCronogramaPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvCronogramaPago.Rows[e.RowIndex];
                txtIDCronogramaPago.Text = filaActual.Cells[0].Value.ToString();
                dtimeFechaVenta.Text = filaActual.Cells[1].Value.ToString();
                txtIDOrdenVenta.Text = filaActual.Cells[2].Value.ToString();
                txtIDCliente.Text = filaActual.Cells[3].Value.ToString();
                txtTotal.Text = filaActual.Cells[4].Value.ToString();
                txtNumeroCuotas.Text = filaActual.Cells[5].Value.ToString();
                cboMetodoPago.SelectedValue = Convert.ToInt32(filaActual.Cells[6].Value);
                dtimePlazoPago.Text = filaActual.Cells[7].Value.ToString();
                cboEstadoPago.SelectedValue = Convert.ToInt32(filaActual.Cells[8].Value);
                txtObservaciones.Text = filaActual.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
            
        }
    }
}
