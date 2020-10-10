namespace Tickeadora
{
    partial class frmProveedores
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
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.lblIngBrutos = new System.Windows.Forms.Label();
            this.txtIngBrutos = new System.Windows.Forms.MaskedTextBox();
            this.lblIniActividades = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblNombreFantasia = new System.Windows.Forms.Label();
            this.txtNomFantasia = new System.Windows.Forms.TextBox();
            this.lblPuntoVenta = new System.Windows.Forms.Label();
            this.txtPuntoVenta = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblDirFantasia = new System.Windows.Forms.Label();
            this.txtDirFantasia = new System.Windows.Forms.TextBox();
            this.lblLocFantasia = new System.Windows.Forms.Label();
            this.txtLocFantasia = new System.Windows.Forms.TextBox();
            this.lblProvFantasia = new System.Windows.Forms.Label();
            this.txtProvFantasia = new System.Windows.Forms.TextBox();
            this.lblCodPostalFantasia = new System.Windows.Forms.Label();
            this.txtCodPostalFantasia = new System.Windows.Forms.TextBox();
            this.lblProveedorFactura = new System.Windows.Forms.Label();
            this.cmbProvFactura = new System.Windows.Forms.ComboBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.mskIVA = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(32, 64);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(138, 64);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(197, 20);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(32, 99);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(44, 13);
            this.lblCuit.TabIndex = 2;
            this.lblCuit.Text = "C.U.I.T.";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(138, 99);
            this.txtCUIT.Mask = "00-00000000-0";
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(197, 20);
            this.txtCUIT.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(32, 169);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(138, 169);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(197, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(370, 28);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(36, 13);
            this.lblRubro.TabIndex = 7;
            this.lblRubro.Text = "Rubro";
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(494, 28);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(197, 21);
            this.cmbRubro.TabIndex = 2;
            this.cmbRubro.Text = "Rubro";
            // 
            // lblIngBrutos
            // 
            this.lblIngBrutos.AutoSize = true;
            this.lblIngBrutos.Location = new System.Drawing.Point(370, 99);
            this.lblIngBrutos.Name = "lblIngBrutos";
            this.lblIngBrutos.Size = new System.Drawing.Size(58, 13);
            this.lblIngBrutos.TabIndex = 9;
            this.lblIngBrutos.Text = "Ing. Brutos";
            // 
            // txtIngBrutos
            // 
            this.txtIngBrutos.Location = new System.Drawing.Point(494, 99);
            this.txtIngBrutos.Name = "txtIngBrutos";
            this.txtIngBrutos.Size = new System.Drawing.Size(197, 20);
            this.txtIngBrutos.TabIndex = 6;
            // 
            // lblIniActividades
            // 
            this.lblIniActividades.AutoSize = true;
            this.lblIniActividades.Location = new System.Drawing.Point(370, 134);
            this.lblIniActividades.Name = "lblIniActividades";
            this.lblIniActividades.Size = new System.Drawing.Size(105, 13);
            this.lblIniActividades.TabIndex = 11;
            this.lblIniActividades.Text = "Inicio de Actividades";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(494, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(138, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(316, 384);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(494, 384);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(138, 28);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(197, 21);
            this.cmbProveedores.TabIndex = 1;
            this.cmbProveedores.Text = "Proveedores";
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(32, 28);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 17;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblNombreFantasia
            // 
            this.lblNombreFantasia.AutoSize = true;
            this.lblNombreFantasia.Location = new System.Drawing.Point(370, 64);
            this.lblNombreFantasia.Name = "lblNombreFantasia";
            this.lblNombreFantasia.Size = new System.Drawing.Size(89, 13);
            this.lblNombreFantasia.TabIndex = 18;
            this.lblNombreFantasia.Text = "Nombre Fantasía";
            // 
            // txtNomFantasia
            // 
            this.txtNomFantasia.Location = new System.Drawing.Point(494, 64);
            this.txtNomFantasia.Name = "txtNomFantasia";
            this.txtNomFantasia.Size = new System.Drawing.Size(197, 20);
            this.txtNomFantasia.TabIndex = 4;
            // 
            // lblPuntoVenta
            // 
            this.lblPuntoVenta.AutoSize = true;
            this.lblPuntoVenta.Location = new System.Drawing.Point(32, 134);
            this.lblPuntoVenta.Name = "lblPuntoVenta";
            this.lblPuntoVenta.Size = new System.Drawing.Size(83, 13);
            this.lblPuntoVenta.TabIndex = 20;
            this.lblPuntoVenta.Text = "Punto De Venta";
            // 
            // txtPuntoVenta
            // 
            this.txtPuntoVenta.Location = new System.Drawing.Point(138, 134);
            this.txtPuntoVenta.Name = "txtPuntoVenta";
            this.txtPuntoVenta.Size = new System.Drawing.Size(197, 20);
            this.txtPuntoVenta.TabIndex = 7;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(370, 169);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 22;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(494, 169);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(197, 20);
            this.txtLocalidad.TabIndex = 10;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(32, 204);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 24;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(138, 204);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(197, 20);
            this.txtProvincia.TabIndex = 11;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(370, 204);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 26;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(494, 204);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(197, 20);
            this.txtCodPostal.TabIndex = 12;
            // 
            // lblDirFantasia
            // 
            this.lblDirFantasia.AutoSize = true;
            this.lblDirFantasia.Location = new System.Drawing.Point(32, 239);
            this.lblDirFantasia.Name = "lblDirFantasia";
            this.lblDirFantasia.Size = new System.Drawing.Size(97, 13);
            this.lblDirFantasia.TabIndex = 28;
            this.lblDirFantasia.Text = "Dirección Fantasía";
            // 
            // txtDirFantasia
            // 
            this.txtDirFantasia.Location = new System.Drawing.Point(138, 239);
            this.txtDirFantasia.Name = "txtDirFantasia";
            this.txtDirFantasia.Size = new System.Drawing.Size(197, 20);
            this.txtDirFantasia.TabIndex = 13;
            // 
            // lblLocFantasia
            // 
            this.lblLocFantasia.AutoSize = true;
            this.lblLocFantasia.Location = new System.Drawing.Point(370, 239);
            this.lblLocFantasia.Name = "lblLocFantasia";
            this.lblLocFantasia.Size = new System.Drawing.Size(98, 13);
            this.lblLocFantasia.TabIndex = 30;
            this.lblLocFantasia.Text = "Localidad Fantasía";
            // 
            // txtLocFantasia
            // 
            this.txtLocFantasia.Location = new System.Drawing.Point(494, 239);
            this.txtLocFantasia.Name = "txtLocFantasia";
            this.txtLocFantasia.Size = new System.Drawing.Size(197, 20);
            this.txtLocFantasia.TabIndex = 14;
            // 
            // lblProvFantasia
            // 
            this.lblProvFantasia.AutoSize = true;
            this.lblProvFantasia.Location = new System.Drawing.Point(32, 272);
            this.lblProvFantasia.Name = "lblProvFantasia";
            this.lblProvFantasia.Size = new System.Drawing.Size(96, 13);
            this.lblProvFantasia.TabIndex = 32;
            this.lblProvFantasia.Text = "Provincia Fantasía";
            // 
            // txtProvFantasia
            // 
            this.txtProvFantasia.Location = new System.Drawing.Point(138, 274);
            this.txtProvFantasia.Name = "txtProvFantasia";
            this.txtProvFantasia.Size = new System.Drawing.Size(197, 20);
            this.txtProvFantasia.TabIndex = 15;
            // 
            // lblCodPostalFantasia
            // 
            this.lblCodPostalFantasia.AutoSize = true;
            this.lblCodPostalFantasia.Location = new System.Drawing.Point(370, 274);
            this.lblCodPostalFantasia.Name = "lblCodPostalFantasia";
            this.lblCodPostalFantasia.Size = new System.Drawing.Size(106, 13);
            this.lblCodPostalFantasia.TabIndex = 34;
            this.lblCodPostalFantasia.Text = "Cod. Postal Fantasía";
            // 
            // txtCodPostalFantasia
            // 
            this.txtCodPostalFantasia.Location = new System.Drawing.Point(494, 274);
            this.txtCodPostalFantasia.Name = "txtCodPostalFantasia";
            this.txtCodPostalFantasia.Size = new System.Drawing.Size(197, 20);
            this.txtCodPostalFantasia.TabIndex = 16;
            // 
            // lblProveedorFactura
            // 
            this.lblProveedorFactura.AutoSize = true;
            this.lblProveedorFactura.Location = new System.Drawing.Point(32, 305);
            this.lblProveedorFactura.Name = "lblProveedorFactura";
            this.lblProveedorFactura.Size = new System.Drawing.Size(95, 13);
            this.lblProveedorFactura.TabIndex = 36;
            this.lblProveedorFactura.Text = "Proveedor Factura";
            // 
            // cmbProvFactura
            // 
            this.cmbProvFactura.FormattingEnabled = true;
            this.cmbProvFactura.Location = new System.Drawing.Point(138, 305);
            this.cmbProvFactura.Name = "cmbProvFactura";
            this.cmbProvFactura.Size = new System.Drawing.Size(197, 21);
            this.cmbProvFactura.TabIndex = 17;
            this.cmbProvFactura.Text = "Proveedor Factura";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(370, 305);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 37;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(494, 305);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(35, 342);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(33, 13);
            this.lblIVA.TabIndex = 38;
            this.lblIVA.Text = "I.V.A.";
            // 
            // mskIVA
            // 
            this.mskIVA.Location = new System.Drawing.Point(138, 342);
            this.mskIVA.Mask = "00.00%";
            this.mskIVA.Name = "mskIVA";
            this.mskIVA.Size = new System.Drawing.Size(197, 20);
            this.mskIVA.SkipLiterals = false;
            this.mskIVA.TabIndex = 39;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(373, 342);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(122, 23);
            this.btnGenerar.TabIndex = 40;
            this.btnGenerar.Text = "Generar Tickets";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 419);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.mskIVA);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cmbProvFactura);
            this.Controls.Add(this.lblProveedorFactura);
            this.Controls.Add(this.txtCodPostalFantasia);
            this.Controls.Add(this.lblCodPostalFantasia);
            this.Controls.Add(this.txtProvFantasia);
            this.Controls.Add(this.lblProvFantasia);
            this.Controls.Add(this.txtLocFantasia);
            this.Controls.Add(this.lblLocFantasia);
            this.Controls.Add(this.txtDirFantasia);
            this.Controls.Add(this.lblDirFantasia);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtPuntoVenta);
            this.Controls.Add(this.lblPuntoVenta);
            this.Controls.Add(this.txtNomFantasia);
            this.Controls.Add(this.lblNombreFantasia);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIniActividades);
            this.Controls.Add(this.txtIngBrutos);
            this.Controls.Add(this.lblIngBrutos);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.MaskedTextBox txtCUIT;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Label lblIngBrutos;
        private System.Windows.Forms.MaskedTextBox txtIngBrutos;
        private System.Windows.Forms.Label lblIniActividades;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblNombreFantasia;
        private System.Windows.Forms.TextBox txtNomFantasia;
        private System.Windows.Forms.Label lblPuntoVenta;
        private System.Windows.Forms.TextBox txtPuntoVenta;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblDirFantasia;
        private System.Windows.Forms.TextBox txtDirFantasia;
        private System.Windows.Forms.Label lblLocFantasia;
        private System.Windows.Forms.TextBox txtLocFantasia;
        private System.Windows.Forms.Label lblProvFantasia;
        private System.Windows.Forms.TextBox txtProvFantasia;
        private System.Windows.Forms.Label lblCodPostalFantasia;
        private System.Windows.Forms.TextBox txtCodPostalFantasia;
        private System.Windows.Forms.Label lblProveedorFactura;
        private System.Windows.Forms.ComboBox cmbProvFactura;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.MaskedTextBox mskIVA;
        private System.Windows.Forms.Button btnGenerar;
    }
}