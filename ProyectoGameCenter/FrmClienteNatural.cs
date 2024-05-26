using AccesoDatos;
using ClosedXML.Excel;
using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    public partial class FrmClienteNatural : Form
    {
        private logDniRuc logDniRuc;
        public FrmClienteNatural()
        {
            InitializeComponent();
            ListarClientesNaturales();
            logDniRuc = new logDniRuc();
        }

        private void btnAgregarCN_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAgregarCN_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregarCN_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.DarkViolet;
        }

        private void btnModificarCN_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificarCN_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.DarkViolet;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.DarkViolet;
        }

        private void btnNuevoCN_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevoCN_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.ForeColor = Color.DarkViolet;
        }

        private void btnEditarCN_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.White;
        }

        private void btnEditarCN_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.DarkViolet;
        }

        private void btnEliminarCN_MouseEnter(object sender, EventArgs e)
        {
            btnInhabilitarCliNat.ForeColor = Color.White;
        }

        private void btnEliminarCN_MouseLeave(object sender, EventArgs e)
        {
            btnInhabilitarCliNat.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.DarkViolet;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text.Equals("") | txtNombres.Text.Equals("") | txtApellidoPaterno.Text.Equals("") | txtApellidoMaterno.Text.Equals("") | 
                    txtTelefono.Text.Equals("") )
                {
                    MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.DNI = txtDNI.Text;
                    if(cliente.DNI.Length != 8)
                    {
                        MessageBox.Show("El DNI debe tener 8 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cliente.NOMBRE_CLI = txtNombres.Text;
                    cliente.APELLIDO_PATERNO = txtApellidoPaterno.Text;
                    cliente.APELLIDO_MATERNO = txtApellidoMaterno.Text;
                    cliente.TEL_CLIENTE = txtTelefono.Text;                    
                    cliente.ESTADO_CLIENTE = cbxEstadoCliNat.Checked;
                    logClienteNatural.Instancia.InsertarClienteNatural(cliente);
                    MessageBox.Show("Cliente Natural registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarClientesNaturales();
            LimpiarVariables();
            gbClientesNatural.Enabled = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MODIFICAR CLIENTE NATURAL
            if (txtDNI.Text.Equals("") | txtNombres.Text.Equals("") | txtApellidoPaterno.Text.Equals("") | txtApellidoMaterno.Text.Equals("") |
                    txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entClienteNatural cliente = new entClienteNatural();
                cliente.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text);
                cliente.DNI = txtDNI.Text;
                cliente.NOMBRE_CLI = txtNombres.Text;
                cliente.APELLIDO_PATERNO = txtApellidoPaterno.Text;
                cliente.APELLIDO_MATERNO = txtApellidoMaterno.Text;
                cliente.TEL_CLIENTE = txtTelefono.Text;
                cliente.ESTADO_CLIENTE = cbxEstadoCliNat.Checked;
                logClienteNatural.Instancia.EditarClienteNatural(cliente);
                MessageBox.Show("Cliente Natural modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientesNaturales();
                LimpiarVariables();
                gbClientesNatural.Enabled = false;
            }
        }
        public void ListarClientesNaturales()
        {
            dgvClienteNatural.DataSource = logClienteNatural.Instancia.ListarClienteNatural();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbClientesNatural.Enabled = true;
            txtIDCliente.Enabled = false;
            btnModificar.Visible = false;
            LimpiarVariables();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbClientesNatural.Enabled = true;
            txtIDCliente.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }
        private void LimpiarVariables()
        {
            txtIDCliente.Clear();
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtTelefono.Clear();
            txtBuscarDNI.Clear();
            cbxEstadoCliNat.Checked = false;
        }

        private void dgvClienteNatural_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvClienteNatural.Rows[e.RowIndex];
                txtIDCliente.Text = filaActual.Cells[4].Value.ToString();
                txtDNI.Text = filaActual.Cells[0].Value.ToString();
                txtNombres.Text = filaActual.Cells[1].Value.ToString();
                txtApellidoPaterno.Text = filaActual.Cells[2].Value.ToString();
                txtApellidoPaterno.Text = filaActual.Cells[3].Value.ToString();
                txtTelefono.Text = filaActual.Cells[5].Value.ToString();             
                cbxEstadoCliNat.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbClientesNatural.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            LimpiarVariables();
        }

        private void btnInhabilitarCliNat_Click(object sender, EventArgs e)
        {
            //DESHABILITAR CLIENTE NATURAL
            if (txtIDCliente.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entClienteNatural cliente = new entClienteNatural();
                cliente.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text);
                logClienteNatural.Instancia.DeshabilitarClienteNatural(cliente);
                MessageBox.Show("Cliente Natural inhabilitado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientesNaturales();
                LimpiarVariables();
                gbClientesNatural.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnBuscarCliNat_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtBuscarDNI.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.DNI = txtBuscarDNI.Text;
                    dgvClienteNatural.DataSource = logClienteNatural.Instancia.BuscarDniClienteNatural(cliente);
                    if (dgvClienteNatural.Rows.Count == 0)
                    {
                        MessageBox.Show("El cliente no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientesNaturales();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            
        }

        private void txtBuscarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarDNI.Text == "")
            {
                dgvClienteNatural.DataSource = logClienteNatural.Instancia.ListarClienteNatural();
            }
        }

        private void btnBuscarClienteReniec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarDNI.Text.Length == 8)
                {
                    entDatosDni respuesta = logDniRuc.ObtenerDatosDNI(txtBuscarDNI.Text);
                    txtNombres.Text = respuesta.Nombres;
                    txtApellidoPaterno.Text = respuesta.ApellidoPaterno;
                    txtApellidoMaterno.Text = respuesta.ApellidoMaterno;
                    txtDNI.Text = respuesta.DNI;
                }
                else
                {
                    MessageBox.Show("El número de DNI debe tener 8 caracteres.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel();
        }

        private void ExportarDatosAExcel()
        {
            // Crear un DataTable y agregar las columnas necesarias
            DataTable dt = new DataTable();
            dt.Columns.Add("DNI");
            dt.Columns.Add("NOMBRES");
            dt.Columns.Add("APELLIDO PATERNO");
            dt.Columns.Add("APELLIDOS MATERNO");
            dt.Columns.Add("TELEFONO");

            // Llenar el DataTable con los datos del DataGridView
            foreach (DataGridViewRow row in dgvClienteNatural.Rows)
            {
                if (row.IsNewRow) continue;
                dt.Rows.Add(
                    row.Cells["DNI"].Value,
                    row.Cells["NOMBRE_CLI"].Value,
                    row.Cells["APELLIDO_PATERNO"].Value,
                    row.Cells["APELLIDO_MATERNO"].Value,
                    row.Cells["TEL_CLIENTE"].Value
                );
            }

            // Crear un nuevo archivo Excel y agregar los datos del DataTable
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "ClientesNaturales");

                // Guardar el archivo Excel en una ubicación específica
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "ClientesNaturales.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ImportarExcel_Click(object sender, EventArgs e)
        {
            ImportarDatosDesdeExcel();
            ListarClientesNaturales();
        }

        private void ImportarDatosDesdeExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";
            openFileDialog.Title = "Seleccionar archivo Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed();

                    using (SqlConnection connection = Conexion.Instancia.Conectar())
                    {
                        connection.Open();

                        foreach (var row in rows)
                        {
                            string dniCliente = row.Cell(1).GetValue<string>();
                            string nombreCliente = row.Cell(2).GetValue<string>();
                            string apellidoPaterno = row.Cell(3).GetValue<string>();
                            string apellidoMaterno = row.Cell(4).GetValue<string>();
                            string telefono = row.Cell(5).GetValue<string>();

                            // Insertar el producto
                            string queryClienteNatural = @"
                                -- Insertar datos en la tabla CLIENTE
                                INSERT INTO CLIENTE (ESTADO_CLIENTE, TEL_CLIENTE)
                                VALUES (1, @TEL_CLIENTE);

                                -- Obtener el último ID_CLIENTE insertado
                                DECLARE @ID_CLIENTE INT;
                                SET @ID_CLIENTE = SCOPE_IDENTITY();

                                -- Insertar datos en la tabla CLIENTE_NATURAL
                                INSERT INTO CLIENTE_NATURAL (ID_CLIENTE, DNI, NOMBRE_CLI, APELLIDO_PATERNO, APELLIDO_MATERNO)
                                VALUES (@ID_CLIENTE, @DNI, @NOMBRE_CLI, @APELLIDO_PATERNO,@APELLIDO_MATERNO)";

                            using (SqlCommand cmdProducto = new SqlCommand(queryClienteNatural, connection))
                            {
                                cmdProducto.Parameters.AddWithValue("@DNI", dniCliente);
                                cmdProducto.Parameters.AddWithValue("@NOMBRE_CLI", nombreCliente);
                                cmdProducto.Parameters.AddWithValue("@APELLIDO_PATERNO", apellidoPaterno);
                                cmdProducto.Parameters.AddWithValue("@APELLIDO_MATERNO", apellidoMaterno);
                                cmdProducto.Parameters.AddWithValue("@TEL_CLIENTE", telefono);

                                cmdProducto.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                    }

                    MessageBox.Show("Datos importados exitosamente.", "Importar desde Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
