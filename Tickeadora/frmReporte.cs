using System;
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
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

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

            GeneraQR(ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][15].ToString(), ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][8].ToString(), NombRep.Substring(NombRep.IndexOf(".rdlc") - 1, 1));

            if (ds.Tables[0].Rows.Count > 0)
            {
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsTicket", ds.Tables[0]));
                reportViewer1.LocalReport.ReportPath = Path.Combine(Application.StartupPath + "\\Reportes\\", NombRep);

                string ruta = Application.StartupPath + "\\Reportes\\QR.png";
                ReportParameter param = new ReportParameter("Path", @"file:" + ruta, true);
                reportViewer1.LocalReport.SetParameters(param);
            }

        }

        public void GeneraQR(string fecha, string cuit, string ptoVtaNComp, string total, string tipoComp)
        {
            string fechaJ = fecha.Substring(6) + "-" + fecha.Substring(3, 2) + "-" + fecha.Substring(0, 2);
            string cuitJ = cuit.Replace("-", string.Empty);
            int ptoVta = Convert.ToInt16(ptoVtaNComp.Substring(0, 5));
            Int64 nroComp = Convert.ToInt64(ptoVtaNComp.Substring(6));
            string tipoCompJ = string.Empty;
            string ver = "1";
            double tot = Convert.ToDouble(total);
            //total = total.Replace(",", ".");

            if (tipoComp == "A")
            {
                tipoCompJ = "81";
            }
            else
            {
                tipoCompJ = "82";
            }

            string moneda = "PES";
            string ctz = "1";
            string tipoCodAut = "E";
            string codAut = "70417054367476";
            //string jsonS = "{\"ver\":" + ver + ",\"fecha\":\"" + fechaJ + "\",\"cuit\":" + cuitJ + ",\"ptoVta\":" + ptoVta.ToString() + ",\"tipoCmp\":" + tipoCompJ + ",\"nroCmp\":\"" + nroComp.ToString() + "\",\"importe\":" + tot.ToString() + ",\"moneda\":\"" + moneda + "\",\"ctz\":" + ctz + ",\"tipoDocRec\":99,\"nroDocRec\":0,\"tipoCodAut\":\"" + tipoCodAut + "\",\"codAut\":" + codAut;
            string jsonS = "{\"ver\":" + ver + ",\"fecha\":\"" + fechaJ + "\",\"cuit\":" + cuitJ + ",\"ptoVta\":" + ptoVta.ToString() + ",\"tipoCmp\":" + tipoCompJ + ",\"nroCmp\":\"" + nroComp.ToString() + "\",\"importe\":" + tot.ToString() + ",\"moneda\":\"" + moneda + "\",\"ctz\":" + ctz + ",\"tipoCodAut\":\"" + tipoCodAut + "\",\"codAut\":" + codAut;
            string json64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonS));
            string url = "https://www.afip.gob.ar/fe/qr/?p=" + json64; //Se cambia por url fija
                                                                       //string url = "https://serviciosweb.afip.gob.ar/clavefiscal/qr/publicInfoD.aspx";
                                                                       //string url = "https://www.afip.gob.ar/landing/default.asp";
                                                                       //  http://qr.afip.gob.ar/?qr=

            /*
            eyJ2ZXIiOjEsImZlY2hhIjoiMjAyMi0wNy0yMCIsImN1aXQiOjMwNjc4Nzc0NDk1LCJwdG9WdGEiOjY0MDIsInRpcG9DbXAiOjYsIm5yb0NtcCI6IjU3OTAzIiwiaW1wb3J0ZSI6MjAwMCwibW9uZWRhIjoiUEVTIiwiY3R6IjoxLCJ0aXBvRG9jUmVjIjo5OSwibnJvRG9jUmVjIjowLCJ0aXBvQ29kQXV0IjoiRSIsImNvZEF1dCI6NzIyOTUzNTI4NzAyNjF9    --- original
            eyJ2ZXIiOjEsImZlY2hhIjoiMjAyMi0wNy0yMCIsImN1aXQiOjMwNjc4Nzc0NDk1LCJwdG9WdGEiOjY0MDIsInRpcG9DbXAiOjYsIm5yb0NtcCI6IjU3OTAzIiwiaW1wb3J0ZSI6MjAwMCwibW9uZWRhIjoiUEVTIiwiY3R6IjoxLCJ0aXBvRG9jUmVjIjo5OSwibnJvRG9jUmVjIjowLCJ0aXBvQ29kQXV0IjoiRSIsImNvZEF1dCI6NzIyOTUzNTI4NzAyNjF9

            {"ver":1,"fecha":"2022-07-20","cuit":30678774495,"ptoVta":6402,"tipoCmp":6,"nroCmp":"57903","importe":2000,"moneda":"PES","ctz":1,"tipoDocRec":99,"nroDocRec":0,"tipoCodAut":"E","codAut":72295352870261}
            */

            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();

            qrEncoder.TryEncode(url, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));

            string filePath = Path.Combine(Application.StartupPath + "\\Reportes", "QR.png");

            Image ImagenGrb = imagen;

            ImagenGrb.Save(filePath);
        }
    }
}