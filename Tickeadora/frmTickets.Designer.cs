namespace Tickeadora
{
    partial class frmTickets
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblTxtCUIT = new System.Windows.Forms.Label();
            this.lblIngBtos = new System.Windows.Forms.Label();
            this.lblTxtIngBtos = new System.Windows.Forms.Label();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblITC = new System.Windows.Forms.Label();
            this.txtITC = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.cmbTicket = new System.Windows.Forms.ComboBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblIdProv = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblIVAProv = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.lblMontoNeto = new System.Windows.Forms.Label();
            this.lblMontoIVA = new System.Windows.Forms.Label();
            this.lblNoGravado = new System.Windows.Forms.Label();
            this.lblMontoNoGravado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblAjuste = new System.Windows.Forms.Label();
            this.txtAjuste = new System.Windows.Forms.TextBox();
            this.rdbDiesel = new System.Windows.Forms.RadioButton();
            this.rdbNafta = new System.Windows.Forms.RadioButton();
            this.gpbTipoCombustible = new System.Windows.Forms.GroupBox();
            this.lblValIngBtos = new System.Windows.Forms.Label();
            this.lblValorIngBtos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.gpbTipoCombustible.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(54, 33);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(134, 24);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(450, 21);
            this.cmbProveedores.TabIndex = 1;
            this.cmbProveedores.Text = "Proveedores";
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(57, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(134, 61);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(102, 20);
            this.dtFecha.TabIndex = 3;
            this.dtFecha.Value = new System.DateTime(2018, 2, 15, 0, 0, 0, 0);
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(258, 68);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(44, 13);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "C.U.I.T.";
            // 
            // lblTxtCUIT
            // 
            this.lblTxtCUIT.AutoSize = true;
            this.lblTxtCUIT.Location = new System.Drawing.Point(309, 68);
            this.lblTxtCUIT.Name = "lblTxtCUIT";
            this.lblTxtCUIT.Size = new System.Drawing.Size(0, 13);
            this.lblTxtCUIT.TabIndex = 5;
            // 
            // lblIngBtos
            // 
            this.lblIngBtos.AutoSize = true;
            this.lblIngBtos.Location = new System.Drawing.Point(437, 67);
            this.lblIngBtos.Name = "lblIngBtos";
            this.lblIngBtos.Size = new System.Drawing.Size(52, 13);
            this.lblIngBtos.TabIndex = 6;
            this.lblIngBtos.Text = "Ing. Btos.";
            // 
            // lblTxtIngBtos
            // 
            this.lblTxtIngBtos.AutoSize = true;
            this.lblTxtIngBtos.Location = new System.Drawing.Point(496, 68);
            this.lblTxtIngBtos.Name = "lblTxtIngBtos";
            this.lblTxtIngBtos.Size = new System.Drawing.Size(0, 13);
            this.lblTxtIngBtos.TabIndex = 7;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToOrderColumns = true;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.PrecioUnitario,
            this.Total});
            this.dgItems.Location = new System.Drawing.Point(25, 286);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(654, 150);
            this.dgItems.TabIndex = 8;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 87;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.Name = "Descripcion";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrecioUnitario.HeaderText = "PRECIO UNITARIO";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 116;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            this.Total.Width = 67;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(604, 23);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(54, 100);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(134, 100);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(450, 21);
            this.cmbClientes.TabIndex = 11;
            this.cmbClientes.Text = "Clientes";
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(604, 442);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblITC
            // 
            this.lblITC.AutoSize = true;
            this.lblITC.Location = new System.Drawing.Point(41, 176);
            this.lblITC.Name = "lblITC";
            this.lblITC.Size = new System.Drawing.Size(87, 13);
            this.lblITC.TabIndex = 13;
            this.lblITC.Text = "Var. Precio Bruto";
            // 
            // txtITC
            // 
            this.txtITC.Enabled = false;
            this.txtITC.Location = new System.Drawing.Point(134, 169);
            this.txtITC.Name = "txtITC";
            this.txtITC.Size = new System.Drawing.Size(100, 20);
            this.txtITC.TabIndex = 14;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(283, 215);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(32, 13);
            this.lblLitros.TabIndex = 15;
            this.lblLitros.Text = "Litros";
            // 
            // txtLitros
            // 
            this.txtLitros.Enabled = false;
            this.txtLitros.Location = new System.Drawing.Point(343, 207);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 20);
            this.txtLitros.TabIndex = 16;
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitros_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(456, 175);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(516, 169);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 18;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(57, 215);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(64, 13);
            this.lblCombustible.TabIndex = 19;
            this.lblCombustible.Text = "Combustible";
            // 
            // txtCombustible
            // 
            this.txtCombustible.Enabled = false;
            this.txtCombustible.Location = new System.Drawing.Point(134, 207);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(131, 20);
            this.txtCombustible.TabIndex = 20;
            this.txtCombustible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombustible_KeyPress);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(134, 137);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(65, 17);
            this.rdbA.TabIndex = 21;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "Ticket A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(237, 138);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(65, 17);
            this.rdbB.TabIndex = 22;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "Ticket B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // cmbTicket
            // 
            this.cmbTicket.Enabled = false;
            this.cmbTicket.FormattingEnabled = true;
            this.cmbTicket.Location = new System.Drawing.Point(400, 137);
            this.cmbTicket.Name = "cmbTicket";
            this.cmbTicket.Size = new System.Drawing.Size(216, 21);
            this.cmbTicket.TabIndex = 23;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(357, 140);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(37, 13);
            this.lblTicket.TabIndex = 24;
            this.lblTicket.Text = "Ticket";
            // 
            // lblIdProv
            // 
            this.lblIdProv.AutoSize = true;
            this.lblIdProv.Location = new System.Drawing.Point(555, 69);
            this.lblIdProv.Name = "lblIdProv";
            this.lblIdProv.Size = new System.Drawing.Size(35, 13);
            this.lblIdProv.TabIndex = 25;
            this.lblIdProv.Text = "label1";
            this.lblIdProv.Visible = false;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(258, 258);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(33, 13);
            this.lblIVA.TabIndex = 26;
            this.lblIVA.Text = "I.V.A.";
            // 
            // lblIVAProv
            // 
            this.lblIVAProv.AutoSize = true;
            this.lblIVAProv.Location = new System.Drawing.Point(297, 258);
            this.lblIVAProv.Name = "lblIVAProv";
            this.lblIVAProv.Size = new System.Drawing.Size(35, 13);
            this.lblIVAProv.TabIndex = 27;
            this.lblIVAProv.Text = "label1";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(22, 258);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(30, 13);
            this.lblNeto.TabIndex = 28;
            this.lblNeto.Text = "Neto";
            // 
            // lblMontoNeto
            // 
            this.lblMontoNeto.AutoSize = true;
            this.lblMontoNeto.Location = new System.Drawing.Point(59, 258);
            this.lblMontoNeto.Name = "lblMontoNeto";
            this.lblMontoNeto.Size = new System.Drawing.Size(35, 13);
            this.lblMontoNeto.TabIndex = 29;
            this.lblMontoNeto.Text = "label1";
            // 
            // lblMontoIVA
            // 
            this.lblMontoIVA.AutoSize = true;
            this.lblMontoIVA.Location = new System.Drawing.Point(338, 258);
            this.lblMontoIVA.Name = "lblMontoIVA";
            this.lblMontoIVA.Size = new System.Drawing.Size(35, 13);
            this.lblMontoIVA.TabIndex = 30;
            this.lblMontoIVA.Text = "label1";
            // 
            // lblNoGravado
            // 
            this.lblNoGravado.AutoSize = true;
            this.lblNoGravado.Location = new System.Drawing.Point(122, 258);
            this.lblNoGravado.Name = "lblNoGravado";
            this.lblNoGravado.Size = new System.Drawing.Size(65, 13);
            this.lblNoGravado.TabIndex = 31;
            this.lblNoGravado.Text = "No Gravado";
            // 
            // lblMontoNoGravado
            // 
            this.lblMontoNoGravado.AutoSize = true;
            this.lblMontoNoGravado.Location = new System.Drawing.Point(199, 258);
            this.lblMontoNoGravado.Name = "lblMontoNoGravado";
            this.lblMontoNoGravado.Size = new System.Drawing.Size(35, 13);
            this.lblMontoNoGravado.TabIndex = 32;
            this.lblMontoNoGravado.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(556, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(604, 257);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(35, 13);
            this.lblMontoTotal.TabIndex = 34;
            this.lblMontoTotal.Text = "label1";
            // 
            // lblAjuste
            // 
            this.lblAjuste.AutoSize = true;
            this.lblAjuste.Location = new System.Drawing.Point(258, 172);
            this.lblAjuste.Name = "lblAjuste";
            this.lblAjuste.Size = new System.Drawing.Size(74, 13);
            this.lblAjuste.TabIndex = 35;
            this.lblAjuste.Text = "Var. Ing. Btos.";
            // 
            // txtAjuste
            // 
            this.txtAjuste.Enabled = false;
            this.txtAjuste.Location = new System.Drawing.Point(335, 170);
            this.txtAjuste.Name = "txtAjuste";
            this.txtAjuste.Size = new System.Drawing.Size(100, 20);
            this.txtAjuste.TabIndex = 36;
            // 
            // rdbDiesel
            // 
            this.rdbDiesel.AutoSize = true;
            this.rdbDiesel.Location = new System.Drawing.Point(19, 19);
            this.rdbDiesel.Name = "rdbDiesel";
            this.rdbDiesel.Size = new System.Drawing.Size(54, 17);
            this.rdbDiesel.TabIndex = 37;
            this.rdbDiesel.TabStop = true;
            this.rdbDiesel.Text = "Diesel";
            this.rdbDiesel.UseVisualStyleBackColor = true;
            // 
            // rdbNafta
            // 
            this.rdbNafta.AutoSize = true;
            this.rdbNafta.Location = new System.Drawing.Point(128, 19);
            this.rdbNafta.Name = "rdbNafta";
            this.rdbNafta.Size = new System.Drawing.Size(51, 17);
            this.rdbNafta.TabIndex = 38;
            this.rdbNafta.TabStop = true;
            this.rdbNafta.Text = "Nafta";
            this.rdbNafta.UseVisualStyleBackColor = true;
            // 
            // gpbTipoCombustible
            // 
            this.gpbTipoCombustible.Controls.Add(this.rdbDiesel);
            this.gpbTipoCombustible.Controls.Add(this.rdbNafta);
            this.gpbTipoCombustible.Enabled = false;
            this.gpbTipoCombustible.Location = new System.Drawing.Point(449, 195);
            this.gpbTipoCombustible.Name = "gpbTipoCombustible";
            this.gpbTipoCombustible.Size = new System.Drawing.Size(200, 47);
            this.gpbTipoCombustible.TabIndex = 39;
            this.gpbTipoCombustible.TabStop = false;
            this.gpbTipoCombustible.Text = "Tipo Combustible";
            // 
            // lblValIngBtos
            // 
            this.lblValIngBtos.AutoSize = true;
            this.lblValIngBtos.Location = new System.Drawing.Point(389, 257);
            this.lblValIngBtos.Name = "lblValIngBtos";
            this.lblValIngBtos.Size = new System.Drawing.Size(52, 13);
            this.lblValIngBtos.TabIndex = 40;
            this.lblValIngBtos.Text = "Ing. Btos.";
            // 
            // lblValorIngBtos
            // 
            this.lblValorIngBtos.AutoSize = true;
            this.lblValorIngBtos.Location = new System.Drawing.Point(459, 256);
            this.lblValorIngBtos.Name = "lblValorIngBtos";
            this.lblValorIngBtos.Size = new System.Drawing.Size(35, 13);
            this.lblValorIngBtos.TabIndex = 41;
            this.lblValorIngBtos.Text = "label1";
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 477);
            this.Controls.Add(this.lblValorIngBtos);
            this.Controls.Add(this.lblValIngBtos);
            this.Controls.Add(this.gpbTipoCombustible);
            this.Controls.Add(this.txtAjuste);
            this.Controls.Add(this.lblAjuste);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMontoNoGravado);
            this.Controls.Add(this.lblNoGravado);
            this.Controls.Add(this.lblMontoIVA);
            this.Controls.Add(this.lblMontoNeto);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.lblIVAProv);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblIdProv);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.cmbTicket);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.txtCombustible);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.txtITC);
            this.Controls.Add(this.lblITC);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.lblTxtIngBtos);
            this.Controls.Add(this.lblIngBtos);
            this.Controls.Add(this.lblTxtCUIT);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.lblProveedor);
            this.Name = "frmTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.gpbTipoCombustible.ResumeLayout(false);
            this.gpbTipoCombustible.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblTxtCUIT;
        private System.Windows.Forms.Label lblIngBtos;
        private System.Windows.Forms.Label lblTxtIngBtos;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblITC;
        private System.Windows.Forms.TextBox txtITC;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.ComboBox cmbTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblIdProv;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblIVAProv;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label lblMontoNeto;
        private System.Windows.Forms.Label lblMontoIVA;
        private System.Windows.Forms.Label lblNoGravado;
        private System.Windows.Forms.Label lblMontoNoGravado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblAjuste;
        private System.Windows.Forms.TextBox txtAjuste;
        private System.Windows.Forms.RadioButton rdbDiesel;
        private System.Windows.Forms.RadioButton rdbNafta;
        private System.Windows.Forms.GroupBox gpbTipoCombustible;
        private System.Windows.Forms.Label lblValIngBtos;
        private System.Windows.Forms.Label lblValorIngBtos;
    }
}