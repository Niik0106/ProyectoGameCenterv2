namespace ProyectoGameCenter.Principal
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnPCompleta = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelHoraFecha = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.panelClienteSubMenu = new System.Windows.Forms.Panel();
            this.btnClienteNatural = new FontAwesome.Sharp.IconButton();
            this.btnClienteJuridico = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.panelProductoSubMenu = new System.Windows.Forms.Panel();
            this.btnProductosSubMenu = new FontAwesome.Sharp.IconButton();
            this.btnCategoria = new FontAwesome.Sharp.IconButton();
            this.btnMarca = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelVentaSubMenu = new System.Windows.Forms.Panel();
            this.btnOrdenVenta = new FontAwesome.Sharp.IconButton();
            this.btnNotaSalida = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.panelComprasSubMenu = new System.Windows.Forms.Panel();
            this.btnOrdenCompra = new FontAwesome.Sharp.IconButton();
            this.btnNotaEntrada = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelReportesSubMenu = new System.Windows.Forms.Panel();
            this.btnReportesVentas = new FontAwesome.Sharp.IconButton();
            this.btnReportesCompras = new FontAwesome.Sharp.IconButton();
            this.btnPagos = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.panelConfiguracionSubMenu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnEmpresa = new FontAwesome.Sharp.IconButton();
            this.panelMenuLateral.SuspendLayout();
            this.panelCabecera.SuspendLayout();
            this.panelHoraFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelClienteSubMenu.SuspendLayout();
            this.panelProductoSubMenu.SuspendLayout();
            this.panelVentaSubMenu.SuspendLayout();
            this.panelComprasSubMenu.SuspendLayout();
            this.panelReportesSubMenu.SuspendLayout();
            this.panelConfiguracionSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenuLateral.Controls.Add(this.panelConfiguracionSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnConfiguracion);
            this.panelMenuLateral.Controls.Add(this.btnPagos);
            this.panelMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.panelMenuLateral.Controls.Add(this.panelReportesSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnReportes);
            this.panelMenuLateral.Controls.Add(this.panelComprasSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnCompras);
            this.panelMenuLateral.Controls.Add(this.panelVentaSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnVentas);
            this.panelMenuLateral.Controls.Add(this.panelProductoSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnProductos);
            this.panelMenuLateral.Controls.Add(this.btnProveedores);
            this.panelMenuLateral.Controls.Add(this.panelClienteSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnCliente);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(350, 1080);
            this.panelMenuLateral.TabIndex = 0;
            this.panelMenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuLateral_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 1780);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(333, 80);
            this.btnCerrarSesion.TabIndex = 31;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.btnMinimizar);
            this.panelCabecera.Controls.Add(this.btnPCompleta);
            this.panelCabecera.Controls.Add(this.btnRestaurar);
            this.panelCabecera.Controls.Add(this.btnCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(350, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1570, 30);
            this.panelCabecera.TabIndex = 1;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecera_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1426, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinimizar.Size = new System.Drawing.Size(36, 30);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnPCompleta
            // 
            this.btnPCompleta.BackColor = System.Drawing.Color.Transparent;
            this.btnPCompleta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPCompleta.FlatAppearance.BorderSize = 0;
            this.btnPCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCompleta.Image = ((System.Drawing.Image)(resources.GetObject("btnPCompleta.Image")));
            this.btnPCompleta.Location = new System.Drawing.Point(1462, 0);
            this.btnPCompleta.Name = "btnPCompleta";
            this.btnPCompleta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPCompleta.Size = new System.Drawing.Size(36, 30);
            this.btnPCompleta.TabIndex = 2;
            this.btnPCompleta.UseVisualStyleBackColor = false;
            this.btnPCompleta.Click += new System.EventHandler(this.btnPCompleta_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1498, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRestaurar.Size = new System.Drawing.Size(36, 30);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1534, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(36, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelHoraFecha
            // 
            this.panelHoraFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelHoraFecha.Controls.Add(this.label3);
            this.panelHoraFecha.Controls.Add(this.label2);
            this.panelHoraFecha.Controls.Add(this.label1);
            this.panelHoraFecha.Controls.Add(this.pictureBox2);
            this.panelHoraFecha.Controls.Add(this.lblFecha);
            this.panelHoraFecha.Controls.Add(this.lblHora);
            this.panelHoraFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHoraFecha.Location = new System.Drawing.Point(350, 1010);
            this.panelHoraFecha.Name = "panelHoraFecha";
            this.panelHoraFecha.Size = new System.Drawing.Size(1570, 70);
            this.panelHoraFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CARGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1421, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(142, 32);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1400, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(170, 40);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(350, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1570, 980);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.pictureBox3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(333, 100);
            this.panelLogo.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(38, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 100);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCliente.Size = new System.Drawing.Size(333, 80);
            this.btnCliente.TabIndex = 33;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelClienteSubMenu
            // 
            this.panelClienteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelClienteSubMenu.Controls.Add(this.btnClienteJuridico);
            this.panelClienteSubMenu.Controls.Add(this.btnClienteNatural);
            this.panelClienteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteSubMenu.Location = new System.Drawing.Point(0, 180);
            this.panelClienteSubMenu.Name = "panelClienteSubMenu";
            this.panelClienteSubMenu.Size = new System.Drawing.Size(333, 160);
            this.panelClienteSubMenu.TabIndex = 34;
            // 
            // btnClienteNatural
            // 
            this.btnClienteNatural.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteNatural.FlatAppearance.BorderSize = 0;
            this.btnClienteNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteNatural.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteNatural.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClienteNatural.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnClienteNatural.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClienteNatural.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteNatural.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteNatural.Location = new System.Drawing.Point(0, 0);
            this.btnClienteNatural.Name = "btnClienteNatural";
            this.btnClienteNatural.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClienteNatural.Size = new System.Drawing.Size(333, 80);
            this.btnClienteNatural.TabIndex = 0;
            this.btnClienteNatural.Text = "Cliente Natural";
            this.btnClienteNatural.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteNatural.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClienteNatural.UseVisualStyleBackColor = true;
            this.btnClienteNatural.Click += new System.EventHandler(this.btnClienteNatural_Click);
            // 
            // btnClienteJuridico
            // 
            this.btnClienteJuridico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteJuridico.FlatAppearance.BorderSize = 0;
            this.btnClienteJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteJuridico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteJuridico.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClienteJuridico.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnClienteJuridico.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClienteJuridico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteJuridico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteJuridico.Location = new System.Drawing.Point(0, 80);
            this.btnClienteJuridico.Name = "btnClienteJuridico";
            this.btnClienteJuridico.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClienteJuridico.Size = new System.Drawing.Size(333, 80);
            this.btnClienteJuridico.TabIndex = 1;
            this.btnClienteJuridico.Text = "Cliente Juridico";
            this.btnClienteJuridico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteJuridico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClienteJuridico.UseVisualStyleBackColor = true;
            this.btnClienteJuridico.Click += new System.EventHandler(this.btnClienteJuridico_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            this.btnProveedores.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 340);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProveedores.Size = new System.Drawing.Size(333, 80);
            this.btnProveedores.TabIndex = 35;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 420);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductos.Size = new System.Drawing.Size(333, 80);
            this.btnProductos.TabIndex = 36;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panelProductoSubMenu
            // 
            this.panelProductoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelProductoSubMenu.Controls.Add(this.btnMarca);
            this.panelProductoSubMenu.Controls.Add(this.btnCategoria);
            this.panelProductoSubMenu.Controls.Add(this.btnProductosSubMenu);
            this.panelProductoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductoSubMenu.Location = new System.Drawing.Point(0, 500);
            this.panelProductoSubMenu.Name = "panelProductoSubMenu";
            this.panelProductoSubMenu.Size = new System.Drawing.Size(333, 240);
            this.panelProductoSubMenu.TabIndex = 37;
            // 
            // btnProductosSubMenu
            // 
            this.btnProductosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosSubMenu.FlatAppearance.BorderSize = 0;
            this.btnProductosSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosSubMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosSubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductosSubMenu.IconChar = FontAwesome.Sharp.IconChar.Ghost;
            this.btnProductosSubMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductosSubMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductosSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btnProductosSubMenu.Name = "btnProductosSubMenu";
            this.btnProductosSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductosSubMenu.Size = new System.Drawing.Size(333, 80);
            this.btnProductosSubMenu.TabIndex = 1;
            this.btnProductosSubMenu.Text = "Productos";
            this.btnProductosSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductosSubMenu.UseVisualStyleBackColor = true;
            this.btnProductosSubMenu.Click += new System.EventHandler(this.btnProductosSubMenu_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCategoria.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 80);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCategoria.Size = new System.Drawing.Size(333, 80);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMarca.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.btnMarca.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.Location = new System.Drawing.Point(0, 160);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMarca.Size = new System.Drawing.Size(333, 80);
            this.btnMarca.TabIndex = 3;
            this.btnMarca.Text = "Marca";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 740);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Size = new System.Drawing.Size(333, 80);
            this.btnVentas.TabIndex = 38;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelVentaSubMenu
            // 
            this.panelVentaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelVentaSubMenu.Controls.Add(this.btnNotaSalida);
            this.panelVentaSubMenu.Controls.Add(this.btnOrdenVenta);
            this.panelVentaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentaSubMenu.Location = new System.Drawing.Point(0, 820);
            this.panelVentaSubMenu.Name = "panelVentaSubMenu";
            this.panelVentaSubMenu.Size = new System.Drawing.Size(333, 160);
            this.panelVentaSubMenu.TabIndex = 39;
            // 
            // btnOrdenVenta
            // 
            this.btnOrdenVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenVenta.FlatAppearance.BorderSize = 0;
            this.btnOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrdenVenta.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnOrdenVenta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrdenVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdenVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenVenta.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenVenta.Name = "btnOrdenVenta";
            this.btnOrdenVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrdenVenta.Size = new System.Drawing.Size(333, 80);
            this.btnOrdenVenta.TabIndex = 1;
            this.btnOrdenVenta.Text = "Orden Venta";
            this.btnOrdenVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenVenta.UseVisualStyleBackColor = true;
            this.btnOrdenVenta.Click += new System.EventHandler(this.btnOrdenVenta_Click);
            // 
            // btnNotaSalida
            // 
            this.btnNotaSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotaSalida.FlatAppearance.BorderSize = 0;
            this.btnNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaSalida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaSalida.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotaSalida.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnNotaSalida.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNotaSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotaSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaSalida.Location = new System.Drawing.Point(0, 80);
            this.btnNotaSalida.Name = "btnNotaSalida";
            this.btnNotaSalida.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNotaSalida.Size = new System.Drawing.Size(333, 80);
            this.btnNotaSalida.TabIndex = 2;
            this.btnNotaSalida.Text = "Nota Salida";
            this.btnNotaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaSalida.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnCompras.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 980);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompras.Size = new System.Drawing.Size(333, 80);
            this.btnCompras.TabIndex = 40;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelComprasSubMenu
            // 
            this.panelComprasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelComprasSubMenu.Controls.Add(this.btnNotaEntrada);
            this.panelComprasSubMenu.Controls.Add(this.btnOrdenCompra);
            this.panelComprasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComprasSubMenu.Location = new System.Drawing.Point(0, 1060);
            this.panelComprasSubMenu.Name = "panelComprasSubMenu";
            this.panelComprasSubMenu.Size = new System.Drawing.Size(333, 160);
            this.panelComprasSubMenu.TabIndex = 41;
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrdenCompra.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnOrdenCompra.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrdenCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenCompra.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrdenCompra.Size = new System.Drawing.Size(333, 80);
            this.btnOrdenCompra.TabIndex = 2;
            this.btnOrdenCompra.Text = "Orden Compra";
            this.btnOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenCompra.UseVisualStyleBackColor = true;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click_1);
            // 
            // btnNotaEntrada
            // 
            this.btnNotaEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotaEntrada.FlatAppearance.BorderSize = 0;
            this.btnNotaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaEntrada.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaEntrada.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotaEntrada.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnNotaEntrada.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNotaEntrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaEntrada.Location = new System.Drawing.Point(0, 80);
            this.btnNotaEntrada.Name = "btnNotaEntrada";
            this.btnNotaEntrada.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNotaEntrada.Size = new System.Drawing.Size(333, 80);
            this.btnNotaEntrada.TabIndex = 3;
            this.btnNotaEntrada.Text = "Nota Entrada";
            this.btnNotaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaEntrada.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 1220);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Size = new System.Drawing.Size(333, 80);
            this.btnReportes.TabIndex = 42;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelReportesSubMenu
            // 
            this.panelReportesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelReportesSubMenu.Controls.Add(this.btnReportesCompras);
            this.panelReportesSubMenu.Controls.Add(this.btnReportesVentas);
            this.panelReportesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportesSubMenu.Location = new System.Drawing.Point(0, 1300);
            this.panelReportesSubMenu.Name = "panelReportesSubMenu";
            this.panelReportesSubMenu.Size = new System.Drawing.Size(333, 160);
            this.panelReportesSubMenu.TabIndex = 43;
            // 
            // btnReportesVentas
            // 
            this.btnReportesVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesVentas.FlatAppearance.BorderSize = 0;
            this.btnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesVentas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportesVentas.IconChar = FontAwesome.Sharp.IconChar.FileLines;
            this.btnReportesVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportesVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesVentas.Location = new System.Drawing.Point(0, 0);
            this.btnReportesVentas.Name = "btnReportesVentas";
            this.btnReportesVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportesVentas.Size = new System.Drawing.Size(333, 80);
            this.btnReportesVentas.TabIndex = 3;
            this.btnReportesVentas.Text = "Reportes Ventas";
            this.btnReportesVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesVentas.UseVisualStyleBackColor = true;
            // 
            // btnReportesCompras
            // 
            this.btnReportesCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesCompras.FlatAppearance.BorderSize = 0;
            this.btnReportesCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesCompras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportesCompras.IconChar = FontAwesome.Sharp.IconChar.FileLines;
            this.btnReportesCompras.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportesCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportesCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesCompras.Location = new System.Drawing.Point(0, 80);
            this.btnReportesCompras.Name = "btnReportesCompras";
            this.btnReportesCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportesCompras.Size = new System.Drawing.Size(333, 80);
            this.btnReportesCompras.TabIndex = 4;
            this.btnReportesCompras.Text = "Reportes Compras";
            this.btnReportesCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesCompras.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagos.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnPagos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 1460);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPagos.Size = new System.Drawing.Size(333, 80);
            this.btnPagos.TabIndex = 44;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnConfiguracion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 1540);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(333, 80);
            this.btnConfiguracion.TabIndex = 45;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panelConfiguracionSubMenu
            // 
            this.panelConfiguracionSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelConfiguracionSubMenu.Controls.Add(this.btnEmpresa);
            this.panelConfiguracionSubMenu.Controls.Add(this.btnUsuarios);
            this.panelConfiguracionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracionSubMenu.Location = new System.Drawing.Point(0, 1620);
            this.panelConfiguracionSubMenu.Name = "panelConfiguracionSubMenu";
            this.panelConfiguracionSubMenu.Size = new System.Drawing.Size(333, 160);
            this.panelConfiguracionSubMenu.TabIndex = 46;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnUsuarios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(333, 80);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpresa.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnEmpresa.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Location = new System.Drawing.Point(0, 80);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpresa.Size = new System.Drawing.Size(333, 80);
            this.btnEmpresa.TabIndex = 5;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelHoraFecha);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.panelMenuLateral);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 726);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Center";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelCabecera.ResumeLayout(false);
            this.panelHoraFecha.ResumeLayout(false);
            this.panelHoraFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelClienteSubMenu.ResumeLayout(false);
            this.panelProductoSubMenu.ResumeLayout(false);
            this.panelVentaSubMenu.ResumeLayout(false);
            this.panelComprasSubMenu.ResumeLayout(false);
            this.panelReportesSubMenu.ResumeLayout(false);
            this.panelConfiguracionSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPCompleta;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelHoraFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btnCliente;
        private System.Windows.Forms.Panel panelClienteSubMenu;
        private FontAwesome.Sharp.IconButton btnClienteNatural;
        private FontAwesome.Sharp.IconButton btnClienteJuridico;
        private System.Windows.Forms.Panel panelProductoSubMenu;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private FontAwesome.Sharp.IconButton btnProductosSubMenu;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private System.Windows.Forms.Panel panelVentaSubMenu;
        private FontAwesome.Sharp.IconButton btnOrdenVenta;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnMarca;
        private FontAwesome.Sharp.IconButton btnNotaSalida;
        private FontAwesome.Sharp.IconButton btnCompras;
        private System.Windows.Forms.Panel panelComprasSubMenu;
        private System.Windows.Forms.Panel panelReportesSubMenu;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnNotaEntrada;
        private FontAwesome.Sharp.IconButton btnOrdenCompra;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnPagos;
        private FontAwesome.Sharp.IconButton btnReportesCompras;
        private FontAwesome.Sharp.IconButton btnReportesVentas;
        private System.Windows.Forms.Panel panelConfiguracionSubMenu;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnEmpresa;
    }
}