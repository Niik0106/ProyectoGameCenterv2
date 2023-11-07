namespace ProyectoGameCenter
{
    partial class FrmNotaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaSalida));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbNotaSalida = new System.Windows.Forms.GroupBox();
            this.txtN_Orden_Venta = new ProyectoGameCenter.NiikTextBox();
            this.btnAgregarNotaSalida = new ProyectoGameCenter.Botones.Boton();
            this.txtNNotaSalida = new ProyectoGameCenter.NiikTextBox();
            this.txtIDNotaSalida = new ProyectoGameCenter.NiikTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvNotaSalida = new System.Windows.Forms.DataGridView();
            this.gbDetalleNotaSalida = new System.Windows.Forms.GroupBox();
            this.dgvDetalleNotaSalida = new System.Windows.Forms.DataGridView();
            this.btnBuscarProducto = new ProyectoGameCenter.Botones.Boton();
            this.txtDesProducto = new ProyectoGameCenter.NiikTextBox();
            this.txtCantidad = new ProyectoGameCenter.NiikTextBox();
            this.txtIDProducto = new ProyectoGameCenter.NiikTextBox();
            this.btnFinalizar = new ProyectoGameCenter.Botones.Boton();
            this.btnAgregarProducto = new ProyectoGameCenter.Botones.Boton();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOrdenVenta = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarOV = new ProyectoGameCenter.Botones.Boton();
            this.btnAnular = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.gbNotaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaSalida)).BeginInit();
            this.gbDetalleNotaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNotaSalida
            // 
            this.gbNotaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gbNotaSalida.Controls.Add(this.txtN_Orden_Venta);
            this.gbNotaSalida.Controls.Add(this.btnAgregarNotaSalida);
            this.gbNotaSalida.Controls.Add(this.txtNNotaSalida);
            this.gbNotaSalida.Controls.Add(this.txtIDNotaSalida);
            this.gbNotaSalida.Controls.Add(this.label16);
            this.gbNotaSalida.Controls.Add(this.label11);
            this.gbNotaSalida.Controls.Add(this.dateTimePicker1);
            this.gbNotaSalida.Controls.Add(this.label2);
            this.gbNotaSalida.Controls.Add(this.label3);
            this.gbNotaSalida.Controls.Add(this.cboEstado);
            this.gbNotaSalida.Controls.Add(this.label10);
            this.gbNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNotaSalida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotaSalida.ForeColor = System.Drawing.Color.White;
            this.gbNotaSalida.Location = new System.Drawing.Point(22, 10);
            this.gbNotaSalida.Name = "gbNotaSalida";
            this.gbNotaSalida.Size = new System.Drawing.Size(1421, 138);
            this.gbNotaSalida.TabIndex = 41;
            this.gbNotaSalida.TabStop = false;
            this.gbNotaSalida.Text = "NOTA SALIDA";
            this.gbNotaSalida.Enter += new System.EventHandler(this.gbNotaSalida_Enter);
            // 
            // txtN_Orden_Venta
            // 
            this.txtN_Orden_Venta.BackColor = System.Drawing.SystemColors.Window;
            this.txtN_Orden_Venta.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtN_Orden_Venta.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtN_Orden_Venta.BorderRadius = 15;
            this.txtN_Orden_Venta.BorderSize = 2;
            this.txtN_Orden_Venta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtN_Orden_Venta.ForeColor = System.Drawing.Color.Black;
            this.txtN_Orden_Venta.Location = new System.Drawing.Point(656, 63);
            this.txtN_Orden_Venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN_Orden_Venta.Multiline = false;
            this.txtN_Orden_Venta.Name = "txtN_Orden_Venta";
            this.txtN_Orden_Venta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtN_Orden_Venta.PasswordChar = false;
            this.txtN_Orden_Venta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtN_Orden_Venta.PlaceholderText = "";
            this.txtN_Orden_Venta.Size = new System.Drawing.Size(112, 36);
            this.txtN_Orden_Venta.TabIndex = 96;
            this.txtN_Orden_Venta.UnderlinedStyle = false;
            // 
            // btnAgregarNotaSalida
            // 
            this.btnAgregarNotaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarNotaSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarNotaSalida.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarNotaSalida.BorderRadius = 40;
            this.btnAgregarNotaSalida.BorderSize = 0;
            this.btnAgregarNotaSalida.FlatAppearance.BorderSize = 0;
            this.btnAgregarNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNotaSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarNotaSalida.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNotaSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarNotaSalida.Image")));
            this.btnAgregarNotaSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNotaSalida.Location = new System.Drawing.Point(1175, 44);
            this.btnAgregarNotaSalida.Name = "btnAgregarNotaSalida";
            this.btnAgregarNotaSalida.Size = new System.Drawing.Size(148, 50);
            this.btnAgregarNotaSalida.TabIndex = 95;
            this.btnAgregarNotaSalida.Text = "Agregar";
            this.btnAgregarNotaSalida.TextColor = System.Drawing.Color.White;
            this.btnAgregarNotaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarNotaSalida.UseVisualStyleBackColor = false;
            this.btnAgregarNotaSalida.Click += new System.EventHandler(this.btnAgregarNotaSalida_Click);
            // 
            // txtNNotaSalida
            // 
            this.txtNNotaSalida.BackColor = System.Drawing.SystemColors.Window;
            this.txtNNotaSalida.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNNotaSalida.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtNNotaSalida.BorderRadius = 15;
            this.txtNNotaSalida.BorderSize = 2;
            this.txtNNotaSalida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNNotaSalida.ForeColor = System.Drawing.Color.Black;
            this.txtNNotaSalida.Location = new System.Drawing.Point(248, 63);
            this.txtNNotaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNNotaSalida.Multiline = false;
            this.txtNNotaSalida.Name = "txtNNotaSalida";
            this.txtNNotaSalida.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNNotaSalida.PasswordChar = false;
            this.txtNNotaSalida.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNNotaSalida.PlaceholderText = "";
            this.txtNNotaSalida.Size = new System.Drawing.Size(112, 36);
            this.txtNNotaSalida.TabIndex = 91;
            this.txtNNotaSalida.UnderlinedStyle = false;
            // 
            // txtIDNotaSalida
            // 
            this.txtIDNotaSalida.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDNotaSalida.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDNotaSalida.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDNotaSalida.BorderRadius = 15;
            this.txtIDNotaSalida.BorderSize = 2;
            this.txtIDNotaSalida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDNotaSalida.ForeColor = System.Drawing.Color.Black;
            this.txtIDNotaSalida.Location = new System.Drawing.Point(24, 59);
            this.txtIDNotaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDNotaSalida.Multiline = false;
            this.txtIDNotaSalida.Name = "txtIDNotaSalida";
            this.txtIDNotaSalida.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDNotaSalida.PasswordChar = false;
            this.txtIDNotaSalida.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDNotaSalida.PlaceholderText = "";
            this.txtIDNotaSalida.Size = new System.Drawing.Size(112, 36);
            this.txtIDNotaSalida.TabIndex = 90;
            this.txtIDNotaSalida.UnderlinedStyle = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(656, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 23);
            this.label16.TabIndex = 76;
            this.label16.Text = "N°Orden Venta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID Nota Salida:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 31);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "N° Nota Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Emision:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Enabled = false;
            this.cboEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(874, 66);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(156, 29);
            this.cboEstado.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(870, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Estado:";
            // 
            // dgvNotaSalida
            // 
            this.dgvNotaSalida.AllowUserToAddRows = false;
            this.dgvNotaSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotaSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotaSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvNotaSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotaSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotaSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotaSalida.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotaSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotaSalida.EnableHeadersVisualStyles = false;
            this.dgvNotaSalida.Location = new System.Drawing.Point(56, 168);
            this.dgvNotaSalida.Name = "dgvNotaSalida";
            this.dgvNotaSalida.ReadOnly = true;
            this.dgvNotaSalida.RowHeadersVisible = false;
            this.dgvNotaSalida.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotaSalida.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotaSalida.RowTemplate.Height = 50;
            this.dgvNotaSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaSalida.Size = new System.Drawing.Size(1354, 199);
            this.dgvNotaSalida.TabIndex = 87;
            // 
            // gbDetalleNotaSalida
            // 
            this.gbDetalleNotaSalida.Controls.Add(this.dgvDetalleNotaSalida);
            this.gbDetalleNotaSalida.Controls.Add(this.btnBuscarProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.txtDesProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.txtCantidad);
            this.gbDetalleNotaSalida.Controls.Add(this.txtIDProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.btnFinalizar);
            this.gbDetalleNotaSalida.Controls.Add(this.btnAgregarProducto);
            this.gbDetalleNotaSalida.Controls.Add(this.label12);
            this.gbDetalleNotaSalida.Controls.Add(this.label14);
            this.gbDetalleNotaSalida.Controls.Add(this.label5);
            this.gbDetalleNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleNotaSalida.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleNotaSalida.ForeColor = System.Drawing.Color.White;
            this.gbDetalleNotaSalida.Location = new System.Drawing.Point(25, 389);
            this.gbDetalleNotaSalida.Name = "gbDetalleNotaSalida";
            this.gbDetalleNotaSalida.Size = new System.Drawing.Size(1418, 336);
            this.gbDetalleNotaSalida.TabIndex = 88;
            this.gbDetalleNotaSalida.TabStop = false;
            this.gbDetalleNotaSalida.Text = "DETALLE NOTA SALIDA";
            // 
            // dgvDetalleNotaSalida
            // 
            this.dgvDetalleNotaSalida.AllowUserToAddRows = false;
            this.dgvDetalleNotaSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleNotaSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleNotaSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvDetalleNotaSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleNotaSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleNotaSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleNotaSalida.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleNotaSalida.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleNotaSalida.EnableHeadersVisualStyles = false;
            this.dgvDetalleNotaSalida.Location = new System.Drawing.Point(32, 121);
            this.dgvDetalleNotaSalida.Name = "dgvDetalleNotaSalida";
            this.dgvDetalleNotaSalida.ReadOnly = true;
            this.dgvDetalleNotaSalida.RowHeadersVisible = false;
            this.dgvDetalleNotaSalida.RowHeadersWidth = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleNotaSalida.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleNotaSalida.RowTemplate.Height = 50;
            this.dgvDetalleNotaSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleNotaSalida.Size = new System.Drawing.Size(1353, 194);
            this.dgvDetalleNotaSalida.TabIndex = 94;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarProducto.BorderRadius = 40;
            this.btnBuscarProducto.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(469, 56);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(103, 37);
            this.btnBuscarProducto.TabIndex = 93;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextColor = System.Drawing.Color.White;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // txtDesProducto
            // 
            this.txtDesProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesProducto.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDesProducto.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDesProducto.BorderRadius = 15;
            this.txtDesProducto.BorderSize = 2;
            this.txtDesProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDesProducto.ForeColor = System.Drawing.Color.Black;
            this.txtDesProducto.Location = new System.Drawing.Point(24, 59);
            this.txtDesProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesProducto.Multiline = false;
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDesProducto.PasswordChar = false;
            this.txtDesProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesProducto.PlaceholderText = "";
            this.txtDesProducto.Size = new System.Drawing.Size(436, 36);
            this.txtDesProducto.TabIndex = 90;
            this.txtDesProducto.UnderlinedStyle = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(834, 58);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.Size = new System.Drawing.Size(197, 36);
            this.txtCantidad.TabIndex = 87;
            this.txtCantidad.UnderlinedStyle = false;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDProducto.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDProducto.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDProducto.BorderRadius = 15;
            this.txtIDProducto.BorderSize = 2;
            this.txtIDProducto.Enabled = false;
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDProducto.ForeColor = System.Drawing.Color.Black;
            this.txtIDProducto.Location = new System.Drawing.Point(596, 57);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDProducto.Multiline = false;
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDProducto.PasswordChar = false;
            this.txtIDProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDProducto.PlaceholderText = "";
            this.txtIDProducto.Size = new System.Drawing.Size(197, 36);
            this.txtIDProducto.TabIndex = 86;
            this.txtIDProducto.UnderlinedStyle = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnFinalizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnFinalizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinalizar.BorderRadius = 40;
            this.btnFinalizar.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(1264, 47);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(148, 48);
            this.btnFinalizar.TabIndex = 80;
            this.btnFinalizar.Text = "Eliminar";
            this.btnFinalizar.TextColor = System.Drawing.Color.White;
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarProducto.BorderRadius = 40;
            this.btnAgregarProducto.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(1096, 45);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(148, 50);
            this.btnAgregarProducto.TabIndex = 79;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextColor = System.Drawing.Color.White;
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(27, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Descripcion  Producto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(840, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 23);
            this.label14.TabIndex = 76;
            this.label14.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(596, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "ID Producto:";
            // 
            // dtpOrdenVenta
            // 
            this.dtpOrdenVenta.CalendarForeColor = System.Drawing.Color.White;
            this.dtpOrdenVenta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dtpOrdenVenta.CalendarTitleBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrdenVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdenVenta.Location = new System.Drawing.Point(636, 781);
            this.dtpOrdenVenta.Name = "dtpOrdenVenta";
            this.dtpOrdenVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpOrdenVenta.Size = new System.Drawing.Size(183, 31);
            this.dtpOrdenVenta.TabIndex = 92;
            this.dtpOrdenVenta.Value = new System.DateTime(2023, 6, 27, 0, 0, 0, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(449, 764);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 50);
            this.btnLimpiar.TabIndex = 91;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(632, 755);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 23);
            this.label13.TabIndex = 90;
            this.label13.Text = "Fecha Nota Salida:";
            // 
            // btnBuscarOV
            // 
            this.btnBuscarOV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarOV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarOV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarOV.BorderRadius = 40;
            this.btnBuscarOV.BorderSize = 0;
            this.btnBuscarOV.FlatAppearance.BorderSize = 0;
            this.btnBuscarOV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarOV.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOV.Image")));
            this.btnBuscarOV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOV.Location = new System.Drawing.Point(859, 765);
            this.btnBuscarOV.Name = "btnBuscarOV";
            this.btnBuscarOV.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarOV.TabIndex = 96;
            this.btnBuscarOV.Text = "Buscar";
            this.btnBuscarOV.TextColor = System.Drawing.Color.White;
            this.btnBuscarOV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarOV.UseVisualStyleBackColor = false;
            this.btnBuscarOV.Click += new System.EventHandler(this.btnBuscarOV_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAnular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAnular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnular.BorderRadius = 40;
            this.btnAnular.BorderSize = 0;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(1262, 765);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(148, 50);
            this.btnAnular.TabIndex = 95;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextColor = System.Drawing.Color.White;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(1061, 765);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 94;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(25, 764);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 93;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmNotaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1455, 874);
            this.Controls.Add(this.btnBuscarOV);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpOrdenVenta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbDetalleNotaSalida);
            this.Controls.Add(this.dgvNotaSalida);
            this.Controls.Add(this.gbNotaSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNotaSalida";
            this.Text = "FrmNotaSalida";
            this.gbNotaSalida.ResumeLayout(false);
            this.gbNotaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaSalida)).EndInit();
            this.gbDetalleNotaSalida.ResumeLayout(false);
            this.gbDetalleNotaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNotaSalida;
        private Botones.Boton btnAgregarNotaSalida;
        private NiikTextBox txtNNotaSalida;
        private NiikTextBox txtIDNotaSalida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvNotaSalida;
        private System.Windows.Forms.GroupBox gbDetalleNotaSalida;
        private System.Windows.Forms.DataGridView dgvDetalleNotaSalida;
        private Botones.Boton btnBuscarProducto;
        private NiikTextBox txtDesProducto;
        private NiikTextBox txtCantidad;
        private NiikTextBox txtIDProducto;
        private Botones.Boton btnFinalizar;
        private Botones.Boton btnAgregarProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private Botones.Boton btnBuscarOV;
        private Botones.Boton btnAnular;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnSalir;
        private System.Windows.Forms.DateTimePicker dtpOrdenVenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label13;
        private NiikTextBox txtN_Orden_Venta;
    }
}