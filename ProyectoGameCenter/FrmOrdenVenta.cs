using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using System.Data.SqlClient;
using System.Windows.Markup.Localizer;
using AccesoDatos;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using System.Windows.Media;
using System.IO;
using System.Net;

namespace ProyectoGameCenter
{
    public partial class FrmOrdenVenta : Form
    {
        private logCliente clienteLogic;
        private decimal total = 0;
        private decimal Subtotal = 0;
        private double igv = 0;
        public static string nOrdenVenta;
        public static string totalCR;
        public static string idCliente;
        public FrmOrdenVenta()
        {

            InitializeComponent();
            LlenarDatosEstadoOrdenVenta();
            ListarVentas();
            LlenarDatosTipoComprobante();
            LlenarDatosMetodoPago();
            LlenarDatosTipoPago();
            clienteLogic = new logCliente();

        }

        public void ListarVentas()
        {
            dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.ListarVentas();
        }


        public void ListarDetalleVentas()
        {
            dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.ListarDetalleOrdenVenta();
        }

        public void LlenarDatosEstadoOrdenVenta()
        {
            cboEstado.DataSource = logEstadoOrdenVenta.Instancia.ListaEstadoOrdenVenta();
            cboEstado.DisplayMember = "DES_ESTADO_OV";
            cboEstado.ValueMember = "ID_EST_ORDEN_VENTA";
        }

        public void LlenarDatosMetodoPago()
        {
            cboMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
            cboMetodoPago.DisplayMember = "DES_METODO_PAGO";
            cboMetodoPago.ValueMember = "ID_METODO_PAGO";
        }

        public void LlenarDatosTipoPago()
        {
            cboTipoPago.DataSource = logTipoPago.Instancia.ListarTipoPago();
            cboTipoPago.DisplayMember = "DES_TIPO_PAGO";
            cboTipoPago.ValueMember = "ID_TIPO_PAGO";
        }

        public void LlenarDatosTipoComprobante()
        {
            cboTipoComprobante.DataSource = logTipoComprobante.Instancia.ListarTipoComprobante();
            cboTipoComprobante.DisplayMember = "DES_TIPO_COMPROBANTE";
            cboTipoComprobante.ValueMember = "ID_TIPO_COMPROBANTE";
        }

        public void LimpiarVariables()
        {
            txtIDOrdenVenta.Text = "";
            dtpFechaOrden.ResetText();
            txtResultadoBusquedaCliente.Text = "";
            txtDocumentoCliente.Text = string.Empty;
            cboEstado.SelectedIndex = default;

        }

        public void LimpiarImportes()
        {
            txtSubTotal.Text = "";
            txtIgv.Text = "";
            txtTotal.Text = "";
            cboMetodoPago.SelectedIndex = default;
            cboTipoPago.SelectedIndex = default;

        }

        public void LimpiarVariablesDetalle()
        {
            txtIDProducto.Text = "";
            txtDesProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioVenta.Text = "";
            txtPrecioCompra.Text = string.Empty;
            txtStock.Text = "";
        }



        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Busca Producto
                entProducto entProducto = new entProducto();
                entProducto = logProducto.Instancia.BuscarProducto(txtDesProducto.Text.ToString());
                if (entProducto != null)
                {
                    txtDesProducto.Text = entProducto.DES_PRODUCTO.ToString();
                    txtIDProducto.Text = entProducto.ID_PRODUCTO.ToString();
                    txtStock.Text = entProducto.STOCK.ToString();
                    txtPrecioVenta.Text = entProducto.PRECIO_VENTA.ToString();
                    txtPrecioCompra.Text = entProducto.PRECIO_COMPRA.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no existe", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void btnBuscaridCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(txtDocumentoCliente.Text);

                string identificacion = clienteLogic.ObtenerIdentificacionClientePorID(idCliente);

                if (!string.IsNullOrEmpty(identificacion))
                {
                    txtResultadoBusquedaCliente.Text = identificacion;
                }
                else
                {
                    txtResultadoBusquedaCliente.Text = "No se encontró el cliente.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente no existe");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        public void bloqueartxtOrdenVenta()
        {
            txtNOrdenVenta.Enabled = false;
            txtIDOrdenVenta.Enabled = false;
            dtpFechaOrden.Enabled = false;
            txtResultadoBusquedaCliente.Enabled = false;
            txtNOrdenVenta.Enabled = false;
            txtIDOrdenVenta.Enabled = false;
            cboEstado.Enabled = false;
            cboTipoComprobante.Enabled = false;
            btnBuscaridCliente.Enabled = false;
            btnAgregarOrdenVenta.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbOrdenVenta.Enabled = true;
            gbDetalleOrdenVenta.Enabled = false;
            txtNOrdenVenta.Enabled = false;
            txtNOrdenVenta.Text = string.Empty;
            txtIDOrdenVenta.Enabled = false;
            dtpFechaOrden.Enabled = false;
            txtResultadoBusquedaCliente.Enabled = false;
            dgvDetalleOrdenVenta.DataSource = null;
            dgvDetalleOrdenVenta.Rows.Clear();
            dgvDetalleOrdenVenta.Columns.Clear();
            LimpiarVariables();
            LimpiarImportes();
            LimpiarVariablesDetalle();

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenVenta.SelectedRows.Count > 0)
                {
                    entOrdenVenta c = new entOrdenVenta();
                    c.idOrdenVenta = int.Parse(txtIDOrdenVenta.Text.Trim());
                    logOrdenVenta.Instancia.AnulaOrdenVenta(c);
                }
                else
                {
                    MessageBox.Show("Escoge un elemento primero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            txtNOrdenVenta.Text = "";
            ListarVentas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNOrdenVenta.Text = "";
            LimpiarVariables();
        }

        private void dgvOrdenVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvOrdenVenta.Rows[e.RowIndex];
                string numOrdenVenta = (string)dgvOrdenVenta.Rows[e.RowIndex].Cells[1].Value;
                txtIDOrdenVenta.Text = filaActual.Cells[0].Value.ToString();
                txtNOrdenVenta.Text = filaActual.Cells[1].Value.ToString();
                dtpFechaOrden.Text = filaActual.Cells[2].Value.ToString();
                txtDocumentoCliente.Text = filaActual.Cells[5].Value.ToString();
                cboEstado.SelectedValue = Convert.ToInt32(filaActual.Cells[4].Value);
                cboTipoComprobante.SelectedValue = Convert.ToInt32(filaActual.Cells[6].Value);


                entDetalleOrdenVenta DOV = new entDetalleOrdenVenta();
                DOV.NUM_ORDEN_VENTA = numOrdenVenta;
                dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.OrdenaDetalleVenta(DOV);
                gbDetalleOrdenVenta.Enabled = true;
                txtIDProducto.Enabled = false;
                txtCantidad.Enabled = true;
                btnAgregarProducto.Enabled = true;
                btnFinalizar.Enabled = true;
                btnBuscarProducto.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleOrdenVenta DetalleOV = new entDetalleOrdenVenta();
                DetalleOV.NUM_ORDEN_VENTA = txtNOrdenVenta.Text.Trim();
                DetalleOV.ID_PRODUCTO = int.Parse(txtIDProducto.Text.Trim());
                DetalleOV.DESCRIPCION_PROD = txtDesProducto.Text.Trim();
                DetalleOV.CANTIDAD = int.Parse(txtCantidad.Text.Trim());
                DetalleOV.PRECIO = decimal.Parse(txtPrecioVenta.Text.Trim());
                DetalleOV.PRECIO_TOTAL = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioVenta.Text);


                // Llamar a la función InsertarCliente
                Boolean insertado = logDetalleOrdenVenta.Instancia.InsertaDetalleOrdenVenta(DetalleOV);

                if (insertado)
                {
                    MessageBox.Show("El Producto se agregó exitosamente al DETALLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Subtotal = Subtotal + (int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioVenta.Text));
                    txtSubTotal.Text = Subtotal.ToString();
                    igv = double.Parse(txtSubTotal.Text) * 0.18;
                    txtIgv.Text = igv.ToString();
                    total = decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtIgv.Text);
                    txtTotal.Text = total.ToString();
                    DetalleOV.NUM_ORDEN_VENTA = txtNOrdenVenta.Text;
                    dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.OrdenaDetalleVenta(DetalleOV);
                    if (dgvDetalleOrdenVenta.Rows.Count == 0)
                    {
                        MessageBox.Show("Hola ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LimpiarVariablesDetalle();
                }
                else
                {
                    MessageBox.Show("No hay STOCK SUFICIENTE de ese PRODUCTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LimpiarVariablesDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbOrdenVenta.Enabled = false;
            gbDetalleOrdenVenta.Enabled = false;
        }

        private void btnCPago_Click(object sender, EventArgs e)
        {
            idCliente = txtDocumentoCliente.Text;
            nOrdenVenta = txtNOrdenVenta.Text;
            totalCR = txtTotal.Text;
            FrmCronogramaPago Cpago = new FrmCronogramaPago();
            Cpago.StartPosition = FormStartPosition.CenterScreen;
            Cpago.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariablesDetalle();
            txtNOrdenVenta.Clear();
            txtDocumentoCliente.Clear();
            dgvDetalleOrdenVenta.DataSource = null;
            dgvDetalleOrdenVenta.Rows.Clear();
            dgvDetalleOrdenVenta.Columns.Clear();
            //ListarVentas();
            dgvDetalleOrdenVenta.Enabled = false;
            txtIDProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregarProducto.Enabled = true;
            btnFinalizar.Enabled = true;
            btnBuscarProducto.Enabled = true;
            gbDetalleOrdenVenta.Enabled = false;
        }

        private void btnAgregarOrdenVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumentoCliente.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string tipoComprobante = cboTipoComprobante.Text;
                    if (tipoComprobante == "BOLETA")
                    {
                        if (txtDocumentoCliente.Text.Length == 8)
                        {
                            entOrdenVenta ordVenta = new entOrdenVenta();
                            //ordVenta.numOrdenVenta = Convert.ToInt32(txtNOrdenVenta.Text.Trim());
                            ordVenta.fechaOrden = dtpFechaOrden.Value;
                            ordVenta.num_documento = txtDocumentoCliente.Text.ToString();
                            ordVenta.estOrdenVenta = Convert.ToInt32(cboEstado.SelectedValue);
                            ordVenta.idTipoComprobante = Convert.ToInt32(cboTipoComprobante.SelectedValue);
                            cboMetodoPago.Enabled = true;
                            cboTipoPago.Enabled = true;

                            logOrdenVenta.Instancia.InsertaOrdenVenta(ordVenta);
                            gbDetalleOrdenVenta.Enabled = true;
                            gbImportes.Enabled = true;
                            MessageBox.Show("Orden de Venta registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione Factura para usar un RUC");
                        }
                    }
                    else
                    {
                        if (txtDocumentoCliente.Text.Length == 11)
                        {
                            entOrdenVenta ordVenta = new entOrdenVenta();
                            //ordVenta.numOrdenVenta = Convert.ToInt32(txtNOrdenVenta.Text.Trim());
                            ordVenta.fechaOrden = dtpFechaOrden.Value;
                            ordVenta.num_documento = txtDocumentoCliente.Text.ToString();
                            ordVenta.estOrdenVenta = Convert.ToInt32(cboEstado.SelectedValue);
                            ordVenta.idTipoComprobante = Convert.ToInt32(cboTipoComprobante.SelectedValue);
                            cboMetodoPago.Enabled = false;
                            cboTipoPago.Enabled = false;

                            logOrdenVenta.Instancia.InsertaOrdenVenta(ordVenta);
                            gbDetalleOrdenVenta.Enabled = true;
                            gbImportes.Enabled = true;
                            MessageBox.Show("Orden de Venta registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione Boleta para usar un DNI");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            
            ListarVentas();
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            #region Verificacion y Generacion XML
            DateTimeOffset fechaHoraActual = DateTimeOffset.Now;
            string fechaHoraStr = fechaHoraActual.ToString("yyyy-MM-ddTHH:mm:sszzz");
            string metodoPagoID = cboMetodoPago.Text;
            string tipoPagoID = cboTipoPago.Text;
            string idventa = txtNOrdenVenta.Text;
            string correlativoStr = idventa.TrimStart('0');
            string docCliente = txtDocumentoCliente.Text;

            string nombreArchivo = string.Empty, nombrePDF = string.Empty, direccion = "", provincia = "", departamento = "", distrito = "", ubigeo = "", json = string.Empty;

            string idProd = dgvDetalleOrdenVenta.Rows[0].Cells[1].Value.ToString();
            int cantProd = (int)dgvDetalleOrdenVenta.Rows[0].Cells[3].Value;
            string desProd = dgvDetalleOrdenVenta.Rows[0].Cells[2].Value.ToString();
            decimal precioProducto = (decimal)dgvDetalleOrdenVenta.Rows[0].Cells[4].Value;
            decimal precioFinal = precioProducto * cantProd * 1.18m;
            decimal ultimoDigito = precioFinal - Math.Truncate(precioFinal);
            decimal valorRedondeado;

            if (ultimoDigito >= 0.5m)
            {
                valorRedondeado = Math.Ceiling(precioFinal * 10) / 10; // Redondea hacia arriba
            }
            else
            {
                valorRedondeado = Math.Floor(precioFinal * 10) / 10; // Redondea hacia abajo
            }

            string url = "https://facturacion.apisperu.com/api/v1/invoice/send";
            string token = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpYXQiOjE2OTUyNzY5NjgsImV4cCI6NDg0ODg3Njk2OCwidXNlcm5hbWUiOiJkb2dleiIsImNvbXBhbnkiOiIyMDUyMzgwODcxMSJ9.Z7DbsYMV-IK2R26cHxxyXXeVXJbt8lH9TCpfmGc_WRPyqxM1CTKoy3NP15Edw3pIQyLPw01pV3O7LKthZVzFWcXkGQlzfRkmAwyrOK0j6D2JKiX71Frct70OM3ikQ1JwurMkwoaxkgOcpL9azy5HB6SLAWzsgz4eSBSCw0oyWc-XSYA12_hyQhQUpPxnz6Q4UfBjXWMoGwHpqjIuYswRAcIdFIVL0uvjhhck51wGuwGWaaZEsiBh40caZnptJ0Pf-3pvnK63kgx34pdksknADw_HyFzOTTUro6pFuLxNj1A1HMg733JCwVjGqMqo5Ewx3vBNj1P2PoA06zqU3qs6ziWdhWkwZYqG4VZro1MYKGKca0ucAih5sK5eQcJhBuiDZk4oJwCe1vKtLM0AumF5yrpzFfcDRu3OeeAA62mqUosWAHr0HSaOz5WQCsP9VmquizhX6gNAoyQ1hQKSTk7-vZVuV3rwneN06f3bTOZtAFi5X-_tjjq6d4Ucfl85glgjj-y6ivKXkM1I1cV5QBboIPEn_jC77SRydQ4PN1w-HnIG_-dLvTepba0kLDOAxL_9Fugn0cYazfdOHTdVMNiTpL5drxaOC4ieVGo_5Qdc3TFBte13Dc3Mb0gTB308PKbzn5isUc9PvrYdCXTlJCaCBDmJiJ5Cp-XRpEu7fc0exKE";

            if (txtResultadoBusquedaCliente.Text != string.Empty) {

                if(txtDocumentoCliente.Text.Length == 8)
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.DNI = txtDocumentoCliente.Text;
                    List<entClienteNatural> resultado = logClienteNatural.Instancia.BuscarDniClienteNatural(cliente);

                    if (resultado.Count > 0)
                    {
                        txtResultadoBusquedaCliente.Text = resultado[0].NOMBRE_CLI + " " +  resultado[0].APELLIDO_PATERNO + " " +  resultado[0].APELLIDO_MATERNO;

                        #region Cuerpo Solicitud Boleta

                        var bodyBoleta = new
                        {
                            ublVersion = "2.1",
                            tipoOperacion = "0101",
                            tipoDoc = "03",
                            serie = "B001",
                            correlativo = correlativoStr,
                            fechaEmision = fechaHoraStr,
                            formaPago = new
                            {
                                moneda = "PEN",
                                tipo = metodoPagoID + ", " + tipoPagoID
                            },
                            tipoMoneda = "PEN",
                            client = new
                            {
                                tipoDoc = "1",
                                numDoc = Int64.Parse(docCliente),
                                rznSocial = txtResultadoBusquedaCliente.Text,
                                address = new
                                {
                                    direccion = "",
                                    provincia = "",
                                    departamento = "",
                                    distrito = "",
                                    ubigueo = ""
                                }
                            },
                            company = new
                            {
                                ruc = 20523808711,
                                razonSocial = "GAME CENTER S.A.C.",
                                nombreComercial = "GAME CENTER S.A.C.",
                                address = new
                                {
                                    direccion = "JR. GARCIA NARANJO NRO. 75 INT. 17 URB. LA VICTORIA",
                                    provincia = "LIMA",
                                    departamento = "LIMA",
                                    distrito = "LA VICTORIA",
                                    ubigueo = "150115"
                                }
                            },
                            mtoOperGravadas = precioProducto * cantProd,
                            mtoIGV = precioFinal - (precioProducto * cantProd),
                            valorVenta = precioProducto * cantProd,
                            totalImpuestos = precioFinal - (precioProducto * cantProd),
                            subTotal = Convert.ToDecimal(valorRedondeado),
                            mtoImpVenta = valorRedondeado,

                            details = new[]
                            {
                    new
                    {
                        codProducto = "P" + idProd,
                        unidad = "NIU",
                        descripcion = desProd,
                        cantidad = cantProd,
                        mtoValorUnitario = precioProducto,
                        mtoValorVenta = precioProducto*cantProd,
                        mtoBaseIgv = precioProducto*cantProd,
                        porcentajeIgv = 18,
                        igv = precioFinal - (precioProducto*cantProd),
                        tipAfeIgv = 10,
                        totalImpuestos = precioFinal - (precioProducto*cantProd),
                        mtoPrecioUnitario = precioProducto*1.18m
                    }
                },

                            legends = new[]
                        {
                new
                {
                    code = "1000",
                    value = "SON " + valorRedondeado.NumeroALetras()
                }
            }

                        };

                        #endregion
                        json = JsonConvert.SerializeObject(bodyBoleta);

                        nombreArchivo = docCliente + "-03-B" + idventa + ".zip"; //"NroRUC_DNI-TIPODECOMPROBANTE-SERIE-CORRELATIVO";

                        nombrePDF = docCliente + "-03-B" + idventa + ".pdf";
                    }
                    else
                    {
                        txtResultadoBusquedaCliente.Text = string.Empty;
                        MessageBox.Show("No se encontraron resultados para el DNI ingresado.");
                    }      
                }
                else if (txtDocumentoCliente.Text.Length == 11)
                {
                    entClienteJuridico cliente = new entClienteJuridico();
                    cliente.RUC_CLIENTE = txtDocumentoCliente.Text;
                    List<entClienteJuridico> resultado = logClienteJuridico.Instancia.BuscarDniClienteJuridico(cliente);

                    if (resultado.Count > 0)
                    {
                        txtResultadoBusquedaCliente.Text = resultado[0].RAZON_SOCIAL;
                        direccion = resultado[0].DIRECCION;
                        provincia = resultado[0].PROVINCIA;
                        departamento = resultado[0].DEPARTAMENTO;
                        distrito = resultado[0].DISTRITO;


                        #region Cuerpo Solicitud Factura

                        var bodyFactura = new
                        {
                            ublVersion = "2.1",
                            fecVencimiento = fechaHoraStr,
                            tipoOperacion = "0101",
                            tipoDoc = "01",
                            serie = "F001",
                            correlativo = correlativoStr,
                            fechaEmision = fechaHoraStr,
                            formaPago = new
                            {
                                moneda = "PEN",
                                tipo = "Contado"
                            },
                            tipoMoneda = "PEN",
                            client = new
                            {
                                tipoDoc = "6",
                                numDoc = Int64.Parse(docCliente),
                                rznSocial = txtResultadoBusquedaCliente.Text,
                                address = new
                                {
                                    direccion = direccion,
                                    provincia = provincia,
                                    departamento = departamento,
                                    distrito = distrito,
                                }
                            },
                            company = new
                            {
                                ruc = 20523808711,
                                razonSocial = "GAME CENTER S.A.C.",
                                nombreComercial = "GAME CENTER S.A.C.",
                                address = new
                                {
                                    direccion = "JR. GARCIA NARANJO NRO. 75 INT. 17 URB. LA VICTORIA",
                                    provincia = "LIMA",
                                    departamento = "LIMA",
                                    distrito = "LA VICTORIA",
                                    ubigueo = "150115"
                                }
                            },
                            mtoOperGravadas = precioProducto * cantProd,
                            mtoIGV = precioFinal - (precioProducto * cantProd),
                            valorVenta = precioProducto * cantProd,
                            totalImpuestos = precioFinal - (precioProducto * cantProd),
                            subTotal = Convert.ToDecimal(valorRedondeado),
                            mtoImpVenta = valorRedondeado,

                            details = new[]
                        {
                    new
                    {
                        codProducto = "P" + idProd,
                        unidad = "NIU",
                        descripcion = desProd,
                        cantidad = cantProd,
                        mtoValorUnitario = precioProducto,
                        mtoValorVenta = precioProducto*cantProd,
                        mtoBaseIgv = precioProducto*cantProd,
                        porcentajeIgv = 18,
                        igv = precioFinal - (precioProducto*cantProd),
                        tipAfeIgv = 10,
                        totalImpuestos = precioFinal - (precioProducto*cantProd),
                        mtoPrecioUnitario = precioProducto*1.18m
                    }
                },

                            legends = new[]
                    {
                new
                {
                    code = "1000",
                    value = "SON " + valorRedondeado.NumeroALetras()
                }
            }

                        };

                        #endregion
                        json = JsonConvert.SerializeObject(bodyFactura);

                        nombreArchivo = docCliente + "-03-F" + idventa + ".zip"; //"NroRUC_DNI-TIPODECOMPROBANTE-SERIE-CORRELATIVO";

                        nombrePDF = docCliente + "-03-F" + idventa + ".pdf";
                    }
                    else
                    {
                        txtResultadoBusquedaCliente.Text = string.Empty;
                        MessageBox.Show("No se encontraron resultados para el RUC ingresado.");
                    }
                }

            }
            else {
                MessageBox.Show("Seleccione una fila primero");
            }       

            dynamic response = logDniRuc.Post(url, json, token);

            Console.WriteLine(response.ToString());

            if (!Convert.ToBoolean(response.sunatResponse.success))
            {
                MessageBox.Show("Exito");
                return;
            }

            MessageBox.Show(response.sunatResponse.cdrResponse.description.ToString());


            string ruta = SaveDialog(nombreArchivo);

            decimal demo = 118.00m;
            Console.WriteLine("SON " + demo.NumeroALetras());

            if (ruta != "")
            {
                bool exito = logDniRuc.Base64ToFile(response.sunatResponse.cdrZip.ToString(), ruta);

                if (exito == true)
                {
                    MessageBox.Show("El archivo CDR se ha guardado correctamente en " + ruta);
                }
                else { MessageBox.Show("Error al guardar el CDR"); }
            }
            #endregion

            #region Generador PDF


            url = "https://facturacion.apisperu.com/api/v1/invoice/pdf";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("Authorization", token);
            request.ContentType = "application/json";

            byte[] postData = System.Text.Encoding.UTF8.GetBytes(json);

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(postData, 0, postData.Length);
            }

            using (HttpWebResponse response2 = (HttpWebResponse)request.GetResponse())
            {
                if (response2.StatusCode == HttpStatusCode.OK)
                {
                    // Archivo PDF generado por la API
                    using (Stream pdfStream = response2.GetResponseStream())
                    {
                        string filePath = SaveDialog(nombrePDF);

                        if (!string.IsNullOrEmpty(filePath))
                        {
                            // Guardar el archivo PDF en el sistema de archivos
                            using (FileStream fileStream = System.IO.File.Create(filePath))
                            {
                                pdfStream.CopyTo(fileStream);
                            }

                            MessageBox.Show("El archivo PDF se ha guardado correctamente en " + filePath);
                        }
                        else
                        {
                            MessageBox.Show("La operación de guardado fue cancelada por el usuario.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error en la respuesta de la API: " + response2.StatusDescription);
                }


            }

                #endregion
            }


        private void btnBuscaridCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumentoCliente.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un Documento Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtDocumentoCliente.Text.Length == 8)
                    {
                        entClienteNatural cliente = new entClienteNatural();
                        cliente.DNI = txtDocumentoCliente.Text;
                        List<entClienteNatural> resultado = logClienteNatural.Instancia.BuscarDniClienteNatural(cliente);

                        if (resultado.Count > 0)
                        {
                            // Suponiendo que tienes TextBox llamados txtNombre y txtApellido en tu formulario
                            txtResultadoBusquedaCliente.Text = resultado[0].NOMBRE_CLI + " " + resultado[0].APELLIDO_PATERNO + " " + resultado[0].APELLIDO_MATERNO;
                        }
                        else
                        {
                            // Si no se encontraron resultados, puedes mostrar un mensaje de error o limpiar los TextBox.
                            txtResultadoBusquedaCliente.Text = string.Empty;
                            MessageBox.Show("No se encontraron resultados para el DNI ingresado.");
                        }
                    }

                    else if (txtDocumentoCliente.Text.Length == 11)
                    {
                        entClienteJuridico cliente = new entClienteJuridico();
                        cliente.RUC_CLIENTE = txtDocumentoCliente.Text;
                        List<entClienteJuridico> resultado = logClienteJuridico.Instancia.BuscarDniClienteJuridico(cliente);

                        if (resultado.Count > 0)
                        {
                            // Suponiendo que tienes TextBox llamados txtNombre y txtApellido en tu formulario
                            txtResultadoBusquedaCliente.Text = resultado[0].RAZON_SOCIAL;
                        }
                        else
                        {
                            // Si no se encontraron resultados, puedes mostrar un mensaje de error o limpiar los TextBox.
                            txtResultadoBusquedaCliente.Text = string.Empty;
                            MessageBox.Show("No se encontraron resultados para el RUC ingresado.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Los documentos deben tener 8 u 11 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        public static string SaveDialog(string nombreAchivo)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "All files (*.*)|*.*";
                save.FileName = nombreAchivo;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string path = save.FileName;

                    return path;
                }

                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void dgvOrdenVenta_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvOrdenVenta.Rows[e.RowIndex];
                string numOrdenVenta = (string)dgvOrdenVenta.Rows[e.RowIndex].Cells[1].Value;
                txtIDOrdenVenta.Text = filaActual.Cells[0].Value.ToString();
                txtNOrdenVenta.Text = filaActual.Cells[1].Value.ToString();
                dtpFechaOrden.Text = filaActual.Cells[2].Value.ToString();
                txtDocumentoCliente.Text = filaActual.Cells[5].Value.ToString();
                cboEstado.SelectedValue = Convert.ToInt32(filaActual.Cells[4].Value);
                cboTipoComprobante.SelectedValue = Convert.ToInt32(filaActual.Cells[6].Value);

                if (txtDocumentoCliente.Text.Length == 8)
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.DNI = txtDocumentoCliente.Text;
                    List<entClienteNatural> resultado = logClienteNatural.Instancia.BuscarDniClienteNatural(cliente);

                    if (resultado.Count > 0)
                    {
                        // Suponiendo que tienes TextBox llamados txtNombre y txtApellido en tu formulario
                        txtResultadoBusquedaCliente.Text = resultado[0].NOMBRE_CLI + " " + resultado[0].APELLIDO_PATERNO + " " + resultado[0].APELLIDO_MATERNO;
                    }
                    else
                    {
                        // Si no se encontraron resultados, puedes mostrar un mensaje de error o limpiar los TextBox.
                        txtResultadoBusquedaCliente.Text = string.Empty;
                        MessageBox.Show("No se encontraron resultados para el DNI ingresado.");
                    }
                }

                else if (txtDocumentoCliente.Text.Length == 11)
                {
                    entClienteJuridico cliente = new entClienteJuridico();
                    cliente.RUC_CLIENTE = txtDocumentoCliente.Text;
                    List<entClienteJuridico> resultado = logClienteJuridico.Instancia.BuscarDniClienteJuridico(cliente);

                    if (resultado.Count > 0)
                    {
                        // Suponiendo que tienes TextBox llamados txtNombre y txtApellido en tu formulario
                        txtResultadoBusquedaCliente.Text = resultado[0].RAZON_SOCIAL;
                    }
                    else
                    {
                        // Si no se encontraron resultados, puedes mostrar un mensaje de error o limpiar los TextBox.
                        txtResultadoBusquedaCliente.Text = string.Empty;
                        MessageBox.Show("No se encontraron resultados para el RUC ingresado.");
                    }
                }

                entDetalleOrdenVenta DOV = new entDetalleOrdenVenta();
                DOV.NUM_ORDEN_VENTA = numOrdenVenta;
                dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.OrdenaDetalleVenta(DOV);
                gbDetalleOrdenVenta.Enabled = true;
                txtIDProducto.Enabled = false;
                txtCantidad.Enabled = true;
                btnAgregarProducto.Enabled = true;
                btnFinalizar.Enabled = true;
                btnBuscarProducto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }
    }
    public static class Conversores
    {
        public static string NumeroALetras(this decimal numberAsString)
        {
            string dec;

            var entero = Convert.ToInt64(Math.Truncate(numberAsString));
            var decimales = Convert.ToInt32(Math.Round((numberAsString - entero) * 100, 2));
            if (decimales > 0)
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" CON {decimales:0,0}/100 SOLES";
            }
            //Código agregado por mí
            else
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" CON {decimales:0,0}/100 SOLES";
            }
            var res = NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        private static string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }
    }
}
