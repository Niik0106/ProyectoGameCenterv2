namespace ProyectoGameCenter
{
    partial class FrmOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboOrdenCompra = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new ProyectoGameCenter.Botones.Boton();
            this.dtpFOrdenCompra = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new ProyectoGameCenter.Botones.Boton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEstadoCompra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDOrdenCompra = new ProyectoGameCenter.NiikTextBox();
            this.txtNumOrdenCompra = new ProyectoGameCenter.NiikTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gbDetalleOrdenCompra = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new ProyectoGameCenter.NiikTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDetalleOrdenCompra = new System.Windows.Forms.DataGridView();
            this.txtIDProducto = new ProyectoGameCenter.NiikTextBox();
            this.txtDesProducto = new ProyectoGameCenter.NiikTextBox();
            this.btnBuscarProducto = new ProyectoGameCenter.Botones.Boton();
            this.btnEliminarProd = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregarProd = new ProyectoGameCenter.Botones.Boton();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscaridProveedor = new ProyectoGameCenter.Botones.Boton();
            this.txtRazonSocial = new ProyectoGameCenter.NiikTextBox();
            this.txtRucProveedor = new ProyectoGameCenter.NiikTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarOC = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnAnular = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.gboOrdenCompra.SuspendLayout();
            this.gbDetalleOrdenCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboOrdenCompra
            // 
            this.gboOrdenCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboOrdenCompra.Controls.Add(this.label8);
            this.gboOrdenCompra.Controls.Add(this.btnCancelar);
            this.gboOrdenCompra.Controls.Add(this.dtpFOrdenCompra);
            this.gboOrdenCompra.Controls.Add(this.btnAgregar);
            this.gboOrdenCompra.Controls.Add(this.label5);
            this.gboOrdenCompra.Controls.Add(this.cbxEstadoCompra);
            this.gboOrdenCompra.Controls.Add(this.label3);
            this.gboOrdenCompra.Controls.Add(this.label2);
            this.gboOrdenCompra.Controls.Add(this.txtIDOrdenCompra);
            this.gboOrdenCompra.Controls.Add(this.txtNumOrdenCompra);
            this.gboOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.gboOrdenCompra.Location = new System.Drawing.Point(517, 12);
            this.gboOrdenCompra.Name = "gboOrdenCompra";
            this.gboOrdenCompra.Size = new System.Drawing.Size(974, 196);
            this.gboOrdenCompra.TabIndex = 57;
            this.gboOrdenCompra.TabStop = false;
            this.gboOrdenCompra.Text = "INFORMACION DE LA COMPRA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(305, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "N° Orden Compra:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(779, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 48);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dtpFOrdenCompra
            // 
            this.dtpFOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFOrdenCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFOrdenCompra.Location = new System.Drawing.Point(556, 74);
            this.dtpFOrdenCompra.Name = "dtpFOrdenCompra";
            this.dtpFOrdenCompra.Size = new System.Drawing.Size(150, 27);
            this.dtpFOrdenCompra.TabIndex = 52;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(779, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 50);
            this.btnAgregar.TabIndex = 106;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(538, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Fecha O. Compra:";
            // 
            // cbxEstadoCompra
            // 
            this.cbxEstadoCompra.BackColor = System.Drawing.SystemColors.Control;
            this.cbxEstadoCompra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxEstadoCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoCompra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxEstadoCompra.FormattingEnabled = true;
            this.cbxEstadoCompra.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxEstadoCompra.Location = new System.Drawing.Point(52, 133);
            this.cbxEstadoCompra.Name = "cbxEstadoCompra";
            this.cbxEstadoCompra.Size = new System.Drawing.Size(215, 27);
            this.cbxEstadoCompra.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID Orden Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Estado Compra:";
            // 
            // txtIDOrdenCompra
            // 
            this.txtIDOrdenCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDOrdenCompra.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDOrdenCompra.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDOrdenCompra.BorderRadius = 15;
            this.txtIDOrdenCompra.BorderSize = 2;
            this.txtIDOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDOrdenCompra.ForeColor = System.Drawing.Color.Black;
            this.txtIDOrdenCompra.Location = new System.Drawing.Point(52, 70);
            this.txtIDOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDOrdenCompra.Multiline = false;
            this.txtIDOrdenCompra.Name = "txtIDOrdenCompra";
            this.txtIDOrdenCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDOrdenCompra.PasswordChar = false;
            this.txtIDOrdenCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDOrdenCompra.PlaceholderText = "";
            this.txtIDOrdenCompra.Size = new System.Drawing.Size(169, 36);
            this.txtIDOrdenCompra.TabIndex = 91;
            this.txtIDOrdenCompra.UnderlinedStyle = false;
            // 
            // txtNumOrdenCompra
            // 
            this.txtNumOrdenCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumOrdenCompra.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNumOrdenCompra.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtNumOrdenCompra.BorderRadius = 15;
            this.txtNumOrdenCompra.BorderSize = 2;
            this.txtNumOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumOrdenCompra.ForeColor = System.Drawing.Color.Black;
            this.txtNumOrdenCompra.Location = new System.Drawing.Point(309, 70);
            this.txtNumOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumOrdenCompra.Multiline = false;
            this.txtNumOrdenCompra.Name = "txtNumOrdenCompra";
            this.txtNumOrdenCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumOrdenCompra.PasswordChar = false;
            this.txtNumOrdenCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumOrdenCompra.PlaceholderText = "";
            this.txtNumOrdenCompra.Size = new System.Drawing.Size(187, 36);
            this.txtNumOrdenCompra.TabIndex = 92;
            this.txtNumOrdenCompra.UnderlinedStyle = false;
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
            // gbDetalleOrdenCompra
            // 
            this.gbDetalleOrdenCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDetalleOrdenCompra.Controls.Add(this.txtCantidad);
            this.gbDetalleOrdenCompra.Controls.Add(this.label12);
            this.gbDetalleOrdenCompra.Controls.Add(this.dgvDetalleOrdenCompra);
            this.gbDetalleOrdenCompra.Controls.Add(this.label7);
            this.gbDetalleOrdenCompra.Controls.Add(this.lblCantidad);
            this.gbDetalleOrdenCompra.Controls.Add(this.txtIDProducto);
            this.gbDetalleOrdenCompra.Controls.Add(this.txtDesProducto);
            this.gbDetalleOrdenCompra.Controls.Add(this.btnBuscarProducto);
            this.gbDetalleOrdenCompra.Controls.Add(this.btnEliminarProd);
            this.gbDetalleOrdenCompra.Controls.Add(this.btnAgregarProd);
            this.gbDetalleOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.gbDetalleOrdenCompra.Location = new System.Drawing.Point(26, 439);
            this.gbDetalleOrdenCompra.Name = "gbDetalleOrdenCompra";
            this.gbDetalleOrdenCompra.Size = new System.Drawing.Size(1465, 323);
            this.gbDetalleOrdenCompra.TabIndex = 63;
            this.gbDetalleOrdenCompra.TabStop = false;
            this.gbDetalleOrdenCompra.Text = "DETALLE ORDEN COMPRA";
            this.gbDetalleOrdenCompra.Enter += new System.EventHandler(this.gbDetalleOrdenCompra_Enter);
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
            // dgvDetalleOrdenCompra
            // 
            this.dgvDetalleOrdenCompra.AllowUserToAddRows = false;
            this.dgvDetalleOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleOrdenCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvDetalleOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleOrdenCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalleOrdenCompra.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleOrdenCompra.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalleOrdenCompra.EnableHeadersVisualStyles = false;
            this.dgvDetalleOrdenCompra.Location = new System.Drawing.Point(28, 126);
            this.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra";
            this.dgvDetalleOrdenCompra.ReadOnly = true;
            this.dgvDetalleOrdenCompra.RowHeadersVisible = false;
            this.dgvDetalleOrdenCompra.RowHeadersWidth = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleOrdenCompra.RowTemplate.Height = 50;
            this.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenCompra.Size = new System.Drawing.Size(1414, 176);
            this.dgvDetalleOrdenCompra.TabIndex = 105;
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
            this.btnEliminarProd.Location = new System.Drawing.Point(1294, 38);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(148, 48);
            this.btnEliminarProd.TabIndex = 98;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.TextColor = System.Drawing.Color.White;
            this.btnEliminarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
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
            this.btnAgregarProd.Location = new System.Drawing.Point(1140, 38);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(148, 50);
            this.btnAgregarProd.TabIndex = 97;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextColor = System.Drawing.Color.White;
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(851, 810);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(176, 27);
            this.dtpBuscarFecha.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(847, 784);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "Buscar por Fecha:";
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.AllowUserToAddRows = false;
            this.dgvOrdenCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrdenCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrdenCompra.ColumnHeadersHeight = 40;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenCompra.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrdenCompra.EnableHeadersVisualStyles = false;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(26, 243);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.ReadOnly = true;
            this.dgvOrdenCompra.RowHeadersVisible = false;
            this.dgvOrdenCompra.RowHeadersWidth = 20;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrdenCompra.RowTemplate.Height = 50;
            this.dgvOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(1465, 190);
            this.dgvOrdenCompra.TabIndex = 104;
            this.dgvOrdenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenCompra_CellClick);
            this.dgvOrdenCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenCompra_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnBuscaridProveedor);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.txtRucProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 196);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION DEL CLIENTE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscaridProveedor
            // 
            this.btnBuscaridProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscaridProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscaridProveedor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscaridProveedor.BorderRadius = 40;
            this.btnBuscaridProveedor.BorderSize = 0;
            this.btnBuscaridProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscaridProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaridProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscaridProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscaridProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaridProveedor.Image")));
            this.btnBuscaridProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaridProveedor.Location = new System.Drawing.Point(293, 64);
            this.btnBuscaridProveedor.Name = "btnBuscaridProveedor";
            this.btnBuscaridProveedor.Size = new System.Drawing.Size(103, 37);
            this.btnBuscaridProveedor.TabIndex = 94;
            this.btnBuscaridProveedor.Text = "Buscar";
            this.btnBuscaridProveedor.TextColor = System.Drawing.Color.White;
            this.btnBuscaridProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscaridProveedor.UseVisualStyleBackColor = false;
            this.btnBuscaridProveedor.Click += new System.EventHandler(this.btnBuscaridProveedor_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtRazonSocial.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRazonSocial.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtRazonSocial.BorderRadius = 15;
            this.txtRazonSocial.BorderSize = 2;
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.Location = new System.Drawing.Point(20, 133);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Multiline = false;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRazonSocial.PasswordChar = false;
            this.txtRazonSocial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRazonSocial.PlaceholderText = "";
            this.txtRazonSocial.Size = new System.Drawing.Size(407, 36);
            this.txtRazonSocial.TabIndex = 89;
            this.txtRazonSocial.UnderlinedStyle = false;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtRucProveedor.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRucProveedor.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtRucProveedor.BorderRadius = 15;
            this.txtRucProveedor.BorderSize = 2;
            this.txtRucProveedor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtRucProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtRucProveedor.Location = new System.Drawing.Point(20, 66);
            this.txtRucProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtRucProveedor.Multiline = false;
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRucProveedor.PasswordChar = false;
            this.txtRucProveedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRucProveedor.PlaceholderText = "";
            this.txtRucProveedor.Size = new System.Drawing.Size(254, 36);
            this.txtRucProveedor.TabIndex = 88;
            this.txtRucProveedor.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "RUC Proveedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Razon Social:";
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarOC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarOC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarOC.BorderRadius = 40;
            this.btnBuscarOC.BorderSize = 0;
            this.btnBuscarOC.FlatAppearance.BorderSize = 0;
            this.btnBuscarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarOC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOC.Image")));
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(1041, 787);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarOC.TabIndex = 109;
            this.btnBuscarOC.Text = "Buscar";
            this.btnBuscarOC.TextColor = System.Drawing.Color.White;
            this.btnBuscarOC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarOC.UseVisualStyleBackColor = false;
            this.btnBuscarOC.Click += new System.EventHandler(this.btnBuscarOC_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(26, 787);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 103;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnAnular.Location = new System.Drawing.Point(1349, 787);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(148, 50);
            this.btnAnular.TabIndex = 102;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextColor = System.Drawing.Color.White;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(1195, 787);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 101;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1524, 874);
            this.Controls.Add(this.btnBuscarOC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpBuscarFecha);
            this.Controls.Add(this.gbDetalleOrdenCompra);
            this.Controls.Add(this.gboOrdenCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompra";
            this.Text = "Orden Compra";
            this.Load += new System.EventHandler(this.FrmOrdenCompra_Load);
            this.gboOrdenCompra.ResumeLayout(false);
            this.gboOrdenCompra.PerformLayout();
            this.gbDetalleOrdenCompra.ResumeLayout(false);
            this.gbDetalleOrdenCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboOrdenCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEstadoCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFOrdenCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbDetalleOrdenCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.Label label10;
        private NiikTextBox txtIDOrdenCompra;
        private NiikTextBox txtNumOrdenCompra;
        private NiikTextBox txtIDProducto;
        private NiikTextBox txtDesProducto;
        private Botones.Boton btnAgregarProd;
        private Botones.Boton btnEliminarProd;
        private Botones.Boton btnBuscarProducto;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnAnular;
        private Botones.Boton btnSalir;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenCompra;
        private Botones.Boton btnCancelar;
        private Botones.Boton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Botones.Boton btnBuscaridProveedor;
        private NiikTextBox txtRazonSocial;
        private NiikTextBox txtRucProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Botones.Boton btnBuscarOC;
        private NiikTextBox txtCantidad;
    }
}