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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelContenedorCN = new System.Windows.Forms.Panel();
            this.boton1 = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnEditar = new ProyectoGameCenter.Botones.Boton();
            this.btnInhabilitarCliJur = new ProyectoGameCenter.Botones.Boton();
            this.btnBuscarCliJur = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.label3 = new System.Windows.Forms.Label();
            this.gbClienteJuridico = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregar = new ProyectoGameCenter.Botones.Boton();
            this.btnModificar = new ProyectoGameCenter.Botones.Boton();
            this.cbxEstadoCliJur = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvClienteJuridico = new System.Windows.Forms.DataGridView();
            this.txtIDCliente = new ProyectoGameCenter.NiikTextBox();
            this.txtRUC = new ProyectoGameCenter.NiikTextBox();
            this.txtRazonSocial = new ProyectoGameCenter.NiikTextBox();
            this.txtDireccion = new ProyectoGameCenter.NiikTextBox();
            this.txtProvincia = new ProyectoGameCenter.NiikTextBox();
            this.txtDepartamento = new ProyectoGameCenter.NiikTextBox();
            this.txtDistrito = new ProyectoGameCenter.NiikTextBox();
            this.txtTelefono = new ProyectoGameCenter.NiikTextBox();
            this.txtRucBuscar = new ProyectoGameCenter.NiikTextBox();
            this.PanelContenedorCN.SuspendLayout();
            this.gbClienteJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteJuridico)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedorCN
            // 
            this.PanelContenedorCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelContenedorCN.Controls.Add(this.txtRucBuscar);
            this.PanelContenedorCN.Controls.Add(this.dgvClienteJuridico);
            this.PanelContenedorCN.Controls.Add(this.boton1);
            this.PanelContenedorCN.Controls.Add(this.btnSalir);
            this.PanelContenedorCN.Controls.Add(this.btnEditar);
            this.PanelContenedorCN.Controls.Add(this.btnInhabilitarCliJur);
            this.PanelContenedorCN.Controls.Add(this.btnBuscarCliJur);
            this.PanelContenedorCN.Controls.Add(this.btnNuevo);
            this.PanelContenedorCN.Controls.Add(this.label3);
            this.PanelContenedorCN.Controls.Add(this.gbClienteJuridico);
            this.PanelContenedorCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorCN.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorCN.Name = "PanelContenedorCN";
            this.PanelContenedorCN.Size = new System.Drawing.Size(1524, 874);
            this.PanelContenedorCN.TabIndex = 3;
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.boton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.boton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton1.BorderRadius = 40;
            this.boton1.BorderSize = 0;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.White;
            this.boton1.Image = ((System.Drawing.Image)(resources.GetObject("boton1.Image")));
            this.boton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton1.Location = new System.Drawing.Point(383, 813);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(98, 30);
            this.boton1.TabIndex = 80;
            this.boton1.Text = "Buscar";
            this.boton1.TextColor = System.Drawing.Color.White;
            this.boton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click_1);
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
            this.btnSalir.Location = new System.Drawing.Point(48, 801);
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
            this.btnEditar.Location = new System.Drawing.Point(1082, 801);
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
            this.btnInhabilitarCliJur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnInhabilitarCliJur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnInhabilitarCliJur.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInhabilitarCliJur.BorderRadius = 40;
            this.btnInhabilitarCliJur.BorderSize = 0;
            this.btnInhabilitarCliJur.FlatAppearance.BorderSize = 0;
            this.btnInhabilitarCliJur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarCliJur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnInhabilitarCliJur.ForeColor = System.Drawing.Color.White;
            this.btnInhabilitarCliJur.Image = ((System.Drawing.Image)(resources.GetObject("btnInhabilitarCliJur.Image")));
            this.btnInhabilitarCliJur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhabilitarCliJur.Location = new System.Drawing.Point(1248, 801);
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
            this.btnBuscarCliJur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarCliJur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarCliJur.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarCliJur.BorderRadius = 40;
            this.btnBuscarCliJur.BorderSize = 0;
            this.btnBuscarCliJur.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliJur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliJur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliJur.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliJur.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliJur.Image")));
            this.btnBuscarCliJur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliJur.Location = new System.Drawing.Point(745, 801);
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
            this.btnNuevo.Location = new System.Drawing.Point(915, 801);
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 781);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Buscar RUC:";
            // 
            // gbClienteJuridico
            // 
            this.gbClienteJuridico.Controls.Add(this.txtTelefono);
            this.gbClienteJuridico.Controls.Add(this.txtDistrito);
            this.gbClienteJuridico.Controls.Add(this.txtDepartamento);
            this.gbClienteJuridico.Controls.Add(this.txtProvincia);
            this.gbClienteJuridico.Controls.Add(this.txtDireccion);
            this.gbClienteJuridico.Controls.Add(this.txtRazonSocial);
            this.gbClienteJuridico.Controls.Add(this.txtRUC);
            this.gbClienteJuridico.Controls.Add(this.txtIDCliente);
            this.gbClienteJuridico.Controls.Add(this.btnCancelar);
            this.gbClienteJuridico.Controls.Add(this.btnAgregar);
            this.gbClienteJuridico.Controls.Add(this.btnModificar);
            this.gbClienteJuridico.Controls.Add(this.cbxEstadoCliJur);
            this.gbClienteJuridico.Controls.Add(this.label10);
            this.gbClienteJuridico.Controls.Add(this.label5);
            this.gbClienteJuridico.Controls.Add(this.label2);
            this.gbClienteJuridico.Controls.Add(this.label4);
            this.gbClienteJuridico.Controls.Add(this.label6);
            this.gbClienteJuridico.Controls.Add(this.label7);
            this.gbClienteJuridico.Controls.Add(this.label8);
            this.gbClienteJuridico.Controls.Add(this.label9);
            this.gbClienteJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbClienteJuridico.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteJuridico.ForeColor = System.Drawing.Color.White;
            this.gbClienteJuridico.Location = new System.Drawing.Point(48, 44);
            this.gbClienteJuridico.Name = "gbClienteJuridico";
            this.gbClienteJuridico.Size = new System.Drawing.Size(1348, 274);
            this.gbClienteJuridico.TabIndex = 31;
            this.gbClienteJuridico.TabStop = false;
            this.gbClienteJuridico.Text = "DATOS DEL CLIENTE";
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
            this.btnCancelar.Location = new System.Drawing.Point(1158, 193);
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
            this.btnAgregar.Location = new System.Drawing.Point(1158, 43);
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
            this.btnModificar.Location = new System.Drawing.Point(1158, 121);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 50);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxEstadoCliJur
            // 
            this.cbxEstadoCliJur.AutoSize = true;
            this.cbxEstadoCliJur.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoCliJur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoCliJur.ForeColor = System.Drawing.Color.White;
            this.cbxEstadoCliJur.Location = new System.Drawing.Point(1015, 214);
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
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(349, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "RUC:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razon Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(693, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
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
            this.label7.ForeColor = System.Drawing.Color.White;
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
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(374, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distrito:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(406, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Direccion:";
            // 
            // dgvClienteJuridico
            // 
            this.dgvClienteJuridico.AllowUserToAddRows = false;
            this.dgvClienteJuridico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClienteJuridico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvClienteJuridico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClienteJuridico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteJuridico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteJuridico.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClienteJuridico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClienteJuridico.EnableHeadersVisualStyles = false;
            this.dgvClienteJuridico.Location = new System.Drawing.Point(48, 353);
            this.dgvClienteJuridico.Name = "dgvClienteJuridico";
            this.dgvClienteJuridico.ReadOnly = true;
            this.dgvClienteJuridico.RowHeadersVisible = false;
            this.dgvClienteJuridico.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClienteJuridico.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClienteJuridico.RowTemplate.Height = 50;
            this.dgvClienteJuridico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteJuridico.Size = new System.Drawing.Size(1332, 380);
            this.dgvClienteJuridico.TabIndex = 81;
            this.dgvClienteJuridico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteJuridico_CellClick);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDCliente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIDCliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDCliente.BorderRadius = 15;
            this.txtIDCliente.BorderSize = 2;
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDCliente.Location = new System.Drawing.Point(48, 84);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCliente.Multiline = false;
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDCliente.PasswordChar = false;
            this.txtIDCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDCliente.PlaceholderText = "";
            this.txtIDCliente.Size = new System.Drawing.Size(250, 36);
            this.txtIDCliente.TabIndex = 75;
            this.txtIDCliente.UnderlinedStyle = false;
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.SystemColors.Window;
            this.txtRUC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRUC.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRUC.BorderRadius = 15;
            this.txtRUC.BorderSize = 2;
            this.txtRUC.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRUC.Location = new System.Drawing.Point(343, 84);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRUC.Multiline = false;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRUC.PasswordChar = false;
            this.txtRUC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRUC.PlaceholderText = "";
            this.txtRUC.Size = new System.Drawing.Size(250, 36);
            this.txtRUC.TabIndex = 76;
            this.txtRUC.UnderlinedStyle = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtRazonSocial.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRazonSocial.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRazonSocial.BorderRadius = 15;
            this.txtRazonSocial.BorderSize = 2;
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRazonSocial.Location = new System.Drawing.Point(48, 148);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Multiline = false;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRazonSocial.PasswordChar = false;
            this.txtRazonSocial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRazonSocial.PlaceholderText = "";
            this.txtRazonSocial.Size = new System.Drawing.Size(326, 36);
            this.txtRazonSocial.TabIndex = 77;
            this.txtRazonSocial.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDireccion.BorderRadius = 15;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(410, 147);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.Size = new System.Drawing.Size(250, 36);
            this.txtDireccion.TabIndex = 78;
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.SystemColors.Window;
            this.txtProvincia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtProvincia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProvincia.BorderRadius = 15;
            this.txtProvincia.BorderSize = 2;
            this.txtProvincia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProvincia.Location = new System.Drawing.Point(48, 215);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvincia.Multiline = false;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProvincia.PasswordChar = false;
            this.txtProvincia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProvincia.PlaceholderText = "";
            this.txtProvincia.Size = new System.Drawing.Size(283, 36);
            this.txtProvincia.TabIndex = 79;
            this.txtProvincia.UnderlinedStyle = false;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDepartamento.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDepartamento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDepartamento.BorderRadius = 15;
            this.txtDepartamento.BorderSize = 2;
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepartamento.Location = new System.Drawing.Point(746, 148);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartamento.Multiline = false;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDepartamento.PasswordChar = false;
            this.txtDepartamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDepartamento.PlaceholderText = "";
            this.txtDepartamento.Size = new System.Drawing.Size(250, 36);
            this.txtDepartamento.TabIndex = 80;
            this.txtDepartamento.UnderlinedStyle = false;
            // 
            // txtDistrito
            // 
            this.txtDistrito.BackColor = System.Drawing.SystemColors.Window;
            this.txtDistrito.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDistrito.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDistrito.BorderRadius = 15;
            this.txtDistrito.BorderSize = 2;
            this.txtDistrito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDistrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDistrito.Location = new System.Drawing.Point(377, 214);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistrito.Multiline = false;
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDistrito.PasswordChar = false;
            this.txtDistrito.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDistrito.PlaceholderText = "";
            this.txtDistrito.Size = new System.Drawing.Size(283, 36);
            this.txtDistrito.TabIndex = 81;
            this.txtDistrito.UnderlinedStyle = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(697, 215);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(283, 36);
            this.txtTelefono.TabIndex = 82;
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtRucBuscar
            // 
            this.txtRucBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtRucBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRucBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRucBuscar.BorderRadius = 15;
            this.txtRucBuscar.BorderSize = 2;
            this.txtRucBuscar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtRucBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRucBuscar.Location = new System.Drawing.Point(488, 808);
            this.txtRucBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtRucBuscar.Multiline = false;
            this.txtRucBuscar.Name = "txtRucBuscar";
            this.txtRucBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRucBuscar.PasswordChar = false;
            this.txtRucBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRucBuscar.PlaceholderText = "";
            this.txtRucBuscar.Size = new System.Drawing.Size(250, 36);
            this.txtRucBuscar.TabIndex = 82;
            this.txtRucBuscar.UnderlinedStyle = false;
            // 
            // FrmClienteJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 874);
            this.Controls.Add(this.PanelContenedorCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteJuridico";
            this.Text = "FrmClienteJuridico";
            this.PanelContenedorCN.ResumeLayout(false);
            this.PanelContenedorCN.PerformLayout();
            this.gbClienteJuridico.ResumeLayout(false);
            this.gbClienteJuridico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteJuridico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelContenedorCN;
        private System.Windows.Forms.GroupBox gbClienteJuridico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbxEstadoCliJur;
        private System.Windows.Forms.Label label3;
        private Botones.Boton btnCancelar;
        private Botones.Boton btnAgregar;
        private Botones.Boton btnModificar;
        private Botones.Boton btnEditar;
        private Botones.Boton btnInhabilitarCliJur;
        private Botones.Boton btnBuscarCliJur;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnSalir;
        private Botones.Boton boton1;
        private System.Windows.Forms.DataGridView dgvClienteJuridico;
        private NiikTextBox txtDireccion;
        private NiikTextBox txtRazonSocial;
        private NiikTextBox txtRUC;
        private NiikTextBox txtIDCliente;
        private NiikTextBox txtRucBuscar;
        private NiikTextBox txtTelefono;
        private NiikTextBox txtDistrito;
        private NiikTextBox txtDepartamento;
        private NiikTextBox txtProvincia;
    }
}