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
            this.cbxEstadoMetdPago = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMetodoPago = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionMetodoPago = new System.Windows.Forms.TextBox();
            this.imgMetodoPago = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitarMetdPag = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
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
            this.gbMetodoPago.Controls.Add(this.cbxEstadoMetdPago);
            this.gbMetodoPago.Controls.Add(this.label1);
            this.gbMetodoPago.Controls.Add(this.txtIDMetodoPago);
            this.gbMetodoPago.Controls.Add(this.btnCancelar);
            this.gbMetodoPago.Controls.Add(this.label3);
            this.gbMetodoPago.Controls.Add(this.txtDescripcionMetodoPago);
            this.gbMetodoPago.Controls.Add(this.imgMetodoPago);
            this.gbMetodoPago.Controls.Add(this.btnModificar);
            this.gbMetodoPago.Controls.Add(this.btnAgregar);
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
            // cbxEstadoMetdPago
            // 
            this.cbxEstadoMetdPago.AutoSize = true;
            this.cbxEstadoMetdPago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstadoMetdPago.Font = new System.Drawing.Font("Century Gothic", 14.5F, System.Drawing.FontStyle.Bold);
            this.cbxEstadoMetdPago.Location = new System.Drawing.Point(302, 181);
            this.cbxEstadoMetdPago.Name = "cbxEstadoMetdPago";
            this.cbxEstadoMetdPago.Size = new System.Drawing.Size(93, 27);
            this.cbxEstadoMetdPago.TabIndex = 58;
            this.cbxEstadoMetdPago.Text = "Estado";
            this.cbxEstadoMetdPago.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(215, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Metodo Pago:";
            // 
            // txtIDMetodoPago
            // 
            this.txtIDMetodoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMetodoPago.Location = new System.Drawing.Point(385, 72);
            this.txtIDMetodoPago.Name = "txtIDMetodoPago";
            this.txtIDMetodoPago.ReadOnly = true;
            this.txtIDMetodoPago.Size = new System.Drawing.Size(183, 27);
            this.txtIDMetodoPago.TabIndex = 31;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(255, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // txtDescripcionMetodoPago
            // 
            this.txtDescripcionMetodoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMetodoPago.Location = new System.Drawing.Point(385, 130);
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
            // btnDeshabilitarMetdPag
            // 
            this.btnDeshabilitarMetdPag.BackColor = System.Drawing.Color.White;
            this.btnDeshabilitarMetdPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitarMetdPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnDeshabilitarMetdPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarMetdPag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarMetdPag.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnDeshabilitarMetdPag.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitarMetdPag.Image")));
            this.btnDeshabilitarMetdPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitarMetdPag.Location = new System.Drawing.Point(877, 588);
            this.btnDeshabilitarMetdPag.Name = "btnDeshabilitarMetdPag";
            this.btnDeshabilitarMetdPag.Size = new System.Drawing.Size(148, 50);
            this.btnDeshabilitarMetdPag.TabIndex = 43;
            this.btnDeshabilitarMetdPag.Text = "Deshabilitar";
            this.btnDeshabilitarMetdPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitarMetdPag.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(715, 589);
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
            this.btnNuevo.Location = new System.Drawing.Point(554, 588);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // FrmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitarMetdPag);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionMetodoPago;
        private System.Windows.Forms.PictureBox imgMetodoPago;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitarMetdPag;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMetodoPago;
        private System.Windows.Forms.CheckBox cbxEstadoMetdPago;
    }
}