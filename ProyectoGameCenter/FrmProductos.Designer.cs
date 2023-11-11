namespace ProyectoGameCenter
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.txtStock = new ProyectoGameCenter.NiikTextBox();
            this.txtPrecioCompra = new ProyectoGameCenter.NiikTextBox();
            this.txtPrecioVenta = new ProyectoGameCenter.NiikTextBox();
            this.txtDescripcionProducto = new ProyectoGameCenter.NiikTextBox();
            this.txtIDProducto = new ProyectoGameCenter.NiikTextBox();
            this.btnCancelar = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregar = new ProyectoGameCenter.Botones.Boton();
            this.btnModificar = new ProyectoGameCenter.Botones.Boton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstadoProd = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarProducto = new ProyectoGameCenter.NiikTextBox();
            this.btnEditar = new ProyectoGameCenter.Botones.Boton();
            this.btnDeshabilitarProd = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscarProd = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(359, 102);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(208, 29);
            this.cboCategoria.TabIndex = 22;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(359, 165);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(208, 29);
            this.cboMarca.TabIndex = 23;
            // 
            // gbProductos
            // 
            this.gbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProductos.Controls.Add(this.txtStock);
            this.gbProductos.Controls.Add(this.txtPrecioCompra);
            this.gbProductos.Controls.Add(this.txtPrecioVenta);
            this.gbProductos.Controls.Add(this.txtDescripcionProducto);
            this.gbProductos.Controls.Add(this.txtIDProducto);
            this.gbProductos.Controls.Add(this.btnCancelar);
            this.gbProductos.Controls.Add(this.btnAgregar);
            this.gbProductos.Controls.Add(this.btnModificar);
            this.gbProductos.Controls.Add(this.label6);
            this.gbProductos.Controls.Add(this.cbxEstadoProd);
            this.gbProductos.Controls.Add(this.label2);
            this.gbProductos.Controls.Add(this.label4);
            this.gbProductos.Controls.Add(this.label3);
            this.gbProductos.Controls.Add(this.cboMarca);
            this.gbProductos.Controls.Add(this.cboCategoria);
            this.gbProductos.Controls.Add(this.label8);
            this.gbProductos.Controls.Add(this.label9);
            this.gbProductos.Controls.Add(this.label10);
            this.gbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProductos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.ForeColor = System.Drawing.Color.White;
            this.gbProductos.Location = new System.Drawing.Point(24, 47);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(1458, 261);
            this.gbProductos.TabIndex = 38;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "DATOS DEL PRODUCTO";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Window;
            this.txtStock.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtStock.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtStock.BorderRadius = 15;
            this.txtStock.BorderSize = 2;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.Location = new System.Drawing.Point(906, 102);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStock.PasswordChar = false;
            this.txtStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStock.PlaceholderText = "";
            this.txtStock.Size = new System.Drawing.Size(138, 36);
            this.txtStock.TabIndex = 73;
            this.txtStock.UnderlinedStyle = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCompra.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrecioCompra.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtPrecioCompra.BorderRadius = 15;
            this.txtPrecioCompra.BorderSize = 2;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioCompra.Location = new System.Drawing.Point(623, 162);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioCompra.PasswordChar = false;
            this.txtPrecioCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioCompra.PlaceholderText = "";
            this.txtPrecioCompra.Size = new System.Drawing.Size(250, 36);
            this.txtPrecioCompra.TabIndex = 72;
            this.txtPrecioCompra.UnderlinedStyle = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrecioVenta.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtPrecioVenta.BorderRadius = 15;
            this.txtPrecioVenta.BorderSize = 2;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(619, 98);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioVenta.PasswordChar = false;
            this.txtPrecioVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.Size = new System.Drawing.Size(250, 36);
            this.txtPrecioVenta.TabIndex = 71;
            this.txtPrecioVenta.UnderlinedStyle = false;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcionProducto.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDescripcionProducto.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDescripcionProducto.BorderRadius = 15;
            this.txtDescripcionProducto.BorderSize = 2;
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(44, 161);
            this.txtDescripcionProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionProducto.Multiline = false;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcionProducto.PasswordChar = false;
            this.txtDescripcionProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcionProducto.PlaceholderText = "";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(250, 36);
            this.txtDescripcionProducto.TabIndex = 70;
            this.txtDescripcionProducto.UnderlinedStyle = false;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDProducto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIDProducto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDProducto.BorderRadius = 15;
            this.txtIDProducto.BorderSize = 2;
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDProducto.Location = new System.Drawing.Point(44, 98);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProducto.Multiline = false;
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDProducto.PasswordChar = false;
            this.txtIDProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDProducto.PlaceholderText = "";
            this.txtIDProducto.Size = new System.Drawing.Size(250, 36);
            this.txtIDProducto.TabIndex = 69;
            this.txtIDProducto.UnderlinedStyle = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(1269, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 48);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(1269, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 50);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 40;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(1269, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 50);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(619, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Precio de Compra:";
            // 
            // cbxEstadoProd
            // 
            this.cbxEstadoProd.AutoSize = true;
            this.cbxEstadoProd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoProd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoProd.ForeColor = System.Drawing.Color.White;
            this.cbxEstadoProd.Location = new System.Drawing.Point(906, 162);
            this.cbxEstadoProd.Name = "cbxEstadoProd";
            this.cbxEstadoProd.Size = new System.Drawing.Size(91, 27);
            this.cbxEstadoProd.TabIndex = 45;
            this.cbxEstadoProd.Text = "Estado";
            this.cbxEstadoProd.UseVisualStyleBackColor = true;
            this.cbxEstadoProd.CheckedChanged += new System.EventHandler(this.cbxEstadoProd_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(355, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(355, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(619, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Precio de Compra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(902, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(379, 748);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "Descripcion:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Location = new System.Drawing.Point(108, 339);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowTemplate.Height = 50;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1332, 380);
            this.dgvProductos.TabIndex = 64;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarProducto.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBuscarProducto.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtBuscarProducto.BorderRadius = 15;
            this.txtBuscarProducto.BorderSize = 2;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarProducto.Location = new System.Drawing.Point(373, 775);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Multiline = false;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarProducto.PasswordChar = false;
            this.txtBuscarProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProducto.PlaceholderText = "";
            this.txtBuscarProducto.Size = new System.Drawing.Size(250, 36);
            this.txtBuscarProducto.TabIndex = 73;
            this.txtBuscarProducto.UnderlinedStyle = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 40;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1111, 761);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 50);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitarProd
            // 
            this.btnDeshabilitarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnDeshabilitarProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnDeshabilitarProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeshabilitarProd.BorderRadius = 40;
            this.btnDeshabilitarProd.BorderSize = 0;
            this.btnDeshabilitarProd.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitarProd.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitarProd.Image")));
            this.btnDeshabilitarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitarProd.Location = new System.Drawing.Point(1292, 761);
            this.btnDeshabilitarProd.Name = "btnDeshabilitarProd";
            this.btnDeshabilitarProd.Size = new System.Drawing.Size(148, 50);
            this.btnDeshabilitarProd.TabIndex = 68;
            this.btnDeshabilitarProd.Text = "Deshabilitar";
            this.btnDeshabilitarProd.TextColor = System.Drawing.Color.White;
            this.btnDeshabilitarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeshabilitarProd.UseVisualStyleBackColor = false;
            this.btnDeshabilitarProd.Click += new System.EventHandler(this.btnDeshabilitarProd_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarProd.BorderRadius = 40;
            this.btnBuscarProd.BorderSize = 0;
            this.btnBuscarProd.FlatAppearance.BorderSize = 0;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProd.Image")));
            this.btnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProd.Location = new System.Drawing.Point(643, 761);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarProd.TabIndex = 67;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.TextColor = System.Drawing.Color.White;
            this.btnBuscarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnSalir
            // 
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
            this.btnSalir.Location = new System.Drawing.Point(68, 761);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 66;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
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
            this.btnNuevo.Location = new System.Drawing.Point(920, 761);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1524, 874);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitarProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxEstadoProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label6;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnAgregar;
        private Botones.Boton btnCancelar;
        private Botones.Boton btnModificar;
        private Botones.Boton btnSalir;
        private Botones.Boton btnBuscarProd;
        private Botones.Boton btnDeshabilitarProd;
        private Botones.Boton btnEditar;
        private NiikTextBox txtIDProducto;
        private NiikTextBox txtDescripcionProducto;
        private NiikTextBox txtStock;
        private NiikTextBox txtPrecioCompra;
        private NiikTextBox txtPrecioVenta;
        private NiikTextBox txtBuscarProducto;
        //private TxtRedondeado txtRedondeado1;
        //private TxtRedondeado txtRedondeado2;
    }
}