namespace ProyectoGameCenter
{
    partial class FrmClienteNatural
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteNatural));
            this.BarraTituloCN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedorCN = new System.Windows.Forms.Panel();
            this.dgvClienteNatural = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.gbClientesNatural = new System.Windows.Forms.GroupBox();
            this.cbxEstadoCliNat = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregar = new ProyectoGameCenter.Botones.Boton();
            this.btnModificar = new ProyectoGameCenter.Botones.Boton();
            this.btnEditar = new ProyectoGameCenter.Botones.Boton();
            this.btnInhabilitarCliNat = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscarCliNat = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscarClienteReniec = new ProyectoGameCenter.Botones.Boton();
            this.BarraTituloCN.SuspendLayout();
            this.PanelContenedorCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteNatural)).BeginInit();
            this.gbClientesNatural.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTituloCN
            // 
            this.BarraTituloCN.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTituloCN.Controls.Add(this.label1);
            this.BarraTituloCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloCN.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloCN.Name = "BarraTituloCN";
            this.BarraTituloCN.Size = new System.Drawing.Size(1654, 60);
            this.BarraTituloCN.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(1654, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "CLIENTE NATURAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenedorCN
            // 
            this.PanelContenedorCN.BackColor = System.Drawing.Color.White;
            this.PanelContenedorCN.Controls.Add(this.btnEditar);
            this.PanelContenedorCN.Controls.Add(this.btnInhabilitarCliNat);
            this.PanelContenedorCN.Controls.Add(this.btnBuscarCliNat);
            this.PanelContenedorCN.Controls.Add(this.btnSalir);
            this.PanelContenedorCN.Controls.Add(this.btnNuevo);
            this.PanelContenedorCN.Controls.Add(this.pictureBox1);
            this.PanelContenedorCN.Controls.Add(this.dgvClienteNatural);
            this.PanelContenedorCN.Controls.Add(this.label11);
            this.PanelContenedorCN.Controls.Add(this.txtBuscarDNI);
            this.PanelContenedorCN.Controls.Add(this.gbClientesNatural);
            this.PanelContenedorCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorCN.Location = new System.Drawing.Point(0, 60);
            this.PanelContenedorCN.Name = "PanelContenedorCN";
            this.PanelContenedorCN.Size = new System.Drawing.Size(1654, 881);
            this.PanelContenedorCN.TabIndex = 2;
            // 
            // dgvClienteNatural
            // 
            this.dgvClienteNatural.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteNatural.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteNatural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteNatural.Location = new System.Drawing.Point(417, 371);
            this.dgvClienteNatural.Name = "dgvClienteNatural";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClienteNatural.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClienteNatural.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteNatural.Size = new System.Drawing.Size(1048, 396);
            this.dgvClienteNatural.TabIndex = 63;
            this.dgvClienteNatural.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteNatural_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkViolet;
            this.label11.Location = new System.Drawing.Point(647, 798);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 62;
            this.label11.Text = "BUSCAR DNI:";
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDNI.Location = new System.Drawing.Point(651, 824);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(208, 27);
            this.txtBuscarDNI.TabIndex = 61;
            this.txtBuscarDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDNI_KeyPress);
            // 
            // gbClientesNatural
            // 
            this.gbClientesNatural.Controls.Add(this.btnBuscarClienteReniec);
            this.gbClientesNatural.Controls.Add(this.btnCancelar);
            this.gbClientesNatural.Controls.Add(this.btnAgregar);
            this.gbClientesNatural.Controls.Add(this.label6);
            this.gbClientesNatural.Controls.Add(this.btnModificar);
            this.gbClientesNatural.Controls.Add(this.txtApellidoMaterno);
            this.gbClientesNatural.Controls.Add(this.cbxEstadoCliNat);
            this.gbClientesNatural.Controls.Add(this.label10);
            this.gbClientesNatural.Controls.Add(this.txtIDCliente);
            this.gbClientesNatural.Controls.Add(this.txtDNI);
            this.gbClientesNatural.Controls.Add(this.label5);
            this.gbClientesNatural.Controls.Add(this.label2);
            this.gbClientesNatural.Controls.Add(this.txtNombres);
            this.gbClientesNatural.Controls.Add(this.label3);
            this.gbClientesNatural.Controls.Add(this.txtApellidoPaterno);
            this.gbClientesNatural.Controls.Add(this.label4);
            this.gbClientesNatural.Controls.Add(this.txtTelefono);
            this.gbClientesNatural.Enabled = false;
            this.gbClientesNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbClientesNatural.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientesNatural.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbClientesNatural.Location = new System.Drawing.Point(254, 56);
            this.gbClientesNatural.Name = "gbClientesNatural";
            this.gbClientesNatural.Size = new System.Drawing.Size(1111, 273);
            this.gbClientesNatural.TabIndex = 31;
            this.gbClientesNatural.TabStop = false;
            this.gbClientesNatural.Text = "DATOS DEL CLIENTE";
            // 
            // cbxEstadoCliNat
            // 
            this.cbxEstadoCliNat.AutoSize = true;
            this.cbxEstadoCliNat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoCliNat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoCliNat.Location = new System.Drawing.Point(310, 204);
            this.cbxEstadoCliNat.Name = "cbxEstadoCliNat";
            this.cbxEstadoCliNat.Size = new System.Drawing.Size(91, 27);
            this.cbxEstadoCliNat.TabIndex = 59;
            this.cbxEstadoCliNat.Text = "Estado";
            this.cbxEstadoCliNat.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(57, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(61, 66);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(133, 27);
            this.txtIDCliente.TabIndex = 26;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(310, 66);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(208, 27);
            this.txtDNI.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(306, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(57, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(61, 134);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(315, 27);
            this.txtNombres.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(399, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(403, 134);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(208, 27);
            this.txtApellidoPaterno.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(57, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(61, 207);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(208, 27);
            this.txtTelefono.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(629, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Apellido Materno:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(633, 134);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(208, 27);
            this.txtApellidoMaterno.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(922, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 48);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(922, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 50);
            this.btnAgregar.TabIndex = 69;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 40;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(922, 115);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 50);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 40;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1227, 798);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 50);
            this.btnEditar.TabIndex = 74;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInhabilitarCliNat
            // 
            this.btnInhabilitarCliNat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnInhabilitarCliNat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnInhabilitarCliNat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInhabilitarCliNat.BorderRadius = 40;
            this.btnInhabilitarCliNat.BorderSize = 0;
            this.btnInhabilitarCliNat.FlatAppearance.BorderSize = 0;
            this.btnInhabilitarCliNat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarCliNat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnInhabilitarCliNat.ForeColor = System.Drawing.Color.White;
            this.btnInhabilitarCliNat.Image = ((System.Drawing.Image)(resources.GetObject("btnInhabilitarCliNat.Image")));
            this.btnInhabilitarCliNat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhabilitarCliNat.Location = new System.Drawing.Point(1403, 798);
            this.btnInhabilitarCliNat.Name = "btnInhabilitarCliNat";
            this.btnInhabilitarCliNat.Size = new System.Drawing.Size(148, 50);
            this.btnInhabilitarCliNat.TabIndex = 73;
            this.btnInhabilitarCliNat.Text = "Inhabilitar";
            this.btnInhabilitarCliNat.TextColor = System.Drawing.Color.White;
            this.btnInhabilitarCliNat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInhabilitarCliNat.UseVisualStyleBackColor = false;
            this.btnInhabilitarCliNat.Click += new System.EventHandler(this.btnInhabilitarCliNat_Click);
            // 
            // btnBuscarCliNat
            // 
            this.btnBuscarCliNat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarCliNat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarCliNat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarCliNat.BorderRadius = 40;
            this.btnBuscarCliNat.BorderSize = 0;
            this.btnBuscarCliNat.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliNat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliNat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliNat.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliNat.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliNat.Image")));
            this.btnBuscarCliNat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliNat.Location = new System.Drawing.Point(865, 801);
            this.btnBuscarCliNat.Name = "btnBuscarCliNat";
            this.btnBuscarCliNat.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarCliNat.TabIndex = 72;
            this.btnBuscarCliNat.Text = "Buscar";
            this.btnBuscarCliNat.TextColor = System.Drawing.Color.White;
            this.btnBuscarCliNat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCliNat.UseVisualStyleBackColor = false;
            this.btnBuscarCliNat.Click += new System.EventHandler(this.btnBuscarCliNat_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 40;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(116, 801);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 71;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevo.BorderRadius = 40;
            this.btnNuevo.BorderSize = 0;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1050, 798);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 70;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarClienteReniec
            // 
            this.btnBuscarClienteReniec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarClienteReniec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarClienteReniec.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarClienteReniec.BorderRadius = 40;
            this.btnBuscarClienteReniec.BorderSize = 0;
            this.btnBuscarClienteReniec.FlatAppearance.BorderSize = 0;
            this.btnBuscarClienteReniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClienteReniec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClienteReniec.ForeColor = System.Drawing.Color.White;
            this.btnBuscarClienteReniec.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteReniec.Image")));
            this.btnBuscarClienteReniec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarClienteReniec.Location = new System.Drawing.Point(524, 66);
            this.btnBuscarClienteReniec.Name = "btnBuscarClienteReniec";
            this.btnBuscarClienteReniec.Size = new System.Drawing.Size(98, 30);
            this.btnBuscarClienteReniec.TabIndex = 75;
            this.btnBuscarClienteReniec.Text = "Buscar";
            this.btnBuscarClienteReniec.TextColor = System.Drawing.Color.White;
            this.btnBuscarClienteReniec.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarClienteReniec.UseVisualStyleBackColor = false;
            // 
            // FrmClienteNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 941);
            this.Controls.Add(this.PanelContenedorCN);
            this.Controls.Add(this.BarraTituloCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteNatural";
            this.Text = "FrmCliente";
            this.BarraTituloCN.ResumeLayout(false);
            this.PanelContenedorCN.ResumeLayout(false);
            this.PanelContenedorCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteNatural)).EndInit();
            this.gbClientesNatural.ResumeLayout(false);
            this.gbClientesNatural.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraTituloCN;
        private System.Windows.Forms.Panel PanelContenedorCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox gbClientesNatural;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.CheckBox cbxEstadoCliNat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.DataGridView dgvClienteNatural;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private Botones.Boton btnCancelar;
        private Botones.Boton btnAgregar;
        private Botones.Boton btnModificar;
        private Botones.Boton btnEditar;
        private Botones.Boton btnInhabilitarCliNat;
        private Botones.Boton btnBuscarCliNat;
        private Botones.Boton btnSalir;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnBuscarClienteReniec;
    }
}