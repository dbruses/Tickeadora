using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickeadora
{
    public partial class frmGeneraTicket : Form
    {
        string maxTicket = "";
        string maxFecha = "";

        public frmGeneraTicket()
        {
            InitializeComponent();
        }

        public void cargaDatos(string cuit, string rz, string idProveedor, string ptoVta)
        {
            lblCuit.Text = cuit;
            lblRazonSocial.Text = rz;
            lblIdProv.Text = idProveedor;
            lblPtoVta.Text = ptoVta;
            dtpHasta.Value = DateTime.Now;

            rdbA.Checked = true;

            verificaTickets(idProveedor);
        }

        private void verificaTickets(string idProveedor)
        {
            string tipo = "A";

            string idTkt = "";

            if(rdbB.Checked)
            {
                tipo = "B";
            }

            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "select MAX(idnroticket) from NrosTickets where idProveedor = " + idProveedor + " and tipoTkt = '" + tipo + "'";

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            idTkt = ds.Tables[0].Rows[0][0].ToString();

            if (idTkt != "")
            {
                sql = "select nroticket, MAX(fecha) from NrosTickets where idnroticket = " + idTkt;

                ds = new DataSet();
                da = new SQLiteDataAdapter(sql, dbConnection);
                da.Fill(ds);


                if (ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    lblInfo.Text = "Última fecha generada: " + ds.Tables[0].Rows[0][1].ToString() + "  -  " + ds.Tables[0].Rows[0][0].ToString();
                    maxTicket = ds.Tables[0].Rows[0][0].ToString();
                    maxFecha = ds.Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    lblInfo.Text = "No hay tickets generados para este proveedor.";
                }
            }
            else
            {
                lblInfo.Text = "No hay tickets generados para este proveedor.";
            }

            dbConnection.Close();
        }

        private void frmGeneraTicket_Load(object sender, EventArgs e)
        {

        }

        private void rdbB_CheckedChanged(object sender, EventArgs e)
        {
            verificaTickets(lblIdProv.Text);
        }

        private bool validaNro()
        {
            bool ok = false;

            int maxTkt = 0;
            DateTime maxFech;

            if (maxTicket != "")
            {
                maxTkt = Convert.ToInt32(maxTicket.Substring(maxTicket.IndexOf("-") + 1));
            }

            //Valido el nro
            if(maxTkt < Convert.ToInt32(txtNro.Text))
            {
                ok = true;
            }
            else
            {
                MessageBox.Show("El número a generar no debe ser menor o igual al último generado.");
                txtNro.Text = "";
                txtNro.Focus();
            }

            //Valido la fecha
            if (maxFecha != "")
            {
                maxFech = Convert.ToDateTime(maxFecha);
                if ((dtpDesde.Value > maxFech) && (ok))
                {
                    if (dtpHasta.Value <= dtpDesde.Value)
                    {
                        ok = false;
                        MessageBox.Show("La fecha Hasta no puede ser menor a la fecha Desde");
                    }
                }
                else
                {
                    if (ok)
                    {
                        MessageBox.Show("La fecha Desde no puede ser menor a la fecha de la última factura.");
                        ok = false;
                    }
                }
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int nroTkt = 0;

            if ((txtNro.Text != "") && (int.TryParse(txtNro.Text, out nroTkt)))
            {
                if (validaNro())
                {
                    int cantDia = 15;
                    int rnd = 60;
                    int rnd2 = 50;
                    string tipoTkt = "A";

                    if (rdbB.Checked)
                    {
                        cantDia = 50;
                        rnd = 8;
                        rnd2 = 100;
                        tipoTkt = "B";
                    }

                    Random r = new Random();

                    int newint = 0;
                    newint = r.Next(1, rnd);

                    DateTime fechaTkt = dtpDesde.Value;
                    fechaTkt = fechaTkt.Date;
                    fechaTkt = fechaTkt.AddHours(10);

                    //int nroTkt = Convert.ToInt32(txtNro.Text);

                    DateTime fechaFin = dtpHasta.Value; //new DateTime(2019, 12, 31);

                    SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
                    dbConnection.Open();

                    string sql = "";
                    string ntkt = "";

                    double pctGenerado = 0;
                    int cantAGenerar = 0;
                    //cantAGenerar = Convert.ToInt16(((fechaFin.Date - fechaTkt.Date).TotalDays * cantDia) / 100);
                    cantAGenerar = Convert.ToInt16((((fechaFin.Date - fechaTkt.Date).TotalDays + 1) * cantDia));

                    while (fechaTkt.Date <= fechaFin)
                    {
                        for (int i = 0; i < cantDia; i++)
                        {
                            fechaTkt = fechaTkt.AddMinutes(newint);
                            fechaTkt = fechaTkt.AddSeconds(r.Next(0, 59));

                            ntkt = Convert.ToInt16(lblPtoVta.Text).ToString("00000") + "-" + nroTkt.ToString("00000000");

                            sql = "insert into NrosTickets (idProveedor, fecha, hora, nroTicket, tipoTkt)";
                            sql = sql + " values (" + lblIdProv.Text + ",'" + fechaTkt.ToString("dd/MM/yyyy") + "','" + fechaTkt.ToString("HH:mm:ss") + "','" + ntkt + "','" + tipoTkt + "')";

                            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                            command.ExecuteNonQuery();

                            nroTkt = nroTkt + 1;
                            newint = r.Next(1, rnd);

                            if (cantAGenerar == pctGenerado)
                            {
                                pgbTickets.Increment(1);
                                lblInfo.Text = pgbTickets.Value.ToString() + " % Completedo";
                                pctGenerado = 1;
                            }
                            else
                            {
                                pctGenerado++;
                            }
                            //if (nroTkt >= 62245 )
                            //{
                            //    i = cantDia + 10;
                            //    fechaTkt = fechaFin.AddDays(10);
                            //}
                        }

                        //nroTkt = nroTkt + r.Next(10, rnd2);
                        fechaTkt = fechaTkt.AddDays(1);
                        fechaTkt = fechaTkt.Date;
                        fechaTkt = fechaTkt.AddHours(8);
                    }

                    dbConnection.Close();

                    pgbTickets.Value = 100;

                    MessageBox.Show("Último ticket " + tipoTkt + " generado: " + nroTkt.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de ticket válido.");
                txtNro.Text = "";
                txtNro.Focus();
            }
        }
    }
}
