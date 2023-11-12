namespace ProyectoGameCenter
{
    partial class FrmProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelContenedorCN = new System.Windows.Forms.Panel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscarRUC = new ProyectoGameCenter.NiikTextBox();
            this.btnEditar = new ProyectoGameCenter.Botones.Boton();
            this.btnInhabilitarProv = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscarProv = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxEstadoProv = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAgregar = new ProyectoGameCenter.Botones.Boton();
            this.btnCancelar = new ProyectoGameCenter.Botones.Boton();
            this.btnModificar = new ProyectoGameCenter.Botones.Boton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscarRucApi = new ProyectoGameCenter.Botones.Boton();
            this.txtDistrito = new ProyectoGameCenter.NiikTextBox();
            this.txtProvincia = new ProyectoGameCenter.NiikTextBox();
            this.txtDepartamento = new ProyectoGameCenter.NiikTextBox();
            this.txtCodigoUbigeo = new ProyectoGameCenter.NiikTextBox();
            this.txtDireccion = new ProyectoGameCenter.NiikTextBox();
            this.txtTelefono = new ProyectoGameCenter.NiikTextBox();
            this.txtRazonSocial = new ProyectoGameCenter.NiikTextBox();
            this.txtRuc = new ProyectoGameCenter.NiikTextBox();
            this.txtIDProveedor = new ProyectoGameCenter.NiikTextBox();
            this.PanelContenedorCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.gbProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(601, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razon Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(206, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "RUC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(214, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Direccion:";
            // 
            // PanelContenedorCN
            // 
            this.PanelContenedorCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelContenedorCN.Controls.Add(this.dgvProveedores);
            this.PanelContenedorCN.Controls.Add(this.txtBuscarRUC);
            this.PanelContenedorCN.Controls.Add(this.btnEditar);
            this.PanelContenedorCN.Controls.Add(this.btnInhabilitarProv);
            this.PanelContenedorCN.Controls.Add(this.btnBuscarProv);
            this.PanelContenedorCN.Controls.Add(this.btnSalir);
            this.PanelContenedorCN.Controls.Add(this.btnNuevo);
            this.PanelContenedorCN.Controls.Add(this.label1);
            this.PanelContenedorCN.Controls.Add(this.gbProveedor);
            this.PanelContenedorCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorCN.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorCN.Name = "PanelContenedorCN";
            this.PanelContenedorCN.Size = new System.Drawing.Size(1524, 874);
            this.PanelContenedorCN.TabIndex = 4;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 346);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.RowTemplate.Height = 50;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1500, 414);
            this.dgvProveedores.TabIndex = 113;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // txtBuscarRUC
            // 
            this.txtBuscarRUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarRUC.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarRUC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscarRUC.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscarRUC.BorderRadius = 15;
            this.txtBuscarRUC.BorderSize = 2;
            this.txtBuscarRUC.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscarRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarRUC.Location = new System.Drawing.Point(461, 810);
            this.txtBuscarRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRUC.Multiline = false;
            this.txtBuscarRUC.Name = "txtBuscarRUC";
            this.txtBuscarRUC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarRUC.PasswordChar = false;
            this.txtBuscarRUC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarRUC.PlaceholderText = "";
            this.txtBuscarRUC.Size = new System.Drawing.Size(250, 36);
            this.txtBuscarRUC.TabIndex = 112;
            this.txtBuscarRUC.UnderlinedStyle = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnEditar.Location = new System.Drawing.Point(1097, 796);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 50);
            this.btnEditar.TabIndex = 110;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInhabilitarProv
            // 
            this.btnInhabilitarProv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInhabilitarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnInhabilitarProv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnInhabilitarProv.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInhabilitarProv.BorderRadius = 40;
            this.btnInhabilitarProv.BorderSize = 0;
            this.btnInhabilitarProv.FlatAppearance.BorderSize = 0;
            this.btnInhabilitarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarProv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnInhabilitarProv.ForeColor = System.Drawing.Color.White;
            this.btnInhabilitarProv.Image = ((System.Drawing.Image)(resources.GetObject("btnInhabilitarProv.Image")));
            this.btnInhabilitarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhabilitarProv.Location = new System.Drawing.Point(1286, 796);
            this.btnInhabilitarProv.Name = "btnInhabilitarProv";
            this.btnInhabilitarProv.Size = new System.Drawing.Size(148, 50);
            this.btnInhabilitarProv.TabIndex = 109;
            this.btnInhabilitarProv.Text = "Inhabilitar";
            this.btnInhabilitarProv.TextColor = System.Drawing.Color.White;
            this.btnInhabilitarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInhabilitarProv.UseVisualStyleBackColor = false;
            this.btnInhabilitarProv.Click += new System.EventHandler(this.btnInhabilitarProv_Click);
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProv.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarProv.BorderRadius = 40;
            this.btnBuscarProv.BorderSize = 0;
            this.btnBuscarProv.FlatAppearance.BorderSize = 0;
            this.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProv.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProv.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProv.Image")));
            this.btnBuscarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProv.Location = new System.Drawing.Point(729, 798);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarProv.TabIndex = 108;
            this.btnBuscarProv.Text = "Buscar";
            this.btnBuscarProv.TextColor = System.Drawing.Color.White;
            this.btnBuscarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProv.UseVisualStyleBackColor = false;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(89, 796);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 107;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(909, 796);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 106;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 783);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 105;
            this.label1.Text = "BUSCAR RUC:";
            // 
            // gbProveedor
            // 
            this.gbProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProveedor.Controls.Add(this.label11);
            this.gbProveedor.Controls.Add(this.cbxEstadoProv);
            this.gbProveedor.Controls.Add(this.label3);
            this.gbProveedor.Controls.Add(this.label13);
            this.gbProveedor.Controls.Add(this.label14);
            this.gbProveedor.Controls.Add(this.label15);
            this.gbProveedor.Controls.Add(this.label9);
            this.gbProveedor.Controls.Add(this.btnAgregar);
            this.gbProveedor.Controls.Add(this.btnCancelar);
            this.gbProveedor.Controls.Add(this.btnModificar);
            this.gbProveedor.Controls.Add(this.label16);
            this.gbProveedor.Controls.Add(this.btnBuscarRucApi);
            this.gbProveedor.Controls.Add(this.txtDistrito);
            this.gbProveedor.Controls.Add(this.txtProvincia);
            this.gbProveedor.Controls.Add(this.txtDepartamento);
            this.gbProveedor.Controls.Add(this.txtCodigoUbigeo);
            this.gbProveedor.Controls.Add(this.txtDireccion);
            this.gbProveedor.Controls.Add(this.txtTelefono);
            this.gbProveedor.Controls.Add(this.txtRazonSocial);
            this.gbProveedor.Controls.Add(this.txtRuc);
            this.gbProveedor.Controls.Add(this.label5);
            this.gbProveedor.Controls.Add(this.txtIDProveedor);
            this.gbProveedor.Controls.Add(this.label2);
            this.gbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProveedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProveedor.ForeColor = System.Drawing.Color.White;
            this.gbProveedor.Location = new System.Drawing.Point(12, 12);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(1500, 247);
            this.gbProveedor.TabIndex = 33;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "DATOS DEL PROVEEDOR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 23);
            this.label11.TabIndex = 69;
            this.label11.Text = "Codigo Ubigeo:";
            // 
            // cbxEstadoProv
            // 
            this.cbxEstadoProv.AutoSize = true;
            this.cbxEstadoProv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoProv.Font = new System.Drawing.Font("Century Gothic", 14.5F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoProv.Location = new System.Drawing.Point(1197, 158);
            this.cbxEstadoProv.Name = "cbxEstadoProv";
            this.cbxEstadoProv.Size = new System.Drawing.Size(93, 27);
            this.cbxEstadoProv.TabIndex = 36;
            this.cbxEstadoProv.Text = "Estado";
            this.cbxEstadoProv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID Proveedor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1065, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Telefono:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(601, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "Departamento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(800, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 23);
            this.label15.TabIndex = 13;
            this.label15.Text = "Provincia:";
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
            this.btnAgregar.Location = new System.Drawing.Point(1329, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 50);
            this.btnAgregar.TabIndex = 102;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(1329, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 48);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(1329, 99);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 50);
            this.btnModificar.TabIndex = 103;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(982, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 23);
            this.label16.TabIndex = 14;
            this.label16.Text = "Distrito:";
            // 
            // btnBuscarRucApi
            // 
            this.btnBuscarRucApi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarRucApi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarRucApi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarRucApi.BorderRadius = 40;
            this.btnBuscarRucApi.BorderSize = 0;
            this.btnBuscarRucApi.FlatAppearance.BorderSize = 0;
            this.btnBuscarRucApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRucApi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarRucApi.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRucApi.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarRucApi.Image")));
            this.btnBuscarRucApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarRucApi.Location = new System.Drawing.Point(448, 77);
            this.btnBuscarRucApi.Name = "btnBuscarRucApi";
            this.btnBuscarRucApi.Size = new System.Drawing.Size(103, 37);
            this.btnBuscarRucApi.TabIndex = 101;
            this.btnBuscarRucApi.Text = "Buscar";
            this.btnBuscarRucApi.TextColor = System.Drawing.Color.White;
            this.btnBuscarRucApi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarRucApi.UseVisualStyleBackColor = false;
            this.btnBuscarRucApi.Click += new System.EventHandler(this.btnBuscarRucApi_Click);
            // 
            // txtDistrito
            // 
            this.txtDistrito.BackColor = System.Drawing.SystemColors.Window;
            this.txtDistrito.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDistrito.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDistrito.BorderRadius = 15;
            this.txtDistrito.BorderSize = 2;
            this.txtDistrito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDistrito.ForeColor = System.Drawing.Color.Black;
            this.txtDistrito.Location = new System.Drawing.Point(984, 158);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistrito.Multiline = false;
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDistrito.PasswordChar = false;
            this.txtDistrito.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDistrito.PlaceholderText = "";
            this.txtDistrito.Size = new System.Drawing.Size(173, 36);
            this.txtDistrito.TabIndex = 99;
            this.txtDistrito.UnderlinedStyle = false;
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.SystemColors.Window;
            this.txtProvincia.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtProvincia.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtProvincia.BorderRadius = 15;
            this.txtProvincia.BorderSize = 2;
            this.txtProvincia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtProvincia.ForeColor = System.Drawing.Color.Black;
            this.txtProvincia.Location = new System.Drawing.Point(802, 158);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvincia.Multiline = false;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProvincia.PasswordChar = false;
            this.txtProvincia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProvincia.PlaceholderText = "";
            this.txtProvincia.Size = new System.Drawing.Size(151, 36);
            this.txtProvincia.TabIndex = 98;
            this.txtProvincia.UnderlinedStyle = false;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDepartamento.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDepartamento.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDepartamento.BorderRadius = 15;
            this.txtDepartamento.BorderSize = 2;
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDepartamento.ForeColor = System.Drawing.Color.Black;
            this.txtDepartamento.Location = new System.Drawing.Point(605, 158);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartamento.Multiline = false;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDepartamento.PasswordChar = false;
            this.txtDepartamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDepartamento.PlaceholderText = "";
            this.txtDepartamento.Size = new System.Drawing.Size(175, 36);
            this.txtDepartamento.TabIndex = 97;
            this.txtDepartamento.UnderlinedStyle = false;
            // 
            // txtCodigoUbigeo
            // 
            this.txtCodigoUbigeo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoUbigeo.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCodigoUbigeo.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtCodigoUbigeo.BorderRadius = 15;
            this.txtCodigoUbigeo.BorderSize = 2;
            this.txtCodigoUbigeo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCodigoUbigeo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoUbigeo.Location = new System.Drawing.Point(32, 158);
            this.txtCodigoUbigeo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoUbigeo.Multiline = false;
            this.txtCodigoUbigeo.Name = "txtCodigoUbigeo";
            this.txtCodigoUbigeo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigoUbigeo.PasswordChar = false;
            this.txtCodigoUbigeo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoUbigeo.PlaceholderText = "";
            this.txtCodigoUbigeo.Size = new System.Drawing.Size(112, 36);
            this.txtCodigoUbigeo.TabIndex = 96;
            this.txtCodigoUbigeo.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDireccion.BorderRadius = 15;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(210, 158);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.Size = new System.Drawing.Size(359, 36);
            this.txtDireccion.TabIndex = 95;
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(1069, 78);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(164, 36);
            this.txtTelefono.TabIndex = 94;
            this.txtTelefono.UnderlinedStyle = false;
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
            this.txtRazonSocial.Location = new System.Drawing.Point(605, 77);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Multiline = false;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRazonSocial.PasswordChar = false;
            this.txtRazonSocial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRazonSocial.PlaceholderText = "";
            this.txtRazonSocial.Size = new System.Drawing.Size(440, 36);
            this.txtRazonSocial.TabIndex = 93;
            this.txtRazonSocial.UnderlinedStyle = false;
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.SystemColors.Window;
            this.txtRuc.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRuc.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtRuc.BorderRadius = 15;
            this.txtRuc.BorderSize = 2;
            this.txtRuc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtRuc.ForeColor = System.Drawing.Color.Black;
            this.txtRuc.Location = new System.Drawing.Point(210, 78);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuc.Multiline = false;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRuc.PasswordChar = false;
            this.txtRuc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRuc.PlaceholderText = "";
            this.txtRuc.Size = new System.Drawing.Size(217, 36);
            this.txtRuc.TabIndex = 92;
            this.txtRuc.UnderlinedStyle = false;
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDProveedor.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDProveedor.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDProveedor.BorderRadius = 15;
            this.txtIDProveedor.BorderSize = 2;
            this.txtIDProveedor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtIDProveedor.Location = new System.Drawing.Point(32, 78);
            this.txtIDProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProveedor.Multiline = false;
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDProveedor.PasswordChar = false;
            this.txtIDProveedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDProveedor.PlaceholderText = "";
            this.txtIDProveedor.Size = new System.Drawing.Size(112, 36);
            this.txtIDProveedor.TabIndex = 91;
            this.txtIDProveedor.UnderlinedStyle = false;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 874);
            this.Controls.Add(this.PanelContenedorCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.PanelContenedorCN.ResumeLayout(false);
            this.PanelContenedorCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PanelContenedorCN;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxEstadoProv;
        private System.Windows.Forms.Label label11;
        private NiikTextBox txtIDProveedor;
        private NiikTextBox txtDistrito;
        private NiikTextBox txtProvincia;
        private NiikTextBox txtDepartamento;
        private NiikTextBox txtCodigoUbigeo;
        private NiikTextBox txtDireccion;
        private NiikTextBox txtTelefono;
        private NiikTextBox txtRazonSocial;
        private NiikTextBox txtRuc;
        private Botones.Boton btnBuscarRucApi;
        private Botones.Boton btnCancelar;
        private Botones.Boton btnAgregar;
        private Botones.Boton btnModificar;
        private NiikTextBox txtBuscarRUC;
        private Botones.Boton btnEditar;
        private Botones.Boton btnInhabilitarProv;
        private Botones.Boton btnBuscarProv;
        private Botones.Boton btnSalir;
        private Botones.Boton btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProveedores;
    }
}