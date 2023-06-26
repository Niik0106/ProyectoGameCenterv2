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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraTituloCN = new System.Windows.Forms.Panel();
            this.gboOrdenCompra = new System.Windows.Forms.GroupBox();
            this.btnBuscaridProveedor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpFAtendida = new System.Windows.Forms.DateTimePicker();
            this.dtpFOrdenCompra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEstadoCompra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDOrdenCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.gbDetalleOrdenCompra = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.dgvDetalleOrdenCompra = new System.Windows.Forms.DataGridView();
            this.BarraTituloCN.SuspendLayout();
            this.gboOrdenCompra.SuspendLayout();
            this.gbDetalleOrdenCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "ORDEN DE COMPRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarraTituloCN
            // 
            this.BarraTituloCN.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTituloCN.Controls.Add(this.label1);
            this.BarraTituloCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloCN.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloCN.Name = "BarraTituloCN";
            this.BarraTituloCN.Size = new System.Drawing.Size(1050, 60);
            this.BarraTituloCN.TabIndex = 38;
            // 
            // gboOrdenCompra
            // 
            this.gboOrdenCompra.Controls.Add(this.btnBuscaridProveedor);
            this.gboOrdenCompra.Controls.Add(this.label9);
            this.gboOrdenCompra.Controls.Add(this.textBox2);
            this.gboOrdenCompra.Controls.Add(this.label8);
            this.gboOrdenCompra.Controls.Add(this.textBox1);
            this.gboOrdenCompra.Controls.Add(this.dtpFAtendida);
            this.gboOrdenCompra.Controls.Add(this.dtpFOrdenCompra);
            this.gboOrdenCompra.Controls.Add(this.label6);
            this.gboOrdenCompra.Controls.Add(this.btnCancelar);
            this.gboOrdenCompra.Controls.Add(this.btnAgregar);
            this.gboOrdenCompra.Controls.Add(this.label5);
            this.gboOrdenCompra.Controls.Add(this.cbxEstadoCompra);
            this.gboOrdenCompra.Controls.Add(this.label3);
            this.gboOrdenCompra.Controls.Add(this.txtIDOrdenCompra);
            this.gboOrdenCompra.Controls.Add(this.label4);
            this.gboOrdenCompra.Controls.Add(this.txtIDProveedor);
            this.gboOrdenCompra.Controls.Add(this.label2);
            this.gboOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOrdenCompra.ForeColor = System.Drawing.Color.DarkViolet;
            this.gboOrdenCompra.Location = new System.Drawing.Point(24, 81);
            this.gboOrdenCompra.Name = "gboOrdenCompra";
            this.gboOrdenCompra.Size = new System.Drawing.Size(528, 285);
            this.gboOrdenCompra.TabIndex = 57;
            this.gboOrdenCompra.TabStop = false;
            this.gboOrdenCompra.Text = "ORDEN DE COMPRA";
            // 
            // btnBuscaridProveedor
            // 
            this.btnBuscaridProveedor.BackColor = System.Drawing.Color.White;
            this.btnBuscaridProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaridProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscaridProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaridProveedor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaridProveedor.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscaridProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaridProveedor.Image")));
            this.btnBuscaridProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaridProveedor.Location = new System.Drawing.Point(327, 133);
            this.btnBuscaridProveedor.Name = "btnBuscaridProveedor";
            this.btnBuscaridProveedor.Size = new System.Drawing.Size(71, 29);
            this.btnBuscaridProveedor.TabIndex = 72;
            this.btnBuscaridProveedor.Text = "buscar";
            this.btnBuscaridProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaridProveedor.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(6, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 59;
            this.label9.Text = "R. SOCIAL:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(116, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(247, 27);
            this.textBox2.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(25, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "N° Orden Compra:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(213, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 27);
            this.textBox1.TabIndex = 57;
            // 
            // dtpFAtendida
            // 
            this.dtpFAtendida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFAtendida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFAtendida.Location = new System.Drawing.Point(213, 205);
            this.dtpFAtendida.Name = "dtpFAtendida";
            this.dtpFAtendida.Size = new System.Drawing.Size(150, 27);
            this.dtpFAtendida.TabIndex = 53;
            // 
            // dtpFOrdenCompra
            // 
            this.dtpFOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFOrdenCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFOrdenCompra.Location = new System.Drawing.Point(213, 100);
            this.dtpFOrdenCompra.Name = "dtpFOrdenCompra";
            this.dtpFOrdenCompra.Size = new System.Drawing.Size(150, 27);
            this.dtpFOrdenCompra.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(43, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Fecha Atendida:";
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
            this.btnCancelar.Location = new System.Drawing.Point(380, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 45);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Location = new System.Drawing.Point(380, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 45);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(29, 102);
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
            this.cbxEstadoCompra.Location = new System.Drawing.Point(182, 240);
            this.cbxEstadoCompra.Name = "cbxEstadoCompra";
            this.cbxEstadoCompra.Size = new System.Drawing.Size(181, 27);
            this.cbxEstadoCompra.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID Orden Compra:";
            // 
            // txtIDOrdenCompra
            // 
            this.txtIDOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenCompra.Location = new System.Drawing.Point(213, 33);
            this.txtIDOrdenCompra.Name = "txtIDOrdenCompra";
            this.txtIDOrdenCompra.Size = new System.Drawing.Size(108, 27);
            this.txtIDOrdenCompra.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(76, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "ID Proveedor:";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtIDProveedor.Location = new System.Drawing.Point(213, 133);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.ReadOnly = true;
            this.txtIDProveedor.Size = new System.Drawing.Size(108, 27);
            this.txtIDProveedor.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(17, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Estado Compra:";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtIDProducto.Location = new System.Drawing.Point(164, 33);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.ReadOnly = true;
            this.txtIDProducto.Size = new System.Drawing.Size(157, 27);
            this.txtIDProducto.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(37, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 54;
            this.label7.Text = "ID Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtCantidad.Location = new System.Drawing.Point(166, 100);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(96, 27);
            this.txtCantidad.TabIndex = 34;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblCantidad.Location = new System.Drawing.Point(56, 103);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(104, 23);
            this.lblCantidad.TabIndex = 33;
            this.lblCantidad.Text = "Cantidad:";
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
            this.btnAnular.Location = new System.Drawing.Point(892, 588);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(130, 50);
            this.btnAnular.TabIndex = 61;
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
            this.btnNuevo.Location = new System.Drawing.Point(734, 588);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 60;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
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
            this.btnSalir.Location = new System.Drawing.Point(19, 588);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 50);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.BackColor = System.Drawing.Color.White;
            this.btnBuscarOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOC.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarOC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOC.Image")));
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(577, 588);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(130, 50);
            this.btnBuscarOC.TabIndex = 59;
            this.btnBuscarOC.Text = "Buscar";
            this.btnBuscarOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOC.UseVisualStyleBackColor = false;
            // 
            // gbDetalleOrdenCompra
            // 
            this.gbDetalleOrdenCompra.Controls.Add(this.dgvDetalleOrdenCompra);
            this.gbDetalleOrdenCompra.Controls.Add(this.label12);
            this.gbDetalleOrdenCompra.Controls.Add(this.txtDesProducto);
            this.gbDetalleOrdenCompra.Controls.Add(this.btnBuscarProducto);
            this.gbDetalleOrdenCompra.Controls.Add(this.btnEliminarProd);
            this.gbDetalleOrdenCompra.Controls.Add(this.txtIDProducto);
            this.gbDetalleOrdenCompra.Controls.Add(this.btnAgregarProd);
            this.gbDetalleOrdenCompra.Controls.Add(this.label7);
            this.gbDetalleOrdenCompra.Controls.Add(this.txtCantidad);
            this.gbDetalleOrdenCompra.Controls.Add(this.lblCantidad);
            this.gbDetalleOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleOrdenCompra.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbDetalleOrdenCompra.Location = new System.Drawing.Point(568, 81);
            this.gbDetalleOrdenCompra.Name = "gbDetalleOrdenCompra";
            this.gbDetalleOrdenCompra.Size = new System.Drawing.Size(454, 285);
            this.gbDetalleOrdenCompra.TabIndex = 63;
            this.gbDetalleOrdenCompra.TabStop = false;
            this.gbDetalleOrdenCompra.Text = "DETALLE ORDEN COMPRA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkViolet;
            this.label12.Location = new System.Drawing.Point(24, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Des Producto:";
            // 
            // txtDesProducto
            // 
            this.txtDesProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProducto.Location = new System.Drawing.Point(164, 66);
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.ReadOnly = true;
            this.txtDesProducto.Size = new System.Drawing.Size(246, 27);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(327, 31);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 29);
            this.btnBuscarProducto.TabIndex = 71;
            this.btnBuscarProducto.Text = "buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.White;
            this.btnEliminarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnEliminarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProd.Image")));
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(399, 211);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(49, 43);
            this.btnEliminarProd.TabIndex = 29;
            this.btnEliminarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.White;
            this.btnAgregarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAgregarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.Image")));
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Location = new System.Drawing.Point(399, 148);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(49, 43);
            this.btnAgregarProd.TabIndex = 3;
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(378, 611);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(176, 27);
            this.dtpBuscarFecha.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(374, 585);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "Buscar por Fecha:";
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(19, 375);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(1003, 200);
            this.dgvOrdenCompra.TabIndex = 66;
            // 
            // dgvDetalleOrdenCompra
            // 
            this.dgvDetalleOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleOrdenCompra.Location = new System.Drawing.Point(19, 135);
            this.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenCompra.Size = new System.Drawing.Size(374, 134);
            this.dgvDetalleOrdenCompra.TabIndex = 75;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpBuscarFecha);
            this.Controls.Add(this.gbDetalleOrdenCompra);
            this.Controls.Add(this.btnBuscarOC);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gboOrdenCompra);
            this.Controls.Add(this.BarraTituloCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompra";
            this.Text = "FmrOrdenCompra";
            this.BarraTituloCN.ResumeLayout(false);
            this.gboOrdenCompra.ResumeLayout(false);
            this.gboOrdenCompra.PerformLayout();
            this.gbDetalleOrdenCompra.ResumeLayout(false);
            this.gbDetalleOrdenCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BarraTituloCN;
        private System.Windows.Forms.GroupBox gboOrdenCompra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDOrdenCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxEstadoCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFAtendida;
        private System.Windows.Forms.DateTimePicker dtpFOrdenCompra;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscaridProveedor;
        private System.Windows.Forms.GroupBox gbDetalleOrdenCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenCompra;
    }
}