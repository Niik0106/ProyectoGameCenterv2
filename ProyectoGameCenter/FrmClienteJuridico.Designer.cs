﻿namespace ProyectoGameCenter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTituloCN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedorCN = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRucBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarCliJur = new System.Windows.Forms.Button();
            this.gbClienteJuridico = new System.Windows.Forms.GroupBox();
            this.btnBuscarUbigeo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoUbigeo = new System.Windows.Forms.TextBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInhabilitarCliJur = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
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
            this.BarraTituloCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTituloCN.Name = "BarraTituloCN";
            this.BarraTituloCN.Size = new System.Drawing.Size(1400, 74);
            this.BarraTituloCN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1400, 53);
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
            this.PanelContenedorCN.Controls.Add(this.gbClienteJuridico);
            this.PanelContenedorCN.Controls.Add(this.btnSalir);
            this.PanelContenedorCN.Controls.Add(this.btnInhabilitarCliJur);
            this.PanelContenedorCN.Controls.Add(this.btnEditar);
            this.PanelContenedorCN.Controls.Add(this.btnNuevo);
            this.PanelContenedorCN.Controls.Add(this.dgvClienteJuridico);
            this.PanelContenedorCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorCN.Location = new System.Drawing.Point(0, 74);
            this.PanelContenedorCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelContenedorCN.Name = "PanelContenedorCN";
            this.PanelContenedorCN.Size = new System.Drawing.Size(1400, 726);
            this.PanelContenedorCN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(225, 645);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Buscar RUC:";
            // 
            // txtRucBuscar
            // 
            this.txtRucBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRucBuscar.Location = new System.Drawing.Point(231, 677);
            this.txtRucBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRucBuscar.Name = "txtRucBuscar";
            this.txtRucBuscar.Size = new System.Drawing.Size(276, 32);
            this.txtRucBuscar.TabIndex = 61;
            this.txtRucBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRucBuscar_KeyPress);
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
            this.btnBuscarCliJur.Location = new System.Drawing.Point(549, 649);
            this.btnBuscarCliJur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliJur.Name = "btnBuscarCliJur";
            this.btnBuscarCliJur.Size = new System.Drawing.Size(173, 62);
            this.btnBuscarCliJur.TabIndex = 60;
            this.btnBuscarCliJur.Text = "Buscar";
            this.btnBuscarCliJur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliJur.UseVisualStyleBackColor = false;
            this.btnBuscarCliJur.Click += new System.EventHandler(this.btnBuscarCliJur_Click);
            // 
            // gbClienteJuridico
            // 
            this.gbClienteJuridico.Controls.Add(this.btnBuscarUbigeo);
            this.gbClienteJuridico.Controls.Add(this.label11);
            this.gbClienteJuridico.Controls.Add(this.txtCodigoUbigeo);
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
            this.gbClienteJuridico.Controls.Add(this.btnCancelar);
            this.gbClienteJuridico.Controls.Add(this.label4);
            this.gbClienteJuridico.Controls.Add(this.btnModificar);
            this.gbClienteJuridico.Controls.Add(this.txtTelefono);
            this.gbClienteJuridico.Controls.Add(this.btnAgregar);
            this.gbClienteJuridico.Controls.Add(this.txtDireccion);
            this.gbClienteJuridico.Controls.Add(this.label6);
            this.gbClienteJuridico.Controls.Add(this.label7);
            this.gbClienteJuridico.Controls.Add(this.label8);
            this.gbClienteJuridico.Controls.Add(this.label9);
            this.gbClienteJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbClienteJuridico.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteJuridico.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbClienteJuridico.Location = new System.Drawing.Point(25, 18);
            this.gbClienteJuridico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbClienteJuridico.Name = "gbClienteJuridico";
            this.gbClienteJuridico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbClienteJuridico.Size = new System.Drawing.Size(1337, 326);
            this.gbClienteJuridico.TabIndex = 31;
            this.gbClienteJuridico.TabStop = false;
            this.gbClienteJuridico.Text = "DATOS DEL CLIENTE";
            // 
            // btnBuscarUbigeo
            // 
            this.btnBuscarUbigeo.BackColor = System.Drawing.Color.White;
            this.btnBuscarUbigeo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUbigeo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUbigeo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUbigeo.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarUbigeo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUbigeo.Image")));
            this.btnBuscarUbigeo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUbigeo.Location = new System.Drawing.Point(1013, 66);
            this.btnBuscarUbigeo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarUbigeo.Name = "btnBuscarUbigeo";
            this.btnBuscarUbigeo.Size = new System.Drawing.Size(95, 36);
            this.btnBuscarUbigeo.TabIndex = 64;
            this.btnBuscarUbigeo.Text = "buscar";
            this.btnBuscarUbigeo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUbigeo.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkViolet;
            this.label11.Location = new System.Drawing.Point(508, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 28);
            this.label11.TabIndex = 63;
            this.label11.Text = "Codigo Ubigeo:";
            // 
            // txtCodigoUbigeo
            // 
            this.txtCodigoUbigeo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUbigeo.Location = new System.Drawing.Point(727, 66);
            this.txtCodigoUbigeo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoUbigeo.Name = "txtCodigoUbigeo";
            this.txtCodigoUbigeo.Size = new System.Drawing.Size(276, 32);
            this.txtCodigoUbigeo.TabIndex = 62;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(727, 107);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(276, 32);
            this.txtDepartamento.TabIndex = 61;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(727, 148);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(276, 32);
            this.txtProvincia.TabIndex = 60;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Enabled = false;
            this.txtDistrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrito.Location = new System.Drawing.Point(727, 185);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.ReadOnly = true;
            this.txtDistrito.Size = new System.Drawing.Size(276, 32);
            this.txtDistrito.TabIndex = 59;
            // 
            // cbxEstadoCliJur
            // 
            this.cbxEstadoCliJur.AutoSize = true;
            this.cbxEstadoCliJur.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoCliJur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoCliJur.Location = new System.Drawing.Point(597, 256);
            this.cbxEstadoCliJur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstadoCliJur.Name = "cbxEstadoCliJur";
            this.cbxEstadoCliJur.Size = new System.Drawing.Size(111, 32);
            this.cbxEstadoCliJur.TabIndex = 58;
            this.cbxEstadoCliJur.Text = "Estado";
            this.cbxEstadoCliJur.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(59, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 28);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(205, 69);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(276, 32);
            this.txtIDCliente.TabIndex = 26;
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(205, 117);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(276, 32);
            this.txtRUC.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(125, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "RUC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(20, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(205, 165);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(276, 32);
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
            this.btnCancelar.Location = new System.Drawing.Point(1128, 223);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 62);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(75, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
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
            this.btnModificar.Location = new System.Drawing.Point(1128, 133);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(173, 62);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(205, 213);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(276, 32);
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
            this.btnAgregar.Location = new System.Drawing.Point(1128, 41);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(173, 62);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(727, 224);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(327, 27);
            this.txtDireccion.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(519, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(584, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Provincia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(617, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distrito:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(581, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 28);
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
            this.btnSalir.Location = new System.Drawing.Point(28, 650);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 62);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnInhabilitarCliJur.Location = new System.Drawing.Point(1173, 649);
            this.btnInhabilitarCliJur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInhabilitarCliJur.Name = "btnInhabilitarCliJur";
            this.btnInhabilitarCliJur.Size = new System.Drawing.Size(192, 62);
            this.btnInhabilitarCliJur.TabIndex = 29;
            this.btnInhabilitarCliJur.Text = "Inhabilitar";
            this.btnInhabilitarCliJur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInhabilitarCliJur.UseVisualStyleBackColor = false;
            this.btnInhabilitarCliJur.Click += new System.EventHandler(this.btnInhabilitarCliJur_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(960, 650);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 62);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(752, 650);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(173, 62);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvClienteJuridico
            // 
            this.dgvClienteJuridico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteJuridico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClienteJuridico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteJuridico.Location = new System.Drawing.Point(28, 352);
            this.dgvClienteJuridico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClienteJuridico.Name = "dgvClienteJuridico";
            this.dgvClienteJuridico.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClienteJuridico.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClienteJuridico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteJuridico.Size = new System.Drawing.Size(1337, 282);
            this.dgvClienteJuridico.TabIndex = 26;
            this.dgvClienteJuridico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteJuridico_CellClick);
            // 
            // FrmClienteJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.PanelContenedorCN);
            this.Controls.Add(this.BarraTituloCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInhabilitarCliJur;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox cbxEstadoCliJur;
        private System.Windows.Forms.Button btnBuscarCliJur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRucBuscar;
        private System.Windows.Forms.Button btnBuscarUbigeo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoUbigeo;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.DataGridView dgvClienteJuridico;
    }
}