namespace Tickeadora
{
    partial class frmGeneraTicket
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
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblIdProv = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFDesde = new System.Windows.Forms.Label();
            this.lblFHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblPtoVta = new System.Windows.Forms.Label();
            this.pgbTickets = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(59, 28);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(193, 28);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(22, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "RZ";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(133, 69);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(133, 114);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 20);
            this.txtNro.TabIndex = 3;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(46, 121);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(60, 13);
            this.lblNro.TabIndex = 4;
            this.lblNro.Text = "Nro. Ticket";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(275, 195);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblIdProv
            // 
            this.lblIdProv.AutoSize = true;
            this.lblIdProv.Location = new System.Drawing.Point(440, 27);
            this.lblIdProv.Name = "lblIdProv";
            this.lblIdProv.Size = new System.Drawing.Size(37, 13);
            this.lblIdProv.TabIndex = 6;
            this.lblIdProv.Text = "idProv";
            this.lblIdProv.Visible = false;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(299, 119);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(65, 17);
            this.rdbA.TabIndex = 7;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "Ticket A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(443, 119);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(65, 17);
            this.rdbB.TabIndex = 8;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "Ticket B";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.CheckedChanged += new System.EventHandler(this.rdbB_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(193, 169);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "label1";
            // 
            // lblFDesde
            // 
            this.lblFDesde.AutoSize = true;
            this.lblFDesde.Location = new System.Drawing.Point(46, 75);
            this.lblFDesde.Name = "lblFDesde";
            this.lblFDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFDesde.TabIndex = 10;
            this.lblFDesde.Text = "Fecha Desde";
            // 
            // lblFHasta
            // 
            this.lblFHasta.AutoSize = true;
            this.lblFHasta.Location = new System.Drawing.Point(282, 74);
            this.lblFHasta.Name = "lblFHasta";
            this.lblFHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFHasta.TabIndex = 11;
            this.lblFHasta.Text = "Fecha Hasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(381, 68);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(96, 20);
            this.dtpHasta.TabIndex = 12;
            this.dtpHasta.Value = new System.DateTime(2020, 9, 2, 7, 42, 36, 0);
            // 
            // lblPtoVta
            // 
            this.lblPtoVta.AutoSize = true;
            this.lblPtoVta.Location = new System.Drawing.Point(521, 27);
            this.lblPtoVta.Name = "lblPtoVta";
            this.lblPtoVta.Size = new System.Drawing.Size(38, 13);
            this.lblPtoVta.TabIndex = 13;
            this.lblPtoVta.Text = "ptoVta";
            this.lblPtoVta.Visible = false;
            // 
            // pgbTickets
            // 
            this.pgbTickets.Location = new System.Drawing.Point(49, 226);
            this.pgbTickets.Name = "pgbTickets";
            this.pgbTickets.Size = new System.Drawing.Size(510, 23);
            this.pgbTickets.TabIndex = 14;
            // 
            // frmGeneraTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 261);
            this.Controls.Add(this.pgbTickets);
            this.Controls.Add(this.lblPtoVta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblFHasta);
            this.Controls.Add(this.lblFDesde);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.lblIdProv);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Name = "frmGeneraTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Tickets";
            this.Load += new System.EventHandler(this.frmGeneraTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblIdProv;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFDesde;
        private System.Windows.Forms.Label lblFHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblPtoVta;
        private System.Windows.Forms.ProgressBar pgbTickets;
    }
}