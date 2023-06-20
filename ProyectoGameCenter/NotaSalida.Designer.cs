namespace ProyectoGameCenter
{
    partial class NotaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaSalida));
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumOrdenV = new System.Windows.Forms.TextBox();
            this.Clie = new System.Windows.Forms.TextBox();
            this.dtFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumNSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNotaSalida = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BarraTituloCN = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.gbNotaSalida = new System.Windows.Forms.GroupBox();
            this.btnBuscarOV = new System.Windows.Forms.Button();
            this.dgvProductosNS = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaSalida)).BeginInit();
            this.BarraTituloCN.SuspendLayout();
            this.gbNotaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosNS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(823, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(137, 27);
            this.txtCantidad.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(819, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cantidad:";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Enabled = false;
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProducto.Location = new System.Drawing.Point(823, 59);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.ReadOnly = true;
            this.txtIDProducto.Size = new System.Drawing.Size(137, 27);
            this.txtIDProducto.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(819, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "ID Producto:";
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
            this.btnCancelar.Location = new System.Drawing.Point(176, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 50);
            this.btnCancelar.TabIndex = 54;
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
            this.btnAgregar.Location = new System.Drawing.Point(25, 192);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 50);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNumOrdenV
            // 
            this.txtNumOrdenV.Enabled = false;
            this.txtNumOrdenV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOrdenV.Location = new System.Drawing.Point(211, 117);
            this.txtNumOrdenV.Name = "txtNumOrdenV";
            this.txtNumOrdenV.ReadOnly = true;
            this.txtNumOrdenV.Size = new System.Drawing.Size(160, 27);
            this.txtNumOrdenV.TabIndex = 52;
            // 
            // Clie
            // 
            this.Clie.Enabled = false;
            this.Clie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clie.Location = new System.Drawing.Point(94, 159);
            this.Clie.Name = "Clie";
            this.Clie.ReadOnly = true;
            this.Clie.Size = new System.Drawing.Size(337, 27);
            this.Clie.TabIndex = 51;
            // 
            // dtFechaEmision
            // 
            this.dtFechaEmision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaEmision.Location = new System.Drawing.Point(211, 80);
            this.dtFechaEmision.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaEmision.Name = "dtFechaEmision";
            this.dtFechaEmision.Size = new System.Drawing.Size(160, 27);
            this.dtFechaEmision.TabIndex = 50;
            this.dtFechaEmision.Value = new System.DateTime(2023, 6, 15, 22, 26, 38, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "N° Orden de Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(7, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Fecha de Emisión:";
            // 
            // txtNumNSalida
            // 
            this.txtNumNSalida.Enabled = false;
            this.txtNumNSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNSalida.Location = new System.Drawing.Point(211, 44);
            this.txtNumNSalida.Name = "txtNumNSalida";
            this.txtNumNSalida.ReadOnly = true;
            this.txtNumNSalida.Size = new System.Drawing.Size(160, 27);
            this.txtNumNSalida.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "N° Nota Salida:";
            // 
            // dgvNotaSalida
            // 
            this.dgvNotaSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaSalida.Location = new System.Drawing.Point(22, 356);
            this.dgvNotaSalida.Name = "dgvNotaSalida";
            this.dgvNotaSalida.RowHeadersWidth = 51;
            this.dgvNotaSalida.Size = new System.Drawing.Size(1003, 213);
            this.dgvNotaSalida.TabIndex = 51;
            this.dgvNotaSalida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
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
            this.btnNuevo.Location = new System.Drawing.Point(727, 588);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 52;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
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
            this.btnAnular.Location = new System.Drawing.Point(895, 588);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(130, 50);
            this.btnAnular.TabIndex = 53;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(22, 588);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 50);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // BarraTituloCN
            // 
            this.BarraTituloCN.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTituloCN.Controls.Add(this.label8);
            this.BarraTituloCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloCN.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloCN.Name = "BarraTituloCN";
            this.BarraTituloCN.Size = new System.Drawing.Size(1050, 60);
            this.BarraTituloCN.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1050, 43);
            this.label8.TabIndex = 13;
            this.label8.Text = "NOTA DE SALIDA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNotaSalida
            // 
            this.gbNotaSalida.Controls.Add(this.btnQuitar);
            this.gbNotaSalida.Controls.Add(this.dgvProductosNS);
            this.gbNotaSalida.Controls.Add(this.btnAñadir);
            this.gbNotaSalida.Controls.Add(this.btnCancelar);
            this.gbNotaSalida.Controls.Add(this.btnBuscarOV);
            this.gbNotaSalida.Controls.Add(this.btnAgregar);
            this.gbNotaSalida.Controls.Add(this.label7);
            this.gbNotaSalida.Controls.Add(this.dtFechaEmision);
            this.gbNotaSalida.Controls.Add(this.label2);
            this.gbNotaSalida.Controls.Add(this.txtNumNSalida);
            this.gbNotaSalida.Controls.Add(this.txtCantidad);
            this.gbNotaSalida.Controls.Add(this.label3);
            this.gbNotaSalida.Controls.Add(this.label5);
            this.gbNotaSalida.Controls.Add(this.txtNumOrdenV);
            this.gbNotaSalida.Controls.Add(this.txtIDProducto);
            this.gbNotaSalida.Controls.Add(this.label4);
            this.gbNotaSalida.Controls.Add(this.label6);
            this.gbNotaSalida.Controls.Add(this.Clie);
            this.gbNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNotaSalida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotaSalida.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbNotaSalida.Location = new System.Drawing.Point(22, 79);
            this.gbNotaSalida.Name = "gbNotaSalida";
            this.gbNotaSalida.Size = new System.Drawing.Size(1003, 260);
            this.gbNotaSalida.TabIndex = 59;
            this.gbNotaSalida.TabStop = false;
            this.gbNotaSalida.Text = "DATOS NOTA SALIDA";
            // 
            // btnBuscarOV
            // 
            this.btnBuscarOV.BackColor = System.Drawing.Color.White;
            this.btnBuscarOV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarOV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnBuscarOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOV.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBuscarOV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOV.Image")));
            this.btnBuscarOV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOV.Location = new System.Drawing.Point(377, 107);
            this.btnBuscarOV.Name = "btnBuscarOV";
            this.btnBuscarOV.Size = new System.Drawing.Size(54, 47);
            this.btnBuscarOV.TabIndex = 60;
            this.btnBuscarOV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOV.UseVisualStyleBackColor = false;
            // 
            // dgvProductosNS
            // 
            this.dgvProductosNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosNS.Location = new System.Drawing.Point(464, 36);
            this.dgvProductosNS.Name = "dgvProductosNS";
            this.dgvProductosNS.RowHeadersWidth = 51;
            this.dgvProductosNS.Size = new System.Drawing.Size(306, 174);
            this.dgvProductosNS.TabIndex = 60;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(893, 160);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 50);
            this.btnQuitar.TabIndex = 61;
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.White;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(837, 159);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(50, 50);
            this.btnAñadir.TabIndex = 60;
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // NotaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.gbNotaSalida);
            this.Controls.Add(this.BarraTituloCN);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvNotaSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotaSalida";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaSalida)).EndInit();
            this.BarraTituloCN.ResumeLayout(false);
            this.gbNotaSalida.ResumeLayout(false);
            this.gbNotaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumNSalida;
        private System.Windows.Forms.TextBox txtNumOrdenV;
        private System.Windows.Forms.TextBox Clie;
        private System.Windows.Forms.DateTimePicker dtFechaEmision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNotaSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel BarraTituloCN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbNotaSalida;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvProductosNS;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnBuscarOV;
    }
}