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
            this.btnBuscarCliJur = new System.Windows.Forms.Button();
            this.gbClientesJuridico = new System.Windows.Forms.GroupBox();
            this.cbxEstadoCliJur = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInhabilitarCliJur = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvClienteJuridico = new System.Windows.Forms.DataGridView();
            this.txtRucBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraTituloCN.SuspendLayout();
            this.PanelContenedorCN.SuspendLayout();
            this.gbClientesJuridico.SuspendLayout();
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
            this.BarraTituloCN.Size = new System.Drawing.Size(1050, 60);
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
            this.label1.Size = new System.Drawing.Size(1050, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "CLIENTE JURIDICO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenedorCN
            // 
            this.PanelContenedorCN.BackColor = System.Drawing.Color.White;
            this.PanelContenedorCN.Controls.Add(this.label3);
            this.PanelContenedorCN.Controls.Add(this.txtRucBuscar);
            this.PanelContenedorCN.Controls.Add(this.btnBuscarCliJur);
            this.PanelContenedorCN.Controls.Add(this.gbClientesJuridico);
            this.PanelContenedorCN.Controls.Add(this.btnSalir);
            this.PanelContenedorCN.Controls.Add(this.btnInhabilitarCliJur);
            this.PanelContenedorCN.Controls.Add(this.btnEditar);
            this.PanelContenedorCN.Controls.Add(this.btnNuevo);
            this.PanelContenedorCN.Controls.Add(this.dgvClienteJuridico);
            this.PanelContenedorCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorCN.Location = new System.Drawing.Point(0, 60);
            this.PanelContenedorCN.Name = "PanelContenedorCN";
            this.PanelContenedorCN.Size = new System.Drawing.Size(1050, 590);
            this.PanelContenedorCN.TabIndex = 3;
            // 
            // btnBuscarCliJur
            // 
            this.btnBuscarCliJur.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliJur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliJur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarCliJur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliJur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliJur.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarCliJur.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliJur.Image")));
            this.btnBuscarCliJur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliJur.Location = new System.Drawing.Point(412, 527);
            this.btnBuscarCliJur.Name = "btnBuscarCliJur";
            this.btnBuscarCliJur.Size = new System.Drawing.Size(130, 50);
            this.btnBuscarCliJur.TabIndex = 60;
            this.btnBuscarCliJur.Text = "Buscar";
            this.btnBuscarCliJur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliJur.UseVisualStyleBackColor = false;
            // 
            // gbClientesJuridico
            // 
            this.gbClientesJuridico.Controls.Add(this.cbxEstadoCliJur);
            this.gbClientesJuridico.Controls.Add(this.label10);
            this.gbClientesJuridico.Controls.Add(this.txtIDCliente);
            this.gbClientesJuridico.Controls.Add(this.txtRUC);
            this.gbClientesJuridico.Controls.Add(this.label5);
            this.gbClientesJuridico.Controls.Add(this.label2);
            this.gbClientesJuridico.Controls.Add(this.txtRazonSocial);
            this.gbClientesJuridico.Controls.Add(this.btnCancelar);
            this.gbClientesJuridico.Controls.Add(this.label4);
            this.gbClientesJuridico.Controls.Add(this.btnModificar);
            this.gbClientesJuridico.Controls.Add(this.txtTelefono);
            this.gbClientesJuridico.Controls.Add(this.btnAgregar);
            this.gbClientesJuridico.Controls.Add(this.txtDireccion);
            this.gbClientesJuridico.Controls.Add(this.cboDistrito);
            this.gbClientesJuridico.Controls.Add(this.label6);
            this.gbClientesJuridico.Controls.Add(this.cboProvincia);
            this.gbClientesJuridico.Controls.Add(this.label7);
            this.gbClientesJuridico.Controls.Add(this.cboDepartamento);
            this.gbClientesJuridico.Controls.Add(this.label8);
            this.gbClientesJuridico.Controls.Add(this.label9);
            this.gbClientesJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbClientesJuridico.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientesJuridico.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbClientesJuridico.Location = new System.Drawing.Point(19, 15);
            this.gbClientesJuridico.Name = "gbClientesJuridico";
            this.gbClientesJuridico.Size = new System.Drawing.Size(1003, 265);
            this.gbClientesJuridico.TabIndex = 31;
            this.gbClientesJuridico.TabStop = false;
            this.gbClientesJuridico.Text = "DATOS DEL CLIENTE";
            // 
            // cbxEstadoCliJur
            // 
            this.cbxEstadoCliJur.AutoSize = true;
            this.cbxEstadoCliJur.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoCliJur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoCliJur.Location = new System.Drawing.Point(467, 211);
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
            this.txtIDCliente.Location = new System.Drawing.Point(154, 56);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(208, 27);
            this.txtIDCliente.TabIndex = 26;
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(154, 95);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(208, 27);
            this.txtRUC.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(94, 95);
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
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(154, 134);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(208, 27);
            this.txtRazonSocial.TabIndex = 17;
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
            this.btnCancelar.Location = new System.Drawing.Point(846, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 50);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(56, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(846, 108);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 50);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(154, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(208, 27);
            this.txtTelefono.TabIndex = 19;
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
            this.btnAgregar.Location = new System.Drawing.Point(846, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(545, 182);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(246, 23);
            this.txtDireccion.TabIndex = 20;
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(545, 136);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(246, 29);
            this.cboDistrito.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(389, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(545, 92);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(244, 29);
            this.cboProvincia.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(438, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Provincia:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(545, 54);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(246, 29);
            this.cboDepartamento.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(463, 139);
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
            this.label9.Location = new System.Drawing.Point(436, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Direccion:";
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
            this.btnSalir.Location = new System.Drawing.Point(21, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 50);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitarCliJur
            // 
            this.btnInhabilitarCliJur.BackColor = System.Drawing.Color.White;
            this.btnInhabilitarCliJur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInhabilitarCliJur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnInhabilitarCliJur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarCliJur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarCliJur.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnInhabilitarCliJur.Image = ((System.Drawing.Image)(resources.GetObject("btnInhabilitarCliJur.Image")));
            this.btnInhabilitarCliJur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhabilitarCliJur.Location = new System.Drawing.Point(880, 527);
            this.btnInhabilitarCliJur.Name = "btnInhabilitarCliJur";
            this.btnInhabilitarCliJur.Size = new System.Drawing.Size(144, 50);
            this.btnInhabilitarCliJur.TabIndex = 29;
            this.btnInhabilitarCliJur.Text = "Inhabilitar";
            this.btnInhabilitarCliJur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInhabilitarCliJur.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(720, 528);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 50);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnNuevo.Location = new System.Drawing.Point(564, 528);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvClienteJuridico
            // 
            this.dgvClienteJuridico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClienteJuridico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClienteJuridico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteJuridico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteJuridico.ColumnHeadersHeight = 30;
            this.dgvClienteJuridico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClienteJuridico.ColumnHeadersVisible = false;
            this.dgvClienteJuridico.Location = new System.Drawing.Point(21, 286);
            this.dgvClienteJuridico.Name = "dgvClienteJuridico";
            this.dgvClienteJuridico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClienteJuridico.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClienteJuridico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteJuridico.Size = new System.Drawing.Size(1003, 229);
            this.dgvClienteJuridico.TabIndex = 26;
            // 
            // txtRucBuscar
            // 
            this.txtRucBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRucBuscar.Location = new System.Drawing.Point(198, 550);
            this.txtRucBuscar.Name = "txtRucBuscar";
            this.txtRucBuscar.ReadOnly = true;
            this.txtRucBuscar.Size = new System.Drawing.Size(208, 27);
            this.txtRucBuscar.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(194, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Buscar RUC:";
            // 
            // FrmClienteJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.PanelContenedorCN);
            this.Controls.Add(this.BarraTituloCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteJuridico";
            this.Text = "FrmClienteJuridico";
            this.BarraTituloCN.ResumeLayout(false);
            this.PanelContenedorCN.ResumeLayout(false);
            this.PanelContenedorCN.PerformLayout();
            this.gbClientesJuridico.ResumeLayout(false);
            this.gbClientesJuridico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteJuridico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelContenedorCN;
        private System.Windows.Forms.GroupBox gbClientesJuridico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInhabilitarCliJur;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvClienteJuridico;
        private System.Windows.Forms.CheckBox cbxEstadoCliJur;
        private System.Windows.Forms.Button btnBuscarCliJur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRucBuscar;
    }
}