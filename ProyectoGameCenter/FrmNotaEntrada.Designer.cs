namespace ProyectoGameCenter
{
    partial class FrmNotaEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaEntrada));
            this.gbNotaEntrada = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalleOrdenCompra = new System.Windows.Forms.DataGridView();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.dgvNotaEntrada = new System.Windows.Forms.DataGridView();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarOC = new ProyectoGameCenter.Botones.Boton();
            this.txtNumOrden = new ProyectoGameCenter.NiikTextBox();
            this.btnAgregarNota = new ProyectoGameCenter.Botones.Boton();
            this.txtNNotaEntrada = new ProyectoGameCenter.NiikTextBox();
            this.txtIDNotaEntrada = new ProyectoGameCenter.NiikTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaNotaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarNE = new ProyectoGameCenter.Botones.Boton();
            this.btnSalir = new ProyectoGameCenter.Botones.Boton();
            this.btnAnular = new ProyectoGameCenter.Botones.Boton();
            this.btnNuevo = new ProyectoGameCenter.Botones.Boton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.gbNotaEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNotaEntrada
            // 
            this.gbNotaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gbNotaEntrada.Controls.Add(this.label7);
            this.gbNotaEntrada.Controls.Add(this.label6);
            this.gbNotaEntrada.Controls.Add(this.label5);
            this.gbNotaEntrada.Controls.Add(this.dgvDetalleOrdenCompra);
            this.gbNotaEntrada.Controls.Add(this.cbxEstado);
            this.gbNotaEntrada.Controls.Add(this.dgvNotaEntrada);
            this.gbNotaEntrada.Controls.Add(this.dgvOrdenCompra);
            this.gbNotaEntrada.Controls.Add(this.dtpFechaOrden);
            this.gbNotaEntrada.Controls.Add(this.label2);
            this.gbNotaEntrada.Controls.Add(this.btnBuscarOC);
            this.gbNotaEntrada.Controls.Add(this.txtNumOrden);
            this.gbNotaEntrada.Controls.Add(this.btnAgregarNota);
            this.gbNotaEntrada.Controls.Add(this.txtNNotaEntrada);
            this.gbNotaEntrada.Controls.Add(this.txtIDNotaEntrada);
            this.gbNotaEntrada.Controls.Add(this.label16);
            this.gbNotaEntrada.Controls.Add(this.label11);
            this.gbNotaEntrada.Controls.Add(this.dtpFechaNotaEntrada);
            this.gbNotaEntrada.Controls.Add(this.label1);
            this.gbNotaEntrada.Controls.Add(this.label3);
            this.gbNotaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNotaEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotaEntrada.ForeColor = System.Drawing.Color.White;
            this.gbNotaEntrada.Location = new System.Drawing.Point(31, 28);
            this.gbNotaEntrada.Name = "gbNotaEntrada";
            this.gbNotaEntrada.Size = new System.Drawing.Size(1454, 672);
            this.gbNotaEntrada.TabIndex = 42;
            this.gbNotaEntrada.TabStop = false;
            this.gbNotaEntrada.Text = "INFORMACION DE LA NOTA ENTRADA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(574, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 23);
            this.label7.TabIndex = 109;
            this.label7.Text = "ORDEN DE COMPRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 108;
            this.label6.Text = "NOTA DE ENTRADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "DETALLE DE ORDEN DE COMPRA";
            // 
            // dgvDetalleOrdenCompra
            // 
            this.dgvDetalleOrdenCompra.AllowUserToAddRows = false;
            this.dgvDetalleOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleOrdenCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvDetalleOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleOrdenCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleOrdenCompra.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleOrdenCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleOrdenCompra.EnableHeadersVisualStyles = false;
            this.dgvDetalleOrdenCompra.Location = new System.Drawing.Point(24, 381);
            this.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra";
            this.dgvDetalleOrdenCompra.ReadOnly = true;
            this.dgvDetalleOrdenCompra.RowHeadersVisible = false;
            this.dgvDetalleOrdenCompra.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleOrdenCompra.RowTemplate.Height = 50;
            this.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenCompra.Size = new System.Drawing.Size(1414, 255);
            this.dgvDetalleOrdenCompra.TabIndex = 106;
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEstado.Font = new System.Drawing.Font("Century Gothic", 14.5F, System.Drawing.FontStyle.Bold);
            this.cbxEstado.ForeColor = System.Drawing.Color.White;
            this.cbxEstado.Location = new System.Drawing.Point(600, 59);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(93, 27);
            this.cbxEstado.TabIndex = 103;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // dgvNotaEntrada
            // 
            this.dgvNotaEntrada.AllowUserToAddRows = false;
            this.dgvNotaEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotaEntrada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotaEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvNotaEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotaEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotaEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotaEntrada.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotaEntrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotaEntrada.EnableHeadersVisualStyles = false;
            this.dgvNotaEntrada.Location = new System.Drawing.Point(24, 146);
            this.dgvNotaEntrada.Name = "dgvNotaEntrada";
            this.dgvNotaEntrada.ReadOnly = true;
            this.dgvNotaEntrada.RowHeadersVisible = false;
            this.dgvNotaEntrada.RowHeadersWidth = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotaEntrada.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotaEntrada.RowTemplate.Height = 50;
            this.dgvNotaEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaEntrada.Size = new System.Drawing.Size(525, 177);
            this.dgvNotaEntrada.TabIndex = 102;
            this.dgvNotaEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotaEntrada_CellContentClick);
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.AllowUserToAddRows = false;
            this.dgvOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrdenCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrdenCompra.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenCompra.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrdenCompra.EnableHeadersVisualStyles = false;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(578, 146);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.ReadOnly = true;
            this.dgvOrdenCompra.RowHeadersVisible = false;
            this.dgvOrdenCompra.RowHeadersWidth = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrdenCompra.RowTemplate.Height = 50;
            this.dgvOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(854, 177);
            this.dgvOrdenCompra.TabIndex = 101;
            this.dgvOrdenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenCompra_CellClick);
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.Location = new System.Drawing.Point(1087, 64);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaOrden.Size = new System.Drawing.Size(183, 31);
            this.dtpFechaOrden.TabIndex = 100;
            this.dtpFechaOrden.Value = new System.DateTime(2023, 11, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1087, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 99;
            this.label2.Text = "Fecha Buscar:";
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarOC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarOC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarOC.BorderRadius = 40;
            this.btnBuscarOC.BorderSize = 0;
            this.btnBuscarOC.FlatAppearance.BorderSize = 0;
            this.btnBuscarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarOC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarOC.Image")));
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(1284, 45);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarOC.TabIndex = 98;
            this.btnBuscarOC.Text = "Buscar";
            this.btnBuscarOC.TextColor = System.Drawing.Color.White;
            this.btnBuscarOC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarOC.UseVisualStyleBackColor = false;
            this.btnBuscarOC.Click += new System.EventHandler(this.btnBuscarOC_Click);
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumOrden.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNumOrden.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtNumOrden.BorderRadius = 15;
            this.txtNumOrden.BorderSize = 2;
            this.txtNumOrden.Enabled = false;
            this.txtNumOrden.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumOrden.ForeColor = System.Drawing.Color.Black;
            this.txtNumOrden.Location = new System.Drawing.Point(896, 59);
            this.txtNumOrden.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumOrden.Multiline = false;
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumOrden.PasswordChar = false;
            this.txtNumOrden.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumOrden.PlaceholderText = "";
            this.txtNumOrden.Size = new System.Drawing.Size(140, 36);
            this.txtNumOrden.TabIndex = 96;
            this.txtNumOrden.UnderlinedStyle = false;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarNota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAgregarNota.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarNota.BorderRadius = 40;
            this.btnAgregarNota.BorderSize = 0;
            this.btnAgregarNota.FlatAppearance.BorderSize = 0;
            this.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarNota.Image")));
            this.btnAgregarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNota.Location = new System.Drawing.Point(724, 45);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(148, 50);
            this.btnAgregarNota.TabIndex = 95;
            this.btnAgregarNota.Text = "Agregar";
            this.btnAgregarNota.TextColor = System.Drawing.Color.White;
            this.btnAgregarNota.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // txtNNotaEntrada
            // 
            this.txtNNotaEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.txtNNotaEntrada.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNNotaEntrada.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtNNotaEntrada.BorderRadius = 15;
            this.txtNNotaEntrada.BorderSize = 2;
            this.txtNNotaEntrada.Enabled = false;
            this.txtNNotaEntrada.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNNotaEntrada.ForeColor = System.Drawing.Color.Black;
            this.txtNNotaEntrada.Location = new System.Drawing.Point(206, 59);
            this.txtNNotaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtNNotaEntrada.Multiline = false;
            this.txtNNotaEntrada.Name = "txtNNotaEntrada";
            this.txtNNotaEntrada.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNNotaEntrada.PasswordChar = false;
            this.txtNNotaEntrada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNNotaEntrada.PlaceholderText = "";
            this.txtNNotaEntrada.Size = new System.Drawing.Size(126, 36);
            this.txtNNotaEntrada.TabIndex = 91;
            this.txtNNotaEntrada.UnderlinedStyle = false;
            // 
            // txtIDNotaEntrada
            // 
            this.txtIDNotaEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDNotaEntrada.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIDNotaEntrada.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtIDNotaEntrada.BorderRadius = 15;
            this.txtIDNotaEntrada.BorderSize = 2;
            this.txtIDNotaEntrada.Enabled = false;
            this.txtIDNotaEntrada.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDNotaEntrada.ForeColor = System.Drawing.Color.Black;
            this.txtIDNotaEntrada.Location = new System.Drawing.Point(24, 59);
            this.txtIDNotaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDNotaEntrada.Multiline = false;
            this.txtIDNotaEntrada.Name = "txtIDNotaEntrada";
            this.txtIDNotaEntrada.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIDNotaEntrada.PasswordChar = false;
            this.txtIDNotaEntrada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDNotaEntrada.PlaceholderText = "";
            this.txtIDNotaEntrada.Size = new System.Drawing.Size(112, 36);
            this.txtIDNotaEntrada.TabIndex = 90;
            this.txtIDNotaEntrada.UnderlinedStyle = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(892, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 23);
            this.label16.TabIndex = 76;
            this.label16.Text = "Nª Orden Compra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID Nota Entrada:";
            // 
            // dtpFechaNotaEntrada
            // 
            this.dtpFechaNotaEntrada.Enabled = false;
            this.dtpFechaNotaEntrada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNotaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNotaEntrada.Location = new System.Drawing.Point(395, 64);
            this.dtpFechaNotaEntrada.Name = "dtpFechaNotaEntrada";
            this.dtpFechaNotaEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNotaEntrada.Size = new System.Drawing.Size(183, 31);
            this.dtpFechaNotaEntrada.TabIndex = 32;
            this.dtpFechaNotaEntrada.Value = new System.DateTime(2023, 11, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "N° Nota Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Emision:";
            // 
            // btnBuscarNE
            // 
            this.btnBuscarNE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarNE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnBuscarNE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarNE.BorderRadius = 40;
            this.btnBuscarNE.BorderSize = 0;
            this.btnBuscarNE.FlatAppearance.BorderSize = 0;
            this.btnBuscarNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarNE.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNE.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNE.Image")));
            this.btnBuscarNE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNE.Location = new System.Drawing.Point(1007, 740);
            this.btnBuscarNE.Name = "btnBuscarNE";
            this.btnBuscarNE.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarNE.TabIndex = 121;
            this.btnBuscarNE.Text = "Buscar";
            this.btnBuscarNE.TextColor = System.Drawing.Color.White;
            this.btnBuscarNE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarNE.UseVisualStyleBackColor = false;
            this.btnBuscarNE.Click += new System.EventHandler(this.btnBuscarNE_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnSalir.Location = new System.Drawing.Point(40, 740);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 50);
            this.btnSalir.TabIndex = 120;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnAnular.Location = new System.Drawing.Point(1315, 740);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(148, 50);
            this.btnAnular.TabIndex = 119;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextColor = System.Drawing.Color.White;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnNuevo.Location = new System.Drawing.Point(1161, 740);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 50);
            this.btnNuevo.TabIndex = 118;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(813, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 117;
            this.label4.Text = "Buscar por Fecha:";
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(817, 763);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(176, 27);
            this.dtpBuscarFecha.TabIndex = 116;
            // 
            // FrmNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1508, 835);
            this.Controls.Add(this.btnBuscarNE);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBuscarFecha);
            this.Controls.Add(this.gbNotaEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotaEntrada";
            this.Text = "FrmNotaEntrada";
            this.gbNotaEntrada.ResumeLayout(false);
            this.gbNotaEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNotaEntrada;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.DataGridView dgvNotaEntrada;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label label2;
        private Botones.Boton btnBuscarOC;
        private NiikTextBox txtNumOrden;
        private Botones.Boton btnAgregarNota;
        private NiikTextBox txtNNotaEntrada;
        private NiikTextBox txtIDNotaEntrada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaNotaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDetalleOrdenCompra;
        private System.Windows.Forms.Label label5;
        private Botones.Boton btnBuscarNE;
        private Botones.Boton btnSalir;
        private Botones.Boton btnAnular;
        private Botones.Boton btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}