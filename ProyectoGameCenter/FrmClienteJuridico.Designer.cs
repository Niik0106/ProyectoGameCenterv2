namespace ProyectoGameCenter
{
    partial class FrmClienteJuridico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteJuridico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTituloCN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedorCN = new System.Windows.Forms.Panel();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnEditar = new ProyectoGameCenter.Botones.Boton();
            this.btnInhabilitarCliJur = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscarCliJur = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRucBuscar = new System.Windows.Forms.TextBox();
            this.gbClienteJuridico = new System.Windows.Forms.GroupBox();
            this.btnBuscarClienteJuridicoReniec = new ProyectoGameCenter.Botones.Boton();
            this.btnCancelar = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregar = new ProyectoGameCenter.Botones.Boton();
            this.btnModificar = new ProyectoGameCenter.Botones.Boton();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.cbxEstadoCliJur = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvClienteJuridico = new System.Windows.Forms.DataGridView();
            this.BarraTituloCN.SuspendLayout();
            this.PanelContenedorCN.SuspendLayout();
            this.gbClienteJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteJuridico)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTituloCN
            // 
            this.BarraTituloCN.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTituloCN.Controls.Add(this.label1);
            this.BarraTituloCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloCN.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloCN.Name = "BarraTituloCN";
            this.BarraTituloCN.Size = new System.Drawing.Size(1386, 60);
            this.BarraTituloCN.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(1386, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "CLIENTE JURIDICO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenedorCN
            // 
            this.PanelContenedorCN.BackColor = System.Drawing.Color.White;
            this.PanelContenedorCN.Controls.Add(this.btnSalir);
            this.PanelContenedorCN.Controls.Add(this.btnEditar);
            this.PanelContenedorCN.Controls.Add(this.btnInhabilitarCliJur);
            this.PanelContenedorCN.Controls.Add(this.btnBuscarCliJur);
            this.PanelContenedorCN.Controls.Add(this.btnNuevo);
            this.PanelContenedorCN.Controls.Add(this.label3);
            this.PanelContenedorCN.Controls.Add(this.txtRucBuscar);
            this.PanelContenedorCN.Controls.Add(this.gbClienteJuridico);
            this.PanelContenedorCN.Controls.Add(this.dgvClienteJuridico);
            this.PanelContenedorCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorCN.Location = new System.Drawing.Point(0, 60);
            this.PanelContenedorCN.Name = "PanelContenedorCN";
            this.PanelContenedorCN.Size = new System.Drawing.Size(1386, 728);
            this.PanelContenedorCN.TabIndex = 3;
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
            this.btnSalir.Location = new System.Drawing.Point(91, 801);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 79;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(1296, 801);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 50);
            this.btnEditar.TabIndex = 78;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInhabilitarCliJur
            // 
            this.btnInhabilitarCliJur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnInhabilitarCliJur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnInhabilitarCliJur.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInhabilitarCliJur.BorderRadius = 40;
            this.btnInhabilitarCliJur.BorderSize = 0;
            this.btnInhabilitarCliJur.FlatAppearance.BorderSize = 0;
            this.btnInhabilitarCliJur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarCliJur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnInhabilitarCliJur.ForeColor = System.Drawing.Color.White;
            this.btnInhabilitarCliJur.Image = ((System.Drawing.Image)(resources.GetObject("btnInhabilitarCliJur.Image")));
            this.btnInhabilitarCliJur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhabilitarCliJur.Location = new System.Drawing.Point(1472, 801);
            this.btnInhabilitarCliJur.Name = "btnInhabilitarCliJur";
            this.btnInhabilitarCliJur.Size = new System.Drawing.Size(148, 50);
            this.btnInhabilitarCliJur.TabIndex = 77;
            this.btnInhabilitarCliJur.Text = "Inhabilitar";
            this.btnInhabilitarCliJur.TextColor = System.Drawing.Color.White;
            this.btnInhabilitarCliJur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInhabilitarCliJur.UseVisualStyleBackColor = false;
            this.btnInhabilitarCliJur.Click += new System.EventHandler(this.btnInhabilitarCliJur_Click);
            // 
            // btnBuscarCliJur
            // 
            this.btnBuscarCliJur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarCliJur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarCliJur.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarCliJur.BorderRadius = 40;
            this.btnBuscarCliJur.BorderSize = 0;
            this.btnBuscarCliJur.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliJur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliJur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliJur.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliJur.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliJur.Image")));
            this.btnBuscarCliJur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliJur.Location = new System.Drawing.Point(934, 804);
            this.btnBuscarCliJur.Name = "btnBuscarCliJur";
            this.btnBuscarCliJur.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarCliJur.TabIndex = 76;
            this.btnBuscarCliJur.Text = "Buscar";
            this.btnBuscarCliJur.TextColor = System.Drawing.Color.White;
            this.btnBuscarCliJur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCliJur.UseVisualStyleBackColor = false;
            this.btnBuscarCliJur.Click += new System.EventHandler(this.btnBuscarCliJur_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(1119, 801);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 75;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(712, 798);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Buscar RUC:";
            // 
            // txtRucBuscar
            // 
            this.txtRucBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRucBuscar.Location = new System.Drawing.Point(716, 824);
            this.txtRucBuscar.Name = "txtRucBuscar";
            this.txtRucBuscar.Size = new System.Drawing.Size(208, 27);
            this.txtRucBuscar.TabIndex = 61;
            this.txtRucBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRucBuscar_KeyPress);
            // 
            // gbClienteJuridico
            // 
            this.gbClienteJuridico.Controls.Add(this.btnBuscarClienteJuridicoReniec);
            this.gbClienteJuridico.Controls.Add(this.btnCancelar);
            this.gbClienteJuridico.Controls.Add(this.btnAgregar);
            this.gbClienteJuridico.Controls.Add(this.btnModificar);
            this.gbClienteJuridico.Controls.Add(this.txtDepartamento);
            this.gbClienteJuridico.Controls.Add(this.txtProvincia);
            this.gbClienteJuridico.Controls.Add(this.txtDistrito);
            this.gbClienteJuridico.Controls.Add(this.cbxEstadoCliJur);
            this.gbClienteJuridico.Controls.Add(this.label10);
            this.gbClienteJuridico.Controls.Add(this.txtIDCliente);
            this.gbClienteJuridico.Controls.Add(this.txtRUC);
            this.gbClienteJuridico.Controls.Add(this.label5);
            this.gbClienteJuridico.Controls.Add(this.label2);
            this.gbClienteJuridico.Controls.Add(this.txtRazonSocial);
            this.gbClienteJuridico.Controls.Add(this.label4);
            this.gbClienteJuridico.Controls.Add(this.txtTelefono);
            this.gbClienteJuridico.Controls.Add(this.txtDireccion);
            this.gbClienteJuridico.Controls.Add(this.label6);
            this.gbClienteJuridico.Controls.Add(this.label7);
            this.gbClienteJuridico.Controls.Add(this.label8);
            this.gbClienteJuridico.Controls.Add(this.label9);
            this.gbClienteJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbClienteJuridico.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteJuridico.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbClienteJuridico.Location = new System.Drawing.Point(153, 56);
            this.gbClienteJuridico.Name = "gbClienteJuridico";
            this.gbClienteJuridico.Size = new System.Drawing.Size(1348, 310);
            this.gbClienteJuridico.TabIndex = 31;
            this.gbClienteJuridico.TabStop = false;
            this.gbClienteJuridico.Text = "DATOS DEL CLIENTE";
            // 
            // btnBuscarClienteJuridicoReniec
            // 
            this.btnBuscarClienteJuridicoReniec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarClienteJuridicoReniec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarClienteJuridicoReniec.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarClienteJuridicoReniec.BorderRadius = 40;
            this.btnBuscarClienteJuridicoReniec.BorderSize = 0;
            this.btnBuscarClienteJuridicoReniec.FlatAppearance.BorderSize = 0;
            this.btnBuscarClienteJuridicoReniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClienteJuridicoReniec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClienteJuridicoReniec.ForeColor = System.Drawing.Color.White;
            this.btnBuscarClienteJuridicoReniec.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteJuridicoReniec.Image")));
            this.btnBuscarClienteJuridicoReniec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarClienteJuridicoReniec.Location = new System.Drawing.Point(536, 84);
            this.btnBuscarClienteJuridicoReniec.Name = "btnBuscarClienteJuridicoReniec";
            this.btnBuscarClienteJuridicoReniec.Size = new System.Drawing.Size(98, 30);
            this.btnBuscarClienteJuridicoReniec.TabIndex = 76;
            this.btnBuscarClienteJuridicoReniec.Text = "Buscar";
            this.btnBuscarClienteJuridicoReniec.TextColor = System.Drawing.Color.White;
            this.btnBuscarClienteJuridicoReniec.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarClienteJuridicoReniec.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(1158, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 48);
            this.btnCancelar.TabIndex = 74;
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
            this.btnAgregar.Location = new System.Drawing.Point(1158, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 50);
            this.btnAgregar.TabIndex = 72;
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
            this.btnModificar.Location = new System.Drawing.Point(1158, 132);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 50);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(746, 147);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(261, 27);
            this.txtDepartamento.TabIndex = 61;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(48, 214);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(296, 27);
            this.txtProvincia.TabIndex = 60;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Enabled = false;
            this.txtDistrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrito.Location = new System.Drawing.Point(410, 214);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.ReadOnly = true;
            this.txtDistrito.Size = new System.Drawing.Size(274, 27);
            this.txtDistrito.TabIndex = 59;
            // 
            // cbxEstadoCliJur
            // 
            this.cbxEstadoCliJur.AutoSize = true;
            this.cbxEstadoCliJur.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoCliJur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoCliJur.Location = new System.Drawing.Point(1005, 214);
            this.cbxEstadoCliJur.Name = "cbxEstadoCliJur";
            this.cbxEstadoCliJur.Size = new System.Drawing.Size(91, 27);
            this.cbxEstadoCliJur.TabIndex = 58;
            this.cbxEstadoCliJur.Text = "Estado";
            this.cbxEstadoCliJur.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(44, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(48, 84);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(208, 27);
            this.txtIDCliente.TabIndex = 26;
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(322, 84);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(208, 27);
            this.txtRUC.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(318, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "RUC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(48, 147);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(296, 27);
            this.txtRazonSocial.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(742, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(746, 214);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(208, 27);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(410, 151);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(294, 23);
            this.txtDireccion.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(742, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(47, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Provincia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(406, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distrito:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(406, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Direccion:";
            // 
            // dgvClienteJuridico
            // 
            this.dgvClienteJuridico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteJuridico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteJuridico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteJuridico.Location = new System.Drawing.Point(157, 404);
            this.dgvClienteJuridico.Name = "dgvClienteJuridico";
            this.dgvClienteJuridico.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClienteJuridico.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClienteJuridico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteJuridico.Size = new System.Drawing.Size(1344, 373);
            this.dgvClienteJuridico.TabIndex = 26;
            this.dgvClienteJuridico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteJuridico_CellClick);
            // 
            // FrmClienteJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.PanelContenedorCN);
            this.Controls.Add(this.BarraTituloCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteJuridico";
            this.Text = "FrmClienteJuridico";
            this.BarraTituloCN.ResumeLayout(false);
            this.PanelContenedorCN.ResumeLayout(false);
            this.PanelContenedorCN.PerformLayout();
            this.gbClienteJuridico.ResumeLayout(false);
            this.gbClienteJuridico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteJuridico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelContenedorCN;
        private System.Windows.Forms.GroupBox gbClienteJuridico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbxEstadoCliJur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRucBuscar;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.DataGridView dgvClienteJuridico;
        private Botones.Boton btnCancelar;
        private Botones.Boton btnAgregar;
        private Botones.Boton btnModificar;
        private Botones.Boton btnEditar;
        private Botones.Boton btnInhabilitarCliJur;
        private Botones.Boton btnBuscarCliJur;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnSalir;
        private Botones.Boton btnBuscarClienteJuridicoReniec;
    }
}