﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Tickeadora
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void CargaDatos(string NombRep, int idTicket)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            //string sql = "select nroTicket, '' || fecha ||'' as fecha, subTotal, pctgIVA, montoIVA, total from Tickets where idTicket = " + idTicket;
            string sql = "select '' || ti.nroTicket ||'' as nroTicket, '' || ti.fecha ||'' as fecha, '' || ti.hora ||'' as hora, '' || ti.subTotal ||'' as subTotal, '' || ti.pctgIVA ||'' as pctgIVA, '' || ti.montoIVA ||'' as montoIVA,  '' || ti.noGravado ||'' as noGravado, '' || ti.ingBtos ||'' as valIngBtos, '' || ti.total ||'' as total, dt.detalle, '' || dt.cantidad ||'' as cantidad, '' || dt.precioUnitario ||'' as precioUnitario, '' || dt.precioNeto ||'' as precioNeto, '' || dt.totalItem ||'' as totalItem,";
            sql = sql + "pr.razonSocial, '' || pr.cuit ||'' as cuit, pr.nombreFantasia, '' || pr.ingBrutos ||'' as ingBrutos, '' || pr.iniActividad ||'' as iniActividad, pr.direccionFantasia,  pr.LocalidadFantasia, pr.provinciaFantasia, '' || pr.codPostalFantasia ||'' as codPostalFantasia, '' || pr.varIngBtos ||'' as varIngBtos,";
            sql = sql + "cl.razonSocial cliente, '' || cl.cuit ||'' as cuitCliente, cl.direccion direccionCliente, ti.cai cai ";
            sql = sql + "from Tickets ti inner join DetalleTicket dt on ti.idTicket = dt.idTicket ";
            sql = sql + "inner join Proveedores pr on ti.idProveedor = pr.idProveedor inner join Clientes cl on ti.idCliente = cl.idCliente where ti.idTicket = " + idTicket;

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            //string ctrl = ds.Tables[0].Rows[0]["Fecha"].ToString().Substring(0, 2) + ds.Tables[0].Rows[0]["Fecha"].ToString().Substring(3, 2) + ds.Tables[0].Rows[0]["Fecha"].ToString().Substring(8, 2) + " " + ds.Tables[0].Rows[0]["Hora"].ToString().Substring(0, 2) + ds.Tables[0].Rows[0]["Hora"].ToString().Substring(3, 2) + " 0240 005 020748";
            //ctrl = ctrl.Substring(0, 2);

            if (ds.Tables[0].Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsTicket", ds.Tables[0]));
                reportViewer1.LocalReport.ReportPath = Path.Combine(Application.StartupPath + "\\Reportes\\", NombRep);
            }
                
        }
    }
}