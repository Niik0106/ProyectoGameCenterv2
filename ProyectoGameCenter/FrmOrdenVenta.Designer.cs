namespace ProyectoGameCenter
{
    partial class FrmOrdenVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOrdenVenta = new System.Windows.Forms.GroupBox();
            this.cboTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOrdenVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResultadoBusquedaCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscaridCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarOV = new System.Windows.Forms.Button();
            this.btnCPago = new System.Windows.Forms.Button();
            this.gbDetalleOrdenVenta = new System.Windows.Forms.GroupBox();
            this.dgvDetalleOrdenVenta = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDesProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpOrdenVenta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.dgvOrdenVenta = new System.Windows.Forms.DataGridView();
            this.BarraTitulo.SuspendLayout();
            this.gbOrdenVenta.SuspendLayout();
            this.gbDetalleOrdenVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1670, 60);
            this.BarraTitulo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1670, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "ORDEN DE VENTA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOrdenVenta
            // 
            this.gbOrdenVenta.Controls.Add(this.cboMetodoPago);
            this.gbOrdenVenta.Controls.Add(this.cboTipoComprobante);
            this.gbOrdenVenta.Controls.Add(this.label16);
            this.gbOrdenVenta.Controls.Add(this.txtIDOrdenVenta);
            this.gbOrdenVenta.Controls.Add(this.label11);
            this.gbOrdenVenta.Controls.Add(this.dateTimePicker1);
            this.gbOrdenVenta.Controls.Add(this.label1);
            this.gbOrdenVenta.Controls.Add(this.txtNOrdenVenta);
            this.gbOrdenVenta.Controls.Add(this.label4);
            this.gbOrdenVenta.Controls.Add(this.label3);
            this.gbOrdenVenta.Controls.Add(this.cboEstado);
            this.gbOrdenVenta.Controls.Add(this.label10);
            this.gbOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdenVenta.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbOrdenVenta.Location = new System.Drawing.Point(64, 87);
            this.gbOrdenVenta.Name = "gbOrdenVenta";
            this.gbOrdenVenta.Size = new System.Drawing.Size(678, 198);
            this.gbOrdenVenta.TabIndex = 40;
            this.gbOrdenVenta.TabStop = false;
            this.gbOrdenVenta.Text = "INFORMACION DE LA VENTA";
            // 
            // cboTipoComprobante
            // 
            this.cboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoComprobante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoComprobante.FormattingEnabled = true;
            this.cboTipoComprobante.Location = new System.Drawing.Point(233, 132);
            this.cboTipoComprobante.Name = "cboTipoComprobante";
            this.cboTipoComprobante.Size = new System.Drawing.Size(197, 29);
            this.cboTipoComprobante.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(229, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 23);
            this.label16.TabIndex = 76;
            this.label16.Text = "Tipo Comprobante:";
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.Enabled = false;
            this.txtIDOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(24, 63);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(152, 27);
            this.txtIDOrdenVenta.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(20, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID Orden Venta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(404, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 31);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "N° Orden Venta:";
            // 
            // txtNOrdenVenta
            // 
            this.txtNOrdenVenta.Enabled = false;
            this.txtNOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOrdenVenta.Location = new System.Drawing.Point(215, 63);
            this.txtNOrdenVenta.Name = "txtNOrdenVenta";
            this.txtNOrdenVenta.Size = new System.Drawing.Size(156, 27);
            this.txtNOrdenVenta.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Metodo Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(400, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Orden:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Enabled = false;
            this.cboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(469, 132);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(156, 29);
            this.cboEstado.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(465, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Estado:";
            // 
            // txtResultadoBusquedaCliente
            // 
            this.txtResultadoBusquedaCliente.Enabled = false;
            this.txtResultadoBusquedaCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoBusquedaCliente.Location = new System.Drawing.Point(21, 132);
            this.txtResultadoBusquedaCliente.Name = "txtResultadoBusquedaCliente";
            this.txtResultadoBusquedaCliente.Size = new System.Drawing.Size(234, 27);
            this.txtResultadoBusquedaCliente.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 23);
            this.label8.TabIndex = 72;
            this.label8.Text = "Numero Documento:";
            // 
            // btnBuscaridCliente
            // 
            this.btnBuscaridCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscaridCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaridCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscaridCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaridCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaridCliente.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscaridCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaridCliente.Image")));
            this.btnBuscaridCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaridCliente.Location = new System.Drawing.Point(261, 68);
            this.btnBuscaridCliente.Name = "btnBuscaridCliente";
            this.btnBuscaridCliente.Size = new System.Drawing.Size(71, 29);
            this.btnBuscaridCliente.TabIndex = 71;
            this.btnBuscaridCliente.Text = "buscar";
            this.btnBuscaridCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaridCliente.UseVisualStyleBackColor = false;
            this.btnBuscaridCliente.Click += new System.EventHandler(this.btnBuscaridCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(62, 469);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(205, 43);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoCliente.Location = new System.Drawing.Point(21, 68);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(234, 27);
            this.txtDocumentoCliente.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(62, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(205, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Procesar Venta";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(17, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "DNI/RUC:";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProducto.Location = new System.Drawing.Point(24, 61);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(193, 27);
            this.txtIDProducto.TabIndex = 37;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(488, 128);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(101, 27);
            this.txtStock.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(629, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(485, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "ID Producto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(633, 128);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(96, 27);
            this.txtPrecio.TabIndex = 26;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(64, 881);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 50);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.White;
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(1247, 881);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(102, 50);
            this.btnAnular.TabIndex = 48;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1105, 881);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(119, 50);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarOV
            // 
            this.btnBuscarOV.BackColor = System.Drawing.Color.White;
            this.btnBuscarOV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarOV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOV.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarOV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOV.Image")));
            this.btnBuscarOV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOV.Location = new System.Drawing.Point(962, 881);
            this.btnBuscarOV.Name = "btnBuscarOV";
            this.btnBuscarOV.Size = new System.Drawing.Size(113, 50);
            this.btnBuscarOV.TabIndex = 60;
            this.btnBuscarOV.Text = "Buscar";
            this.btnBuscarOV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOV.UseVisualStyleBackColor = false;
            // 
            // btnCPago
            // 
            this.btnCPago.BackColor = System.Drawing.Color.White;
            this.btnCPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnCPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPago.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCPago.Image = ((System.Drawing.Image)(resources.GetObject("btnCPago.Image")));
            this.btnCPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPago.Location = new System.Drawing.Point(567, 881);
            this.btnCPago.Name = "btnCPago";
            this.btnCPago.Size = new System.Drawing.Size(148, 50);
            this.btnCPago.TabIndex = 61;
            this.btnCPago.Text = "Cron. Pago";
            this.btnCPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCPago.UseVisualStyleBackColor = false;
            this.btnCPago.Click += new System.EventHandler(this.btnCPago_Click);
            // 
            // gbDetalleOrdenVenta
            // 
            this.gbDetalleOrdenVenta.Controls.Add(this.dgvDetalleOrdenVenta);
            this.gbDetalleOrdenVenta.Controls.Add(this.label12);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtCantidad);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtDesProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.btnBuscarProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.label14);
            this.gbDetalleOrdenVenta.Controls.Add(this.btnFinalizar);
            this.gbDetalleOrdenVenta.Controls.Add(this.btnAgregarProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.label5);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtStock);
            this.gbDetalleOrdenVenta.Controls.Add(this.label6);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtIDProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.label7);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtPrecio);
            this.gbDetalleOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleOrdenVenta.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbDetalleOrdenVenta.Location = new System.Drawing.Point(64, 528);
            this.gbDetalleOrdenVenta.Name = "gbDetalleOrdenVenta";
            this.gbDetalleOrdenVenta.Size = new System.Drawing.Size(1177, 292);
            this.gbDetalleOrdenVenta.TabIndex = 62;
            this.gbDetalleOrdenVenta.TabStop = false;
            this.gbDetalleOrdenVenta.Text = "DETALLE ORDEN DE VENTA";
            // 
            // dgvDetalleOrdenVenta
            // 
            this.dgvDetalleOrdenVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrdenVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleOrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleOrdenVenta.Location = new System.Drawing.Point(24, 180);
            this.dgvDetalleOrdenVenta.Name = "dgvDetalleOrdenVenta";
            this.dgvDetalleOrdenVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleOrdenVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenVenta.Size = new System.Drawing.Size(1125, 264);
            this.dgvDetalleOrdenVenta.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(22, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Des Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(346, 61);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 27);
            this.txtCantidad.TabIndex = 78;
            // 
            // txtDesProducto
            // 
            this.txtDesProducto.Enabled = false;
            this.txtDesProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProducto.Location = new System.Drawing.Point(24, 128);
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.Size = new System.Drawing.Size(420, 27);
            this.txtDesProducto.TabIndex = 72;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(232, 61);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 29);
            this.btnBuscarProducto.TabIndex = 71;
            this.btnBuscarProducto.Text = "buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(342, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 23);
            this.label14.TabIndex = 76;
            this.label14.Text = "Cantidad:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(778, 112);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(135, 43);
            this.btnFinalizar.TabIndex = 29;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(778, 52);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(135, 43);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkViolet;
            this.label15.Location = new System.Drawing.Point(113, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 23);
            this.label15.TabIndex = 77;
            this.label15.Text = "TOTAL   S/";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(74, 321);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 53);
            this.txtTotal.TabIndex = 75;
            this.txtTotal.Text = "542";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkViolet;
            this.label13.Location = new System.Drawing.Point(752, 877);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 23);
            this.label13.TabIndex = 64;
            this.label13.Text = "Fecha Orden Venta:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(383, 881);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 50);
            this.btnLimpiar.TabIndex = 66;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpOrdenVenta
            // 
            this.dtpOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrdenVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdenVenta.Location = new System.Drawing.Point(755, 901);
            this.dtpOrdenVenta.Name = "dtpOrdenVenta";
            this.dtpOrdenVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpOrdenVenta.Size = new System.Drawing.Size(183, 31);
            this.dtpOrdenVenta.TabIndex = 67;
            this.dtpOrdenVenta.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDocumentoCliente);
            this.groupBox1.Controls.Add(this.btnBuscaridCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtResultadoBusquedaCliente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Location = new System.Drawing.Point(791, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 198);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION DEL CLIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox2.Location = new System.Drawing.Point(1294, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 564);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMPORTES";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(74, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 41);
            this.textBox2.TabIndex = 81;
            this.textBox2.Text = "542";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(74, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 41);
            this.textBox1.TabIndex = 80;
            this.textBox1.Text = "542";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(123, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 23);
            this.label18.TabIndex = 79;
            this.label18.Text = "IGV S/";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(99, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 23);
            this.label17.TabIndex = 78;
            this.label17.Text = "Sub Total S/";
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(20, 132);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(171, 29);
            this.cboMetodoPago.TabIndex = 78;
            // 
            // dgvOrdenVenta
            // 
            this.dgvOrdenVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenVenta.EnableHeadersVisualStyles = false;
            this.dgvOrdenVenta.Location = new System.Drawing.Point(84, 304);
            this.dgvOrdenVenta.Name = "dgvOrdenVenta";
            this.dgvOrdenVenta.ReadOnly = true;
            this.dgvOrdenVenta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrdenVenta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenVenta.Size = new System.Drawing.Size(1129, 196);
            this.dgvOrdenVenta.TabIndex = 80;
            // 
            // FrmOrdenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1670, 980);
            this.Controls.Add(this.dgvOrdenVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpOrdenVenta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbDetalleOrdenVenta);
            this.Controls.Add(this.btnCPago);
            this.Controls.Add(this.btnBuscarOV);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbOrdenVenta);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenVenta";
            this.Text = "FrmOrdenVenta";
            this.BarraTitulo.ResumeLayout(false);
            this.gbOrdenVenta.ResumeLayout(false);
            this.gbOrdenVenta.PerformLayout();
            this.gbDetalleOrdenVenta.ResumeLayout(false);
            this.gbDetalleOrdenVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOrdenVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOrdenVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscarOV;
        private System.Windows.Forms.Button btnCPago;
        private System.Windows.Forms.TextBox txtIDOrdenVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResultadoBusquedaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscaridCliente;
        private System.Windows.Forms.GroupBox gbDetalleOrdenVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpOrdenVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTipoComprobante;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.DataGridView dgvOrdenVenta;
    }
}