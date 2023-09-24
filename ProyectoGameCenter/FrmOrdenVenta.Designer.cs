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
            this.btnPDF = new System.Windows.Forms.Button();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResultadoBusquedaCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscaridCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOrdenVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvDetalleOrdenVenta = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvOrdenVenta = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpOrdenVenta = new System.Windows.Forms.DateTimePicker();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            this.gbOrdenVenta.SuspendLayout();
            this.gbDetalleOrdenVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenVenta)).BeginInit();
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
            this.BarraTitulo.Size = new System.Drawing.Size(1040, 60);
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
            this.label2.Size = new System.Drawing.Size(1040, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "ORDEN DE VENTA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOrdenVenta
            // 
            this.gbOrdenVenta.Controls.Add(this.btnPDF);
            this.gbOrdenVenta.Controls.Add(this.cboTipoCliente);
            this.gbOrdenVenta.Controls.Add(this.cboComprobante);
            this.gbOrdenVenta.Controls.Add(this.txtIDOrdenVenta);
            this.gbOrdenVenta.Controls.Add(this.label11);
            this.gbOrdenVenta.Controls.Add(this.txtResultadoBusquedaCliente);
            this.gbOrdenVenta.Controls.Add(this.label8);
            this.gbOrdenVenta.Controls.Add(this.btnBuscaridCliente);
            this.gbOrdenVenta.Controls.Add(this.btnCancelar);
            this.gbOrdenVenta.Controls.Add(this.txtIDEmpleado);
            this.gbOrdenVenta.Controls.Add(this.dateTimePicker1);
            this.gbOrdenVenta.Controls.Add(this.label1);
            this.gbOrdenVenta.Controls.Add(this.txtNOrdenVenta);
            this.gbOrdenVenta.Controls.Add(this.label4);
            this.gbOrdenVenta.Controls.Add(this.txtIDCliente);
            this.gbOrdenVenta.Controls.Add(this.label3);
            this.gbOrdenVenta.Controls.Add(this.btnAgregar);
            this.gbOrdenVenta.Controls.Add(this.cboEstado);
            this.gbOrdenVenta.Controls.Add(this.label9);
            this.gbOrdenVenta.Controls.Add(this.label10);
            this.gbOrdenVenta.Enabled = false;
            this.gbOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdenVenta.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbOrdenVenta.Location = new System.Drawing.Point(25, 66);
            this.gbOrdenVenta.Name = "gbOrdenVenta";
            this.gbOrdenVenta.Size = new System.Drawing.Size(528, 297);
            this.gbOrdenVenta.TabIndex = 40;
            this.gbOrdenVenta.TabStop = false;
            this.gbOrdenVenta.Text = "ORDEN DE VENTA";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.White;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(391, 254);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(122, 37);
            this.btnPDF.TabIndex = 78;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Items.AddRange(new object[] {
            "1 - DNI",
            "6 - RUC"});
            this.cboTipoCliente.Location = new System.Drawing.Point(391, 173);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(122, 36);
            this.cboTipoCliente.TabIndex = 77;
            // 
            // cboComprobante
            // 
            this.cboComprobante.FormattingEnabled = true;
            this.cboComprobante.Items.AddRange(new object[] {
            "01 - FACTURA",
            "03 - BOLETA"});
            this.cboComprobante.Location = new System.Drawing.Point(392, 213);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(121, 36);
            this.cboComprobante.TabIndex = 76;
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.Enabled = false;
            this.txtIDOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(182, 36);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(183, 27);
            this.txtIDOrdenVenta.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkViolet;
            this.label11.Location = new System.Drawing.Point(10, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID ORDEN VENTA:";
            // 
            // txtResultadoBusquedaCliente
            // 
            this.txtResultadoBusquedaCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoBusquedaCliente.Location = new System.Drawing.Point(182, 182);
            this.txtResultadoBusquedaCliente.Name = "txtResultadoBusquedaCliente";
            this.txtResultadoBusquedaCliente.Size = new System.Drawing.Size(183, 27);
            this.txtResultadoBusquedaCliente.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(72, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 72;
            this.label8.Text = "ID Cliente:";
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
            this.btnBuscaridCliente.Location = new System.Drawing.Point(371, 145);
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
            this.btnCancelar.Location = new System.Drawing.Point(392, 86);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 43);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmpleado.Location = new System.Drawing.Point(182, 220);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(183, 27);
            this.txtIDEmpleado.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 108);
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
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "N° Orden Venta:";
            // 
            // txtNOrdenVenta
            // 
            this.txtNOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOrdenVenta.Location = new System.Drawing.Point(182, 73);
            this.txtNOrdenVenta.Name = "txtNOrdenVenta";
            this.txtNOrdenVenta.Size = new System.Drawing.Size(183, 27);
            this.txtNOrdenVenta.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(46, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID Vendedor:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(182, 145);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(183, 27);
            this.txtIDCliente.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(41, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Orden:";
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
            this.btnAgregar.Location = new System.Drawing.Point(396, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 43);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(182, 253);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(183, 29);
            this.cboEstado.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(81, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "DNI/RUC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(99, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Estado:";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProducto.Location = new System.Drawing.Point(164, 35);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(157, 27);
            this.txtIDProducto.TabIndex = 37;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(127, 105);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(101, 27);
            this.txtStock.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(235, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(60, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(37, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "ID Producto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(314, 104);
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
            this.btnSalir.Location = new System.Drawing.Point(25, 570);
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
            this.btnAnular.Location = new System.Drawing.Point(926, 569);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(102, 50);
            this.btnAnular.TabIndex = 48;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(801, 570);
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
            this.btnBuscarOV.Location = new System.Drawing.Point(682, 570);
            this.btnBuscarOV.Name = "btnBuscarOV";
            this.btnBuscarOV.Size = new System.Drawing.Size(113, 50);
            this.btnBuscarOV.TabIndex = 60;
            this.btnBuscarOV.Text = "Buscar";
            this.btnBuscarOV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOV.UseVisualStyleBackColor = false;
            this.btnBuscarOV.Click += new System.EventHandler(this.btnBuscarOV_Click);
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
            this.btnCPago.Location = new System.Drawing.Point(323, 570);
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
            this.gbDetalleOrdenVenta.Controls.Add(this.txtCantidad);
            this.gbDetalleOrdenVenta.Controls.Add(this.label14);
            this.gbDetalleOrdenVenta.Controls.Add(this.label15);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtTotal);
            this.gbDetalleOrdenVenta.Controls.Add(this.dgvDetalleOrdenVenta);
            this.gbDetalleOrdenVenta.Controls.Add(this.label12);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtDesProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.btnBuscarProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.btnFinalizar);
            this.gbDetalleOrdenVenta.Controls.Add(this.btnAgregarProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.label5);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtStock);
            this.gbDetalleOrdenVenta.Controls.Add(this.label6);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtIDProducto);
            this.gbDetalleOrdenVenta.Controls.Add(this.label7);
            this.gbDetalleOrdenVenta.Controls.Add(this.txtPrecio);
            this.gbDetalleOrdenVenta.Enabled = false;
            this.gbDetalleOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleOrdenVenta.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbDetalleOrdenVenta.Location = new System.Drawing.Point(574, 66);
            this.gbDetalleOrdenVenta.Name = "gbDetalleOrdenVenta";
            this.gbDetalleOrdenVenta.Size = new System.Drawing.Size(454, 297);
            this.gbDetalleOrdenVenta.TabIndex = 62;
            this.gbDetalleOrdenVenta.TabStop = false;
            this.gbDetalleOrdenVenta.Text = "DETALLE ORDEN DE VENTA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(127, 140);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(101, 27);
            this.txtCantidad.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkViolet;
            this.label14.Location = new System.Drawing.Point(22, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 23);
            this.label14.TabIndex = 76;
            this.label14.Text = "Cantidad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkViolet;
            this.label15.Location = new System.Drawing.Point(239, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 23);
            this.label15.TabIndex = 77;
            this.label15.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(314, 139);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 27);
            this.txtTotal.TabIndex = 75;
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
            this.dgvDetalleOrdenVenta.Location = new System.Drawing.Point(17, 176);
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
            this.dgvDetalleOrdenVenta.Size = new System.Drawing.Size(374, 110);
            this.dgvDetalleOrdenVenta.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkViolet;
            this.label12.Location = new System.Drawing.Point(22, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Des Producto:";
            // 
            // txtDesProducto
            // 
            this.txtDesProducto.Enabled = false;
            this.txtDesProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProducto.Location = new System.Drawing.Point(164, 69);
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.Size = new System.Drawing.Size(157, 27);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(339, 33);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 29);
            this.btnBuscarProducto.TabIndex = 71;
            this.btnBuscarProducto.Text = "buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
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
            this.btnFinalizar.Location = new System.Drawing.Point(397, 236);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(49, 43);
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(397, 186);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(49, 43);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkViolet;
            this.label13.Location = new System.Drawing.Point(483, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 23);
            this.label13.TabIndex = 64;
            this.label13.Text = "Fecha Orden Venta:";
            // 
            // dgvOrdenVenta
            // 
            this.dgvOrdenVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenVenta.Location = new System.Drawing.Point(12, 381);
            this.dgvOrdenVenta.Name = "dgvOrdenVenta";
            this.dgvOrdenVenta.ReadOnly = true;
            this.dgvOrdenVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrdenVenta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenVenta.Size = new System.Drawing.Size(1003, 174);
            this.dgvOrdenVenta.TabIndex = 65;
            this.dgvOrdenVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenVenta_CellClick);
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
            this.btnLimpiar.Location = new System.Drawing.Point(164, 570);
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
            this.dtpOrdenVenta.Location = new System.Drawing.Point(486, 594);
            this.dtpOrdenVenta.Name = "dtpOrdenVenta";
            this.dtpOrdenVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpOrdenVenta.Size = new System.Drawing.Size(183, 31);
            this.dtpOrdenVenta.TabIndex = 67;
            this.dtpOrdenVenta.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.White;
            this.btnComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnComprobante.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobante.Image")));
            this.btnComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobante.Location = new System.Drawing.Point(682, 626);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(171, 50);
            this.btnComprobante.TabIndex = 68;
            this.btnComprobante.Text = "Generar Comprobante";
            this.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // FrmOrdenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 683);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.dtpOrdenVenta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvOrdenVenta);
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
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIDEmpleado;
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
        private System.Windows.Forms.DataGridView dgvOrdenVenta;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpOrdenVenta;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.ComboBox cboComprobante;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button btnPDF;
    }
}