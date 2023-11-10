namespace ProyectoGameCenter
{
    partial class FrmNotaSalida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaSalida));
            this.gbNotaSalida = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaNotaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEstadoNotaSalida = new System.Windows.Forms.ComboBox();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrdenVenta = new System.Windows.Forms.DataGridView();
            this.dgvNotaSalida = new System.Windows.Forms.DataGridView();
            this.gbDetalleNotaSalida = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDetalleNotaSalida = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarNS = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnAnular = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.txtCantidad = new ProyectoGameCenter.NiikTextBox();
            this.txtIDProducto = new ProyectoGameCenter.NiikTextBox();
            this.txtDesProducto = new ProyectoGameCenter.NiikTextBox();
            this.btnBuscarProducto = new ProyectoGameCenter.Botones.Boton();
            this.btnEliminarProd = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregarProd = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscar = new ProyectoGameCenter.Botones.Boton();
            this.txtNumOrden = new ProyectoGameCenter.NiikTextBox();
            this.btnAgregarNota = new ProyectoGameCenter.Botones.Boton();
            this.txtNNotaSalida = new ProyectoGameCenter.NiikTextBox();
            this.txtIDNotaSalida = new ProyectoGameCenter.NiikTextBox();
            this.gbNotaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaSalida)).BeginInit();
            this.gbDetalleNotaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNotaSalida
            // 
            this.gbNotaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gbNotaSalida.Controls.Add(this.dgvNotaSalida);
            this.gbNotaSalida.Controls.Add(this.dgvOrdenVenta);
            this.gbNotaSalida.Controls.Add(this.dtpFechaOrden);
            this.gbNotaSalida.Controls.Add(this.label2);
            this.gbNotaSalida.Controls.Add(this.btnBuscar);
            this.gbNotaSalida.Controls.Add(this.cbxEstadoNotaSalida);
            this.gbNotaSalida.Controls.Add(this.txtNumOrden);
            this.gbNotaSalida.Controls.Add(this.btnAgregarNota);
            this.gbNotaSalida.Controls.Add(this.txtNNotaSalida);
            this.gbNotaSalida.Controls.Add(this.txtIDNotaSalida);
            this.gbNotaSalida.Controls.Add(this.label16);
            this.gbNotaSalida.Controls.Add(this.label11);
            this.gbNotaSalida.Controls.Add(this.dtpFechaNotaSalida);
            this.gbNotaSalida.Controls.Add(this.label1);
            this.gbNotaSalida.Controls.Add(this.label3);
            this.gbNotaSalida.Controls.Add(this.label10);
            this.gbNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNotaSalida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotaSalida.ForeColor = System.Drawing.Color.White;
            this.gbNotaSalida.Location = new System.Drawing.Point(22, 29);
            this.gbNotaSalida.Name = "gbNotaSalida";
            this.gbNotaSalida.Size = new System.Drawing.Size(1454, 339);
            this.gbNotaSalida.TabIndex = 41;
            this.gbNotaSalida.TabStop = false;
            this.gbNotaSalida.Text = "INFORMACION DE LA NOTA SALIDA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(892, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 23);
            this.label16.TabIndex = 76;
            this.label16.Text = "Nª Orden Venta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID Nota Salida:";
            // 
            // dtpFechaNotaSalida
            // 
            this.dtpFechaNotaSalida.Enabled = false;
            this.dtpFechaNotaSalida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNotaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNotaSalida.Location = new System.Drawing.Point(344, 63);
            this.dtpFechaNotaSalida.Name = "dtpFechaNotaSalida";
            this.dtpFechaNotaSalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNotaSalida.Size = new System.Drawing.Size(183, 31);
            this.dtpFechaNotaSalida.TabIndex = 32;
            this.dtpFechaNotaSalida.Value = new System.DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "N° Nota Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(340, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Emision:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(546, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Estado:";
            // 
            // cbxEstadoNotaSalida
            // 
            this.cbxEstadoNotaSalida.BackColor = System.Drawing.SystemColors.Control;
            this.cbxEstadoNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxEstadoNotaSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoNotaSalida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxEstadoNotaSalida.FormattingEnabled = true;
            this.cbxEstadoNotaSalida.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxEstadoNotaSalida.Location = new System.Drawing.Point(550, 64);
            this.cbxEstadoNotaSalida.Name = "cbxEstadoNotaSalida";
            this.cbxEstadoNotaSalida.Size = new System.Drawing.Size(144, 27);
            this.cbxEstadoNotaSalida.TabIndex = 97;
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Enabled = false;
            this.dtpFechaOrden.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.Location = new System.Drawing.Point(1078, 64);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaOrden.Size = new System.Drawing.Size(183, 31);
            this.dtpFechaOrden.TabIndex = 100;
            this.dtpFechaOrden.Value = new System.DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1074, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 99;
            this.label2.Text = "Fecha Emision:";
            // 
            // dgvOrdenVenta
            // 
            this.dgvOrdenVenta.AllowUserToAddRows = false;
            this.dgvOrdenVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvOrdenVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrdenVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenVenta.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdenVenta.EnableHeadersVisualStyles = false;
            this.dgvOrdenVenta.Location = new System.Drawing.Point(887, 124);
            this.dgvOrdenVenta.Name = "dgvOrdenVenta";
            this.dgvOrdenVenta.ReadOnly = true;
            this.dgvOrdenVenta.RowHeadersVisible = false;
            this.dgvOrdenVenta.RowHeadersWidth = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrdenVenta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrdenVenta.RowTemplate.Height = 50;
            this.dgvOrdenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenVenta.Size = new System.Drawing.Size(538, 188);
            this.dgvOrdenVenta.TabIndex = 101;
            // 
            // dgvNotaSalida
            // 
            this.dgvNotaSalida.AllowUserToAddRows = false;
            this.dgvNotaSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotaSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotaSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvNotaSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotaSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotaSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotaSalida.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotaSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotaSalida.EnableHeadersVisualStyles = false;
            this.dgvNotaSalida.Location = new System.Drawing.Point(24, 124);
            this.dgvNotaSalida.Name = "dgvNotaSalida";
            this.dgvNotaSalida.ReadOnly = true;
            this.dgvNotaSalida.RowHeadersVisible = false;
            this.dgvNotaSalida.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotaSalida.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotaSalida.RowTemplate.Height = 50;
            this.dgvNotaSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaSalida.Size = new System.Drawing.Size(809, 188);
            this.dgvNotaSalida.TabIndex = 102;
            // 
            // gbDetalleNotaSalida
            // 
            this.gbDetalleNotaSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDetalleNotaSalida.Controls.Add(this.txtCantidad);
            this.gbDetalleNotaSalida.Controls.Add(this.label12);
            this.gbDetalleNotaSalida.Controls.Add(this.dgvDetalleNotaSalida);
            this.gbDetalleNotaSalida.Controls.Add(this.label7);
            this.gbDetalleNotaSalida.Controls.Add(this.lblCantidad);
            this.gbDetalleNotaSalida.Controls.Add(this.txtIDProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.txtDesProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.btnBuscarProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.btnEliminarProd);
            this.gbDetalleNotaSalida.Controls.Add(this.btnAgregarProd);
            this.gbDetalleNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleNotaSalida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleNotaSalida.ForeColor = System.Drawing.Color.White;
            this.gbDetalleNotaSalida.Location = new System.Drawing.Point(22, 409);
            this.gbDetalleNotaSalida.Name = "gbDetalleNotaSalida";
            this.gbDetalleNotaSalida.Size = new System.Drawing.Size(1465, 323);
            this.gbDetalleNotaSalida.TabIndex = 64;
            this.gbDetalleNotaSalida.TabStop = false;
            this.gbDetalleNotaSalida.Text = "DETALLE ORDEN COMPRA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Descripcion Producto:";
            // 
            // dgvDetalleNotaSalida
            // 
            this.dgvDetalleNotaSalida.AllowUserToAddRows = false;
            this.dgvDetalleNotaSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleNotaSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleNotaSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvDetalleNotaSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleNotaSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleNotaSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalleNotaSalida.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleNotaSalida.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalleNotaSalida.EnableHeadersVisualStyles = false;
            this.dgvDetalleNotaSalida.Location = new System.Drawing.Point(28, 126);
            this.dgvDetalleNotaSalida.Name = "dgvDetalleNotaSalida";
            this.dgvDetalleNotaSalida.ReadOnly = true;
            this.dgvDetalleNotaSalida.RowHeadersVisible = false;
            this.dgvDetalleNotaSalida.RowHeadersWidth = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleNotaSalida.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleNotaSalida.RowTemplate.Height = 50;
            this.dgvDetalleNotaSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleNotaSalida.Size = new System.Drawing.Size(1414, 176);
            this.dgvDetalleNotaSalida.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(538, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 54;
            this.label7.Text = "ID Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(701, 38);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(104, 23);
            this.lblCantidad.TabIndex = 33;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(814, 754);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "Buscar por Fecha:";
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(818, 780);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(176, 27);
            this.dtpBuscarFecha.TabIndex = 110;
            // 
            // btnBuscarNS
            // 
            this.btnBuscarNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarNS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarNS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarNS.BorderRadius = 40;
            this.btnBuscarNS.BorderSize = 0;
            this.btnBuscarNS.FlatAppearance.BorderSize = 0;
            this.btnBuscarNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarNS.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNS.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNS.Image")));
            this.btnBuscarNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNS.Location = new System.Drawing.Point(1008, 757);
            this.btnBuscarNS.Name = "btnBuscarNS";
            this.btnBuscarNS.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarNS.TabIndex = 115;
            this.btnBuscarNS.Text = "Buscar";
            this.btnBuscarNS.TextColor = System.Drawing.Color.White;
            this.btnBuscarNS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarNS.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 40;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(41, 757);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 114;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAnular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAnular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnular.BorderRadius = 40;
            this.btnAnular.BorderSize = 0;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(1316, 757);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(148, 50);
            this.btnAnular.TabIndex = 113;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextColor = System.Drawing.Color.White;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevo.BorderRadius = 40;
            this.btnNuevo.BorderSize = 0;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1162, 757);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 112;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(699, 72);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.Size = new System.Drawing.Size(112, 36);
            this.txtCantidad.TabIndex = 110;
            this.txtCantidad.UnderlinedStyle = false;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDProducto.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDProducto.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDProducto.BorderRadius = 15;
            this.txtIDProducto.BorderSize = 2;
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDProducto.ForeColor = System.Drawing.Color.Black;
            this.txtIDProducto.Location = new System.Drawing.Point(542, 72);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProducto.Multiline = false;
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDProducto.PasswordChar = false;
            this.txtIDProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDProducto.PlaceholderText = "";
            this.txtIDProducto.Size = new System.Drawing.Size(112, 36);
            this.txtIDProducto.TabIndex = 95;
            this.txtIDProducto.UnderlinedStyle = false;
            // 
            // txtDesProducto
            // 
            this.txtDesProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesProducto.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDesProducto.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDesProducto.BorderRadius = 15;
            this.txtDesProducto.BorderSize = 2;
            this.txtDesProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDesProducto.ForeColor = System.Drawing.Color.Black;
            this.txtDesProducto.Location = new System.Drawing.Point(28, 72);
            this.txtDesProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesProducto.Multiline = false;
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDesProducto.PasswordChar = false;
            this.txtDesProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesProducto.PlaceholderText = "";
            this.txtDesProducto.Size = new System.Drawing.Size(349, 36);
            this.txtDesProducto.TabIndex = 96;
            this.txtDesProducto.UnderlinedStyle = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarProducto.BorderRadius = 40;
            this.btnBuscarProducto.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(384, 71);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(103, 37);
            this.btnBuscarProducto.TabIndex = 99;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextColor = System.Drawing.Color.White;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnEliminarProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnEliminarProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarProd.BorderRadius = 40;
            this.btnEliminarProd.BorderSize = 0;
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProd.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProd.Image")));
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(1294, 58);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(148, 48);
            this.btnEliminarProd.TabIndex = 98;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.TextColor = System.Drawing.Color.White;
            this.btnEliminarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarProd.BorderRadius = 40;
            this.btnAgregarProd.BorderSize = 0;
            this.btnAgregarProd.FlatAppearance.BorderSize = 0;
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProd.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.Image")));
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Location = new System.Drawing.Point(1113, 58);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(148, 50);
            this.btnAgregarProd.TabIndex = 97;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextColor = System.Drawing.Color.White;
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 40;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1277, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 50);
            this.btnBuscar.TabIndex = 98;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumOrden.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNumOrden.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtNumOrden.BorderRadius = 15;
            this.txtNumOrden.BorderSize = 2;
            this.txtNumOrden.Enabled = false;
            this.txtNumOrden.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumOrden.ForeColor = System.Drawing.Color.Black;
            this.txtNumOrden.Location = new System.Drawing.Point(896, 59);
            this.txtNumOrden.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumOrden.Multiline = false;
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumOrden.PasswordChar = false;
            this.txtNumOrden.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumOrden.PlaceholderText = "";
            this.txtNumOrden.Size = new System.Drawing.Size(140, 36);
            this.txtNumOrden.TabIndex = 96;
            this.txtNumOrden.UnderlinedStyle = false;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarNota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarNota.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarNota.BorderRadius = 40;
            this.btnAgregarNota.BorderSize = 0;
            this.btnAgregarNota.FlatAppearance.BorderSize = 0;
            this.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarNota.Image")));
            this.btnAgregarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNota.Location = new System.Drawing.Point(724, 45);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(148, 50);
            this.btnAgregarNota.TabIndex = 95;
            this.btnAgregarNota.Text = "Agregar";
            this.btnAgregarNota.TextColor = System.Drawing.Color.White;
            this.btnAgregarNota.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            // 
            // txtNNotaSalida
            // 
            this.txtNNotaSalida.BackColor = System.Drawing.SystemColors.Window;
            this.txtNNotaSalida.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNNotaSalida.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtNNotaSalida.BorderRadius = 15;
            this.txtNNotaSalida.BorderSize = 2;
            this.txtNNotaSalida.Enabled = false;
            this.txtNNotaSalida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNNotaSalida.ForeColor = System.Drawing.Color.Black;
            this.txtNNotaSalida.Location = new System.Drawing.Point(183, 59);
            this.txtNNotaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNNotaSalida.Multiline = false;
            this.txtNNotaSalida.Name = "txtNNotaSalida";
            this.txtNNotaSalida.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNNotaSalida.PasswordChar = false;
            this.txtNNotaSalida.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNNotaSalida.PlaceholderText = "";
            this.txtNNotaSalida.Size = new System.Drawing.Size(126, 36);
            this.txtNNotaSalida.TabIndex = 91;
            this.txtNNotaSalida.UnderlinedStyle = false;
            // 
            // txtIDNotaSalida
            // 
            this.txtIDNotaSalida.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDNotaSalida.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDNotaSalida.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDNotaSalida.BorderRadius = 15;
            this.txtIDNotaSalida.BorderSize = 2;
            this.txtIDNotaSalida.Enabled = false;
            this.txtIDNotaSalida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDNotaSalida.ForeColor = System.Drawing.Color.Black;
            this.txtIDNotaSalida.Location = new System.Drawing.Point(24, 59);
            this.txtIDNotaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDNotaSalida.Multiline = false;
            this.txtIDNotaSalida.Name = "txtIDNotaSalida";
            this.txtIDNotaSalida.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDNotaSalida.PasswordChar = false;
            this.txtIDNotaSalida.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDNotaSalida.PlaceholderText = "";
            this.txtIDNotaSalida.Size = new System.Drawing.Size(112, 36);
            this.txtIDNotaSalida.TabIndex = 90;
            this.txtIDNotaSalida.UnderlinedStyle = false;
            // 
            // FrmNotaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1508, 835);
            this.Controls.Add(this.btnBuscarNS);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBuscarFecha);
            this.Controls.Add(this.gbDetalleNotaSalida);
            this.Controls.Add(this.gbNotaSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotaSalida";
            this.Text = "FrmNotaSalida";
            this.gbNotaSalida.ResumeLayout(false);
            this.gbNotaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaSalida)).EndInit();
            this.gbDetalleNotaSalida.ResumeLayout(false);
            this.gbDetalleNotaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNotaSalida;
        private Botones.Boton btnAgregarNota;
        private NiikTextBox txtNNotaSalida;
        private NiikTextBox txtIDNotaSalida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaNotaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private NiikTextBox txtNumOrden;
        private Botones.Boton btnBuscar;
        private System.Windows.Forms.ComboBox cbxEstadoNotaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNotaSalida;
        private System.Windows.Forms.DataGridView dgvOrdenVenta;
        private System.Windows.Forms.GroupBox gbDetalleNotaSalida;
        private NiikTextBox txtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDetalleNotaSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCantidad;
        private NiikTextBox txtIDProducto;
        private NiikTextBox txtDesProducto;
        private Botones.Boton btnBuscarProducto;
        private Botones.Boton btnEliminarProd;
        private Botones.Boton btnAgregarProd;
        private Botones.Boton btnBuscarNS;
        private Botones.Boton btnSalir;
        private Botones.Boton btnAnular;
        private Botones.Boton btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
    }
}