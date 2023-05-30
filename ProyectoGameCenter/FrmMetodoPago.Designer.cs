namespace ProyectoGameCenter
{
    partial class FrmMetodoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetodoPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMetodoPago = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitularCuenta = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionMetodoPago = new System.Windows.Forms.TextBox();
            this.imgMetodoPago = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMetodoPago = new System.Windows.Forms.TextBox();
            this.BarraTitulo.SuspendLayout();
            this.gbMetodoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMetodoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 60);
            this.BarraTitulo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1050, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "METODO PAGO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMetodoPago
            // 
            this.gbMetodoPago.Controls.Add(this.label1);
            this.gbMetodoPago.Controls.Add(this.txtIDMetodoPago);
            this.gbMetodoPago.Controls.Add(this.btnCancelar);
            this.gbMetodoPago.Controls.Add(this.label4);
            this.gbMetodoPago.Controls.Add(this.txtTitularCuenta);
            this.gbMetodoPago.Controls.Add(this.txtNumeroCuenta);
            this.gbMetodoPago.Controls.Add(this.label3);
            this.gbMetodoPago.Controls.Add(this.txtDescripcionMetodoPago);
            this.gbMetodoPago.Controls.Add(this.imgMetodoPago);
            this.gbMetodoPago.Controls.Add(this.btnModificar);
            this.gbMetodoPago.Controls.Add(this.btnAgregar);
            this.gbMetodoPago.Controls.Add(this.cboTipoPago);
            this.gbMetodoPago.Controls.Add(this.label9);
            this.gbMetodoPago.Controls.Add(this.label10);
            this.gbMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMetodoPago.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMetodoPago.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbMetodoPago.Location = new System.Drawing.Point(22, 81);
            this.gbMetodoPago.Name = "gbMetodoPago";
            this.gbMetodoPago.Size = new System.Drawing.Size(1003, 251);
            this.gbMetodoPago.TabIndex = 39;
            this.gbMetodoPago.TabStop = false;
            this.gbMetodoPago.Text = "METODO DE PAGO";
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
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(459, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tipo de Pago:";
            // 
            // txtTitularCuenta
            // 
            this.txtTitularCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitularCuenta.Location = new System.Drawing.Point(605, 99);
            this.txtTitularCuenta.Name = "txtTitularCuenta";
            this.txtTitularCuenta.ReadOnly = true;
            this.txtTitularCuenta.Size = new System.Drawing.Size(208, 27);
            this.txtTitularCuenta.TabIndex = 27;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(605, 155);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.ReadOnly = true;
            this.txtNumeroCuenta.Size = new System.Drawing.Size(208, 27);
            this.txtNumeroCuenta.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(205, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // txtDescripcionMetodoPago
            // 
            this.txtDescripcionMetodoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMetodoPago.Location = new System.Drawing.Point(209, 157);
            this.txtDescripcionMetodoPago.Name = "txtDescripcionMetodoPago";
            this.txtDescripcionMetodoPago.ReadOnly = true;
            this.txtDescripcionMetodoPago.Size = new System.Drawing.Size(183, 27);
            this.txtDescripcionMetodoPago.TabIndex = 17;
            // 
            // imgMetodoPago
            // 
            this.imgMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.imgMetodoPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMetodoPago.BackgroundImage")));
            this.imgMetodoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgMetodoPago.Location = new System.Drawing.Point(29, 66);
            this.imgMetodoPago.Name = "imgMetodoPago";
            this.imgMetodoPago.Size = new System.Drawing.Size(170, 144);
            this.imgMetodoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMetodoPago.TabIndex = 16;
            this.imgMetodoPago.TabStop = false;
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
            this.btnModificar.Location = new System.Drawing.Point(846, 109);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 50);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
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
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(605, 46);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(208, 29);
            this.cboTipoPago.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(454, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Titular Cuenta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(435, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Numero Cuenta:";
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMetodoPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMetodoPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetodoPago.ColumnHeadersHeight = 30;
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMetodoPago.ColumnHeadersVisible = false;
            this.dgvMetodoPago.Location = new System.Drawing.Point(22, 349);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMetodoPago.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMetodoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetodoPago.Size = new System.Drawing.Size(1003, 229);
            this.dgvMetodoPago.TabIndex = 40;
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
            this.btnSalir.Location = new System.Drawing.Point(22, 589);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 50);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(895, 588);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 50);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(742, 589);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 50);
            this.btnEditar.TabIndex = 42;
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
            this.btnNuevo.Location = new System.Drawing.Point(587, 589);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(205, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Metodo Pago:";
            // 
            // txtIDMetodoPago
            // 
            this.txtIDMetodoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMetodoPago.Location = new System.Drawing.Point(209, 99);
            this.txtIDMetodoPago.Name = "txtIDMetodoPago";
            this.txtIDMetodoPago.ReadOnly = true;
            this.txtIDMetodoPago.Size = new System.Drawing.Size(183, 27);
            this.txtIDMetodoPago.TabIndex = 31;
            // 
            // FrmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMetodoPago);
            this.Controls.Add(this.gbMetodoPago);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMetodoPago";
            this.Text = "FrmMantenedorPago";
            this.BarraTitulo.ResumeLayout(false);
            this.gbMetodoPago.ResumeLayout(false);
            this.gbMetodoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMetodoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMetodoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitularCuenta;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionMetodoPago;
        private System.Windows.Forms.PictureBox imgMetodoPago;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMetodoPago;
    }
}