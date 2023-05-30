namespace ProyectoGameCenter
{
    partial class FrmTipoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoPago));
            this.btnIngresar = new ProyectoGameCenter.Botones.Boton();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.imgTipoPago = new System.Windows.Forms.PictureBox();
            this.dgvTipoPago = new System.Windows.Forms.DataGridView();
            this.gbTipoPago = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMarca = new System.Windows.Forms.TextBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPago)).BeginInit();
            this.gbTipoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(40)))), ((int)(((byte)(163)))));
            this.btnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(40)))), ((int)(((byte)(163)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresar.BorderRadius = 40;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(142, 98);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(127, 41);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkViolet;
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 60);
            this.BarraTitulo.TabIndex = 4;
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
            this.label2.Text = "TIPO DE PAGO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEliminar.Location = new System.Drawing.Point(839, 483);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 50);
            this.btnEliminar.TabIndex = 51;
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
            this.btnEditar.Location = new System.Drawing.Point(839, 394);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 50);
            this.btnEditar.TabIndex = 50;
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
            this.btnNuevo.Location = new System.Drawing.Point(839, 303);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 49;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
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
            this.btnSalir.Location = new System.Drawing.Point(839, 569);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 50);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPago.Location = new System.Drawing.Point(568, 50);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.ReadOnly = true;
            this.txtTipoPago.Size = new System.Drawing.Size(208, 27);
            this.txtTipoPago.TabIndex = 46;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTipoPago.Location = new System.Drawing.Point(425, 51);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(137, 23);
            this.lblTipoPago.TabIndex = 45;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // imgTipoPago
            // 
            this.imgTipoPago.BackColor = System.Drawing.Color.Transparent;
            this.imgTipoPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgTipoPago.BackgroundImage")));
            this.imgTipoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgTipoPago.Location = new System.Drawing.Point(88, 303);
            this.imgTipoPago.Name = "imgTipoPago";
            this.imgTipoPago.Size = new System.Drawing.Size(227, 316);
            this.imgTipoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTipoPago.TabIndex = 44;
            this.imgTipoPago.TabStop = false;
            // 
            // dgvTipoPago
            // 
            this.dgvTipoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPago.Location = new System.Drawing.Point(361, 303);
            this.dgvTipoPago.Name = "dgvTipoPago";
            this.dgvTipoPago.Size = new System.Drawing.Size(372, 316);
            this.dgvTipoPago.TabIndex = 43;
            // 
            // gbTipoPago
            // 
            this.gbTipoPago.Controls.Add(this.label1);
            this.gbTipoPago.Controls.Add(this.txtIDMarca);
            this.gbTipoPago.Controls.Add(this.btnCancelar);
            this.gbTipoPago.Controls.Add(this.btnModificar);
            this.gbTipoPago.Controls.Add(this.btnAgregar);
            this.gbTipoPago.Controls.Add(this.txtTipoPago);
            this.gbTipoPago.Controls.Add(this.lblTipoPago);
            this.gbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTipoPago.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPago.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbTipoPago.Location = new System.Drawing.Point(21, 78);
            this.gbTipoPago.Name = "gbTipoPago";
            this.gbTipoPago.Size = new System.Drawing.Size(1004, 191);
            this.gbTipoPago.TabIndex = 54;
            this.gbTipoPago.TabStop = false;
            this.gbTipoPago.Text = "TIPO DE PAGO";
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
            this.btnCancelar.Location = new System.Drawing.Point(662, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 50);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnModificar.Location = new System.Drawing.Point(462, 114);
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
            this.btnAgregar.Location = new System.Drawing.Point(275, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(174, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID Tipo Pago:";
            // 
            // txtIDMarca
            // 
            this.txtIDMarca.Enabled = false;
            this.txtIDMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMarca.Location = new System.Drawing.Point(310, 51);
            this.txtIDMarca.Name = "txtIDMarca";
            this.txtIDMarca.ReadOnly = true;
            this.txtIDMarca.Size = new System.Drawing.Size(95, 27);
            this.txtIDMarca.TabIndex = 47;
            // 
            // FrmTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.gbTipoPago);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.imgTipoPago);
            this.Controls.Add(this.dgvTipoPago);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipoPago";
            this.Text = "FrmMetodoPago";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTipoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPago)).EndInit();
            this.gbTipoPago.ResumeLayout(false);
            this.gbTipoPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Botones.Boton btnIngresar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.PictureBox imgTipoPago;
        private System.Windows.Forms.DataGridView dgvTipoPago;
        private System.Windows.Forms.GroupBox gbTipoPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMarca;
    }
}