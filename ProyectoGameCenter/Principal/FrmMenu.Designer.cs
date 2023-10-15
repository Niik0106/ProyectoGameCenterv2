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
            this.btnNotaSalida = new System.Windows.Forms.Button();
            this.btnMetodoPago = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.panelVentaSubMenu = new System.Windows.Forms.Panel();
            this.btnCronogramaPago = new System.Windows.Forms.Button();
            this.btnOrdenVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelProductoSubMenu = new System.Windows.Forms.Panel();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnProductosSubMenu = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelClienteSubMenu = new System.Windows.Forms.Panel();
            this.btnClienteJuridico = new System.Windows.Forms.Button();
            this.btnClienteNatural = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panelMenuLateral.SuspendLayout();
            this.panelVentaSubMenu.SuspendLayout();
            this.panelProductoSubMenu.SuspendLayout();
            this.panelClienteSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCabecera.SuspendLayout();
            this.panelHoraFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.panelMenuLateral.Controls.Add(this.btnNotaSalida);
            this.panelMenuLateral.Controls.Add(this.btnMetodoPago);
            this.panelMenuLateral.Controls.Add(this.btnProveedores);
            this.panelMenuLateral.Controls.Add(this.btnOrdenCompra);
            this.panelMenuLateral.Controls.Add(this.panelVentaSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnVentas);
            this.panelMenuLateral.Controls.Add(this.panelProductoSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnProductos);
            this.panelMenuLateral.Controls.Add(this.panelClienteSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.panelMenuLateral.Controls.Add(this.btnCliente);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(373, 1055);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // btnNotaSalida
            // 
            this.panelConfiguracionSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelConfiguracionSubMenu.Controls.Add(this.btnEmpresa);
            this.panelConfiguracionSubMenu.Controls.Add(this.btnUsuarios);
            this.panelConfiguracionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracionSubMenu.Location = new System.Drawing.Point(0, 1990);
            this.panelConfiguracionSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelConfiguracionSubMenu.Name = "panelConfiguracionSubMenu";
            this.panelConfiguracionSubMenu.Size = new System.Drawing.Size(352, 197);
            this.panelConfiguracionSubMenu.TabIndex = 46;
            // 
            // btnMetodoPago
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
            this.btnEmpresa.Location = new System.Drawing.Point(0, 98);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEmpresa.Size = new System.Drawing.Size(352, 98);
            this.btnEmpresa.TabIndex = 5;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
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
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(352, 98);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
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
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 1892);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(352, 98);
            this.btnConfiguracion.TabIndex = 45;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
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
            this.btnPagos.Location = new System.Drawing.Point(0, 1794);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnPagos.Size = new System.Drawing.Size(352, 98);
            this.btnPagos.TabIndex = 44;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 2187);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(352, 98);
            this.btnCerrarSesion.TabIndex = 31;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelReportesSubMenu
            // 
            this.panelReportesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelReportesSubMenu.Controls.Add(this.btnReportesCompras);
            this.panelReportesSubMenu.Controls.Add(this.btnReportesVentas);
            this.panelReportesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportesSubMenu.Location = new System.Drawing.Point(0, 1597);
            this.panelReportesSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReportesSubMenu.Name = "panelReportesSubMenu";
            this.panelReportesSubMenu.Size = new System.Drawing.Size(352, 197);
            this.panelReportesSubMenu.TabIndex = 43;
            // 
            // btnReportesCompras
            // 
            this.btnReportesCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesCompras.FlatAppearance.BorderSize = 0;
            this.btnReportesCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesCompras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportesCompras.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnReportesCompras.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportesCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportesCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesCompras.Location = new System.Drawing.Point(0, 98);
            this.btnReportesCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportesCompras.Name = "btnReportesCompras";
            this.btnReportesCompras.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnReportesCompras.Size = new System.Drawing.Size(352, 98);
            this.btnReportesCompras.TabIndex = 4;
            this.btnReportesCompras.Text = "Reportes Compras";
            this.btnReportesCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesCompras.UseVisualStyleBackColor = true;
            // 
            // btnReportesVentas
            // 
            this.btnReportesVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesVentas.FlatAppearance.BorderSize = 0;
            this.btnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesVentas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportesVentas.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnReportesVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportesVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesVentas.Location = new System.Drawing.Point(0, 0);
            this.btnReportesVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportesVentas.Name = "btnReportesVentas";
            this.btnReportesVentas.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnReportesVentas.Size = new System.Drawing.Size(352, 98);
            this.btnReportesVentas.TabIndex = 3;
            this.btnReportesVentas.Text = "Reportes Ventas";
            this.btnReportesVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesVentas.UseVisualStyleBackColor = true;
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
            this.btnReportes.Location = new System.Drawing.Point(0, 1499);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnReportes.Size = new System.Drawing.Size(352, 98);
            this.btnReportes.TabIndex = 42;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelComprasSubMenu
            // 
            this.panelComprasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelComprasSubMenu.Controls.Add(this.btnNotaEntrada);
            this.panelComprasSubMenu.Controls.Add(this.btnOrdenCompra);
            this.panelComprasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComprasSubMenu.Location = new System.Drawing.Point(0, 1302);
            this.panelComprasSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelComprasSubMenu.Name = "panelComprasSubMenu";
            this.panelComprasSubMenu.Size = new System.Drawing.Size(352, 197);
            this.panelComprasSubMenu.TabIndex = 41;
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
            this.btnNotaEntrada.Location = new System.Drawing.Point(0, 98);
            this.btnNotaEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotaEntrada.Name = "btnNotaEntrada";
            this.btnNotaEntrada.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnNotaEntrada.Size = new System.Drawing.Size(352, 98);
            this.btnNotaEntrada.TabIndex = 3;
            this.btnNotaEntrada.Text = "Nota Entrada";
            this.btnNotaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaEntrada.UseVisualStyleBackColor = true;
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnOrdenCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.btnOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenCompra.Image")));
            this.btnOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenCompra.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnOrdenCompra.Size = new System.Drawing.Size(352, 98);
            this.btnOrdenCompra.TabIndex = 2;
            this.btnOrdenCompra.Text = "Orden Compra";
            this.btnOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenCompra.UseVisualStyleBackColor = true;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
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
            this.btnCompras.Location = new System.Drawing.Point(0, 1204);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCompras.Size = new System.Drawing.Size(352, 98);
            this.btnCompras.TabIndex = 40;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelVentaSubMenu
            // 
            this.panelVentaSubMenu.BackColor = System.Drawing.Color.Indigo;
            this.panelVentaSubMenu.Controls.Add(this.btnCronogramaPago);
            this.panelVentaSubMenu.Controls.Add(this.btnOrdenVenta);
            this.panelVentaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentaSubMenu.Location = new System.Drawing.Point(0, 1007);
            this.panelVentaSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVentaSubMenu.Name = "panelVentaSubMenu";
            this.panelVentaSubMenu.Size = new System.Drawing.Size(352, 197);
            this.panelVentaSubMenu.TabIndex = 39;
            // 
            // btnCronogramaPago
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
            this.btnNotaSalida.Location = new System.Drawing.Point(0, 98);
            this.btnNotaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotaSalida.Name = "btnNotaSalida";
            this.btnNotaSalida.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnNotaSalida.Size = new System.Drawing.Size(352, 98);
            this.btnNotaSalida.TabIndex = 2;
            this.btnNotaSalida.Text = "Nota Salida";
            this.btnNotaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaSalida.UseVisualStyleBackColor = true;
            // 
            // btnOrdenVenta
            // 
            this.btnOrdenVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenVenta.FlatAppearance.BorderSize = 0;
            this.btnOrdenVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenVenta.ForeColor = System.Drawing.Color.White;
            this.btnOrdenVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenVenta.Image")));
            this.btnOrdenVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenVenta.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenVenta.Name = "btnOrdenVenta";
            this.btnOrdenVenta.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnOrdenVenta.Size = new System.Drawing.Size(352, 98);
            this.btnOrdenVenta.TabIndex = 1;
            this.btnOrdenVenta.Text = "Orden Venta";
            this.btnOrdenVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenVenta.UseVisualStyleBackColor = true;
            this.btnOrdenVenta.Click += new System.EventHandler(this.btnOrdenVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 909);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnVentas.Size = new System.Drawing.Size(352, 98);
            this.btnVentas.TabIndex = 38;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelProductoSubMenu
            // 
            this.panelProductoSubMenu.BackColor = System.Drawing.Color.Indigo;
            this.panelProductoSubMenu.Controls.Add(this.btnMarca);
            this.panelProductoSubMenu.Controls.Add(this.btnCategoria);
            this.panelProductoSubMenu.Controls.Add(this.btnProductosSubMenu);
            this.panelProductoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductoSubMenu.Location = new System.Drawing.Point(0, 614);
            this.panelProductoSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProductoSubMenu.Name = "panelProductoSubMenu";
            this.panelProductoSubMenu.Size = new System.Drawing.Size(352, 295);
            this.panelProductoSubMenu.TabIndex = 37;
            // 
            // btnMarca
            // 
            this.btnMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.Color.White;
            this.btnMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.Image")));
            this.btnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.Location = new System.Drawing.Point(0, 196);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnMarca.Size = new System.Drawing.Size(352, 98);
            this.btnMarca.TabIndex = 3;
            this.btnMarca.Text = "Marca";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 98);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCategoria.Size = new System.Drawing.Size(352, 98);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProductosSubMenu
            // 
            this.btnProductosSubMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosSubMenu.FlatAppearance.BorderSize = 0;
            this.btnProductosSubMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProductosSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosSubMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosSubMenu.ForeColor = System.Drawing.Color.White;
            this.btnProductosSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnProductosSubMenu.Image")));
            this.btnProductosSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btnProductosSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductosSubMenu.Name = "btnProductosSubMenu";
            this.btnProductosSubMenu.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnProductosSubMenu.Size = new System.Drawing.Size(352, 98);
            this.btnProductosSubMenu.TabIndex = 1;
            this.btnProductosSubMenu.Text = "Productos";
            this.btnProductosSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductosSubMenu.UseVisualStyleBackColor = true;
            this.btnProductosSubMenu.Click += new System.EventHandler(this.btnProductosSubMenu_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 516);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnProductos.Size = new System.Drawing.Size(352, 98);
            this.btnProductos.TabIndex = 36;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
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
            this.btnProveedores.Location = new System.Drawing.Point(0, 418);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnProveedores.Size = new System.Drawing.Size(352, 98);
            this.btnProveedores.TabIndex = 35;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // panelClienteSubMenu
            // 
            this.panelClienteSubMenu.BackColor = System.Drawing.Color.Indigo;
            this.panelClienteSubMenu.Controls.Add(this.btnClienteJuridico);
            this.panelClienteSubMenu.Controls.Add(this.btnClienteNatural);
            this.panelClienteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteSubMenu.Location = new System.Drawing.Point(0, 221);
            this.panelClienteSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClienteSubMenu.Name = "panelClienteSubMenu";
            this.panelClienteSubMenu.Size = new System.Drawing.Size(352, 197);
            this.panelClienteSubMenu.TabIndex = 34;
            // 
            // btnClienteJuridico
            // 
            this.btnClienteJuridico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteJuridico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteJuridico.FlatAppearance.BorderSize = 0;
            this.btnClienteJuridico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClienteJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteJuridico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteJuridico.ForeColor = System.Drawing.Color.White;
            this.btnClienteJuridico.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteJuridico.Image")));
            this.btnClienteJuridico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteJuridico.Location = new System.Drawing.Point(0, 98);
            this.btnClienteJuridico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteJuridico.Name = "btnClienteJuridico";
            this.btnClienteJuridico.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnClienteJuridico.Size = new System.Drawing.Size(352, 98);
            this.btnClienteJuridico.TabIndex = 1;
            this.btnClienteJuridico.Text = "Cliente Juridico";
            this.btnClienteJuridico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteJuridico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClienteJuridico.UseVisualStyleBackColor = true;
            this.btnClienteJuridico.Click += new System.EventHandler(this.btnClienteJuridico_Click);
            // 
            // btnClienteNatural
            // 
            this.btnClienteNatural.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteNatural.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteNatural.FlatAppearance.BorderSize = 0;
            this.btnClienteNatural.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClienteNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteNatural.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteNatural.ForeColor = System.Drawing.Color.White;
            this.btnClienteNatural.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteNatural.Image")));
            this.btnClienteNatural.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteNatural.Location = new System.Drawing.Point(0, 0);
            this.btnClienteNatural.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteNatural.Name = "btnClienteNatural";
            this.btnClienteNatural.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnClienteNatural.Size = new System.Drawing.Size(352, 98);
            this.btnClienteNatural.TabIndex = 0;
            this.btnClienteNatural.Text = "Cliente Natural";
            this.btnClienteNatural.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteNatural.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClienteNatural.UseVisualStyleBackColor = true;
            this.btnClienteNatural.Click += new System.EventHandler(this.btnClienteNatural_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 800);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(233, 50);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "     CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 123);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCliente.Size = new System.Drawing.Size(352, 98);
            this.btnCliente.TabIndex = 33;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(48)))), ((int)(((byte)(226)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(352, 123);
            this.panelLogo.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(436, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCabecera
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnCerrar);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(373, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1551, 74);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(1423, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 28);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnPCompleta
            // 
            this.btnPCompleta.BackColor = System.Drawing.Color.Transparent;
            this.btnPCompleta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPCompleta.FlatAppearance.BorderSize = 0;
            this.btnPCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCompleta.Image = ((System.Drawing.Image)(resources.GetObject("btnPCompleta.Image")));
            this.btnPCompleta.Location = new System.Drawing.Point(942, 0);
            this.btnPCompleta.Name = "btnPCompleta";
            this.btnPCompleta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPCompleta.Size = new System.Drawing.Size(36, 30);
            this.btnPCompleta.TabIndex = 2;
            this.btnPCompleta.UseVisualStyleBackColor = false;
            this.btnPCompleta.Click += new System.EventHandler(this.btnPCompleta_Click);
            // 
            // btnRestaurar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.Location = new System.Drawing.Point(1467, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(36, 28);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(1511, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 28);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelHoraFecha
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitleChildForm.Location = new System.Drawing.Point(80, 25);
            this.lbTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(95, 33);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Home";
            // 
            // label3
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 48;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(27, 20);
            this.IconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(49, 48);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(373, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1551, 9);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(373, 83);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1551, 972);
            this.panelContenedor.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblFecha.Location = new System.Drawing.Point(781, 757);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 39);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(751, 610);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(379, 135);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // panelContenedor
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 192);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelHoraFecha);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.panelMenuLateral);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1727, 883);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Center";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelVentaSubMenu.ResumeLayout(false);
            this.panelProductoSubMenu.ResumeLayout(false);
            this.panelClienteSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCabecera.ResumeLayout(false);
            this.panelHoraFecha.ResumeLayout(false);
            this.panelHoraFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPCompleta;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelHoraFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNotaSalida;
        private System.Windows.Forms.Button btnMetodoPago;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Panel panelVentaSubMenu;
        private System.Windows.Forms.Button btnCronogramaPago;
        private System.Windows.Forms.Button btnOrdenVenta;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelProductoSubMenu;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnProductosSubMenu;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panelClienteSubMenu;
        private System.Windows.Forms.Button btnClienteJuridico;
        private System.Windows.Forms.Button btnClienteNatural;
    }
}