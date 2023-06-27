﻿namespace ProyectoGameCenter
{
    partial class FrmCronogramaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCronogramaPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCronogramaPago = new System.Windows.Forms.GroupBox();
            this.txtNumeroCuotas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEstadoPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtimePlazoPago = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtimeFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCronogramaPago = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPagado = new System.Windows.Forms.Button();
            this.dgvCronogramaPago = new System.Windows.Forms.DataGridView();
            this.BarraTitulo.SuspendLayout();
            this.gbCronogramaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronogramaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1386, 74);
            this.BarraTitulo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1386, 53);
            this.label2.TabIndex = 13;
            this.label2.Text = "CRONOGRAMA DE PAGO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCronogramaPago
            // 
            this.gbCronogramaPago.Controls.Add(this.txtNumeroCuotas);
            this.gbCronogramaPago.Controls.Add(this.label11);
            this.gbCronogramaPago.Controls.Add(this.txtObservaciones);
            this.gbCronogramaPago.Controls.Add(this.label7);
            this.gbCronogramaPago.Controls.Add(this.cboEstadoPago);
            this.gbCronogramaPago.Controls.Add(this.label6);
            this.gbCronogramaPago.Controls.Add(this.dtimePlazoPago);
            this.gbCronogramaPago.Controls.Add(this.label8);
            this.gbCronogramaPago.Controls.Add(this.txtIDOrdenVenta);
            this.gbCronogramaPago.Controls.Add(this.txtTotal);
            this.gbCronogramaPago.Controls.Add(this.cboMetodoPago);
            this.gbCronogramaPago.Controls.Add(this.label5);
            this.gbCronogramaPago.Controls.Add(this.dtimeFechaVenta);
            this.gbCronogramaPago.Controls.Add(this.label1);
            this.gbCronogramaPago.Controls.Add(this.txtIDCronogramaPago);
            this.gbCronogramaPago.Controls.Add(this.btnCancelar);
            this.gbCronogramaPago.Controls.Add(this.label4);
            this.gbCronogramaPago.Controls.Add(this.txtIDCliente);
            this.gbCronogramaPago.Controls.Add(this.label3);
            this.gbCronogramaPago.Controls.Add(this.btnAgregar);
            this.gbCronogramaPago.Controls.Add(this.label9);
            this.gbCronogramaPago.Controls.Add(this.label10);
            this.gbCronogramaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCronogramaPago.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCronogramaPago.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbCronogramaPago.Location = new System.Drawing.Point(29, 100);
            this.gbCronogramaPago.Margin = new System.Windows.Forms.Padding(4);
            this.gbCronogramaPago.Name = "gbCronogramaPago";
            this.gbCronogramaPago.Padding = new System.Windows.Forms.Padding(4);
            this.gbCronogramaPago.Size = new System.Drawing.Size(1337, 298);
            this.gbCronogramaPago.TabIndex = 41;
            this.gbCronogramaPago.TabStop = false;
            this.gbCronogramaPago.Text = "CRONOGRAMA PAGO";
            // 
            // txtNumeroCuotas
            // 
            this.txtNumeroCuotas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuotas.Location = new System.Drawing.Point(791, 95);
            this.txtNumeroCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroCuotas.Name = "txtNumeroCuotas";
            this.txtNumeroCuotas.Size = new System.Drawing.Size(243, 27);
            this.txtNumeroCuotas.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkViolet;
            this.label11.Location = new System.Drawing.Point(640, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 23);
            this.label11.TabIndex = 46;
            this.label11.Text = "N° Cuotas:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(791, 239);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(372, 27);
            this.txtObservaciones.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(577, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Observaciones:";
            // 
            // cboEstadoPago
            // 
            this.cboEstadoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoPago.FormattingEnabled = true;
            this.cboEstadoPago.Location = new System.Drawing.Point(791, 185);
            this.cboEstadoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstadoPago.Name = "cboEstadoPago";
            this.cboEstadoPago.Size = new System.Drawing.Size(280, 29);
            this.cboEstadoPago.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(608, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Estado Pago:";
            // 
            // dtimePlazoPago
            // 
            this.dtimePlazoPago.Enabled = false;
            this.dtimePlazoPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimePlazoPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimePlazoPago.Location = new System.Drawing.Point(224, 239);
            this.dtimePlazoPago.Margin = new System.Windows.Forms.Padding(4);
            this.dtimePlazoPago.Name = "dtimePlazoPago";
            this.dtimePlazoPago.Size = new System.Drawing.Size(243, 31);
            this.dtimePlazoPago.TabIndex = 41;
            this.dtimePlazoPago.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(57, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "Plazo Pago:";
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(224, 144);
            this.txtIDOrdenVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.ReadOnly = true;
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(243, 27);
            this.txtIDOrdenVenta.TabIndex = 39;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(791, 55);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(243, 27);
            this.txtTotal.TabIndex = 37;
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(791, 137);
            this.cboMetodoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(307, 29);
            this.cboMetodoPago.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(704, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Total:";
            // 
            // dtimeFechaVenta
            // 
            this.dtimeFechaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeFechaVenta.Location = new System.Drawing.Point(224, 98);
            this.dtimeFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dtimeFechaVenta.Name = "dtimeFechaVenta";
            this.dtimeFechaVenta.Size = new System.Drawing.Size(243, 31);
            this.dtimeFechaVenta.TabIndex = 32;
            this.dtimeFechaVenta.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID C. Pago:";
            // 
            // txtIDCronogramaPago
            // 
            this.txtIDCronogramaPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCronogramaPago.Location = new System.Drawing.Point(224, 55);
            this.txtIDCronogramaPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCronogramaPago.Name = "txtIDCronogramaPago";
            this.txtIDCronogramaPago.ReadOnly = true;
            this.txtIDCronogramaPago.Size = new System.Drawing.Size(243, 27);
            this.txtIDCronogramaPago.TabIndex = 31;
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
            this.btnCancelar.Location = new System.Drawing.Point(1156, 153);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 62);
            this.btnCancelar.TabIndex = 29;
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
            this.label4.Location = new System.Drawing.Point(595, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Metodo Pago:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(224, 191);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(243, 27);
            this.txtIDCliente.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Venta:";
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
            this.btnAgregar.Location = new System.Drawing.Point(1156, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(173, 62);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(77, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(8, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "N° Orden Venta:";
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
            this.btnSalir.Location = new System.Drawing.Point(29, 706);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 62);
            this.btnSalir.TabIndex = 53;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPagado
            // 
            this.btnPagado.BackColor = System.Drawing.Color.White;
            this.btnPagado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnPagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagado.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPagado.Image = ((System.Drawing.Image)(resources.GetObject("btnPagado.Image")));
            this.btnPagado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagado.Location = new System.Drawing.Point(1193, 706);
            this.btnPagado.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagado.Name = "btnPagado";
            this.btnPagado.Size = new System.Drawing.Size(173, 62);
            this.btnPagado.TabIndex = 52;
            this.btnPagado.Text = "Pagado";
            this.btnPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagado.UseVisualStyleBackColor = false;
            this.btnPagado.Click += new System.EventHandler(this.btnPagado_Click);
            // 
            // dgvCronogramaPago
            // 
            this.dgvCronogramaPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCronogramaPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCronogramaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCronogramaPago.Location = new System.Drawing.Point(29, 407);
            this.dgvCronogramaPago.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCronogramaPago.Name = "dgvCronogramaPago";
            this.dgvCronogramaPago.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCronogramaPago.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCronogramaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCronogramaPago.Size = new System.Drawing.Size(1337, 282);
            this.dgvCronogramaPago.TabIndex = 54;
            this.dgvCronogramaPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCronogramaPago_CellClick);
            // 
            // FrmCronogramaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.dgvCronogramaPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagado);
            this.Controls.Add(this.gbCronogramaPago);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCronogramaPago";
            this.Text = "frmCronogramaPago";
            this.BarraTitulo.ResumeLayout(false);
            this.gbCronogramaPago.ResumeLayout(false);
            this.gbCronogramaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronogramaPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCronogramaPago;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtimeFechaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCronogramaPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtimePlazoPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDOrdenVenta;
        private System.Windows.Forms.TextBox txtNumeroCuotas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCronogramaPago;
    }
}