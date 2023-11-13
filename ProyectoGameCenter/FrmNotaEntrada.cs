using AccesoDatos;
using Entidades;
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

namespace ProyectoGameCenter
{
    public partial class FrmNotaEntrada : Form
    {
        public FrmNotaEntrada()
        {
            InitializeComponent();
            ListarNotaEntrada();
            ListarCompras();
        }

        public void ListarNotaEntrada()
        {
            dgvNotaEntrada.DataSource = logNotaEntrada.Instancia.ListarNotaEntrada();
        }

        public void ListarDetalleOrdenCompra()
        {
            dgvDetalleOrdenCompra.DataSource = logDetalleOrdenCompra.Instancia.ListarDetalleOrdenCompra();
        }

        public void ListarCompras()
        {
            dgvOrdenCompra.DataSource = logOrdenCompra.Instancia.ListarOrdenesCompra();
        }

        public void LimpiarVariables()
        {
            txtIDNotaEntrada.Text = "";
            dtpFechaNotaEntrada.ResetText();
            txtNNotaEntrada.Text = "";
            txtNumOrden.Text = "";
            dtpFechaOrden.ResetText();
            cbxEstado.Checked = default;
        }


        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenCompra ordenCompra= new entOrdenCompra();
                ordenCompra.fechaOrdenCompra = dtpFechaOrden.Value;
                dgvOrdenCompra.DataSource = logOrdenCompra.Instancia.BuscaFechaCompra(ordenCompra);
                if (dgvOrdenCompra.Rows.Count == 0)
                {
                    MessageBox.Show("No existen compras de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarCompras();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumOrden.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar el Numero de Orden Compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entNotaEntrada NotaEntrada = new entNotaEntrada();
                    //Notasalida.numeroOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                    NotaEntrada.fechaEmision = dtpFechaNotaEntrada.Value;
                    NotaEntrada.numOrdenCompra = int.Parse(txtNumOrden.Text.Trim());
                    NotaEntrada.estado = cbxEstado.Checked;
                    logNotaEntrada.Instancia.InsertarNotaEntrada(NotaEntrada);

                    MessageBox.Show("Nota de Entrada registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.." + ex);
            }
            ListarNotaEntrada();
            LimpiarVariables();
        }

        private void dgvOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvOrdenCompra.Rows[e.RowIndex];
                int numOrdenCompra = Convert.ToInt32(dgvOrdenCompra.Rows[e.RowIndex].Cells[1].Value);
                txtNumOrden.Text = filaActual.Cells[1].Value.ToString();
                entDetalleOrdenCompra DOC = new entDetalleOrdenCompra();
                DOC.NumOrdenCompra = numOrdenCompra;
                dgvDetalleOrdenCompra.DataSource = logDetalleOrdenCompra.Instancia.OrdenaDetalleCompra(DOC);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }

        private void btnBuscarNE_Click(object sender, EventArgs e)
        {
            try
            {
                entNotaEntrada NotaEntrada = new entNotaEntrada();
                NotaEntrada.fechaEmision = dtpBuscarFecha.Value;
                dgvNotaEntrada.DataSource = logNotaEntrada.Instancia.BuscaFecha(NotaEntrada);
                if (dgvNotaEntrada.Rows.Count == 0)
                {
                    MessageBox.Show("NO existen Notas De Entrada de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarNotaEntrada();
                    LimpiarVariables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbNotaEntrada.Enabled = true;
            LimpiarVariables();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDNotaEntrada.Text.Equals("") | txtNNotaEntrada.Text.Equals("") | txtNumOrden.Text.Equals("") )
                {
                    MessageBox.Show("Deben estar llenos los campos ID Nota Entrada, Numero Nota Entrada y Numero Orden Compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entNotaEntrada notaentrada = new entNotaEntrada();
                    notaentrada.idNotaEntrada = Convert.ToInt32(txtIDNotaEntrada.Text);
                    logNotaEntrada.Instancia.DeshabilitarNotaEntrada(notaentrada.idNotaEntrada);
                    MessageBox.Show("Nota de Entrada inhabilitado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarNotaEntrada();
                    LimpiarVariables();
                    gbNotaEntrada.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNotaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvNotaEntrada.Rows[e.RowIndex];
            txtIDNotaEntrada.Text = filaActual.Cells[0].Value.ToString();
            txtNNotaEntrada.Text = filaActual.Cells[1].Value.ToString();
            dtpFechaNotaEntrada.Text = filaActual.Cells[2].Value.ToString();
            txtNumOrden.Text = filaActual.Cells[3].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }
    }
}
