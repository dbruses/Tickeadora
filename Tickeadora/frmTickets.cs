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
    public partial class frmTickets : Form
    {
        string reporte = "";

        public frmTickets()
        {
            InitializeComponent();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            cargarCombos();
            limpiaPantalla();
            dtFecha.Text = DateTime.Today.ToShortDateString();
        }

        private void limpiaPantalla()
        {
            lblMontoIVA.Text = "";
            lblMontoNeto.Text = "";
            lblMontoNoGravado.Text = "";
            lblMontoTotal.Text = "";
            lblValorIngBtos.Text = "";
            dgItems.Rows.Clear();
        }

        private void cargarCombos()
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            DataSet ds = new DataSet();

            //Proveedores
            string sql = "select p.idProveedor, p.nombreFantasia || ' | ' ||  r.rubro || ' | ' ||  pf.proveedorFactura || ' | ' || P.tipoEstacion as descripcion from proveedores P inner join rubros r on p.rubro = r.idRubro inner join ProveedorFactura pf on p.proveedorfactura = pf.idProveedorFactura order by p.nombreFantasia asc";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = 0;
            dr[1] = "Proveedores";

            ds.Tables[0].Rows.InsertAt(dr, 0);

            cmbProveedores.DisplayMember = "descripcion";
            cmbProveedores.ValueMember = "idProveedor";
            cmbProveedores.DataSource = ds.Tables[0];

            //Clientes
            sql = "select c.idCliente, c.razonSocial || ' | ' ||  c.cuit as descripcion from clientes c order by razonSocial asc";
            ds = new DataSet();
            da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            dr = ds.Tables[0].NewRow();
            dr[0] = 0;
            dr[1] = "Clientes";

            ds.Tables[0].Rows.InsertAt(dr, 0);

            cmbClientes.DisplayMember = "descripcion";
            cmbClientes.ValueMember = "idCliente";
            cmbClientes.DataSource = ds.Tables[0];

            dbConnection.Close();

            rdbA.Checked = true;
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "select idProveedor, cuit, ingBrutos, rtrim(iva) iva, rtrim(varPrecioBto) varPrecioBto, rtrim(varIngBtos) varIngBtos, reporte from proveedores where idProveedor = " + cmbProveedores.SelectedValue.ToString();

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                lblTxtCUIT.Text = row["cuit"].ToString();
                lblTxtIngBtos.Text = row["ingBrutos"].ToString();
                lblIdProv.Text = row["idProveedor"].ToString();
                //lblIVAProv.Text = string.Format("{0:F2}", row["iva"].ToString()) + " %";
                lblIVAProv.Text = row["iva"].ToString() + " %";
                //txtITC.Text = string.Format("{0:F4}", row["itc"].ToString());
                txtITC.Text = row["varPrecioBto"].ToString();
                txtAjuste.Text = row["varIngBtos"].ToString();
                reporte = row["reporte"].ToString();
                cargarTickets();
            }
            else
            {
                lblTxtCUIT.Text = "";
                lblTxtIngBtos.Text = "";
                lblIdProv.Text = "";
                lblIVAProv.Text = "";
                txtITC.Text = "";
                txtAjuste.Text = "";
            }
            

            dbConnection.Close();

            //HabilitaComb();

            if ((cmbProveedores.SelectedValue.ToString() != "0") && (cmbClientes.SelectedValue.ToString() != "0"))
            {
                btnNuevo.Enabled = true;
            }
            else
            {
                btnNuevo.Enabled = false;
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HabilitaComb();

            if ((cmbProveedores.SelectedValue.ToString() != "0") && (cmbClientes.SelectedValue.ToString() != "0"))
            {
                btnNuevo.Enabled = true;
            }
            else
            {
                btnNuevo.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitaComb();
        }

        private void HabilitaComb()
        {
            if ((cmbClientes.SelectedIndex != 0) && (cmbProveedores.SelectedIndex != 0))
            {
                int comb = cmbProveedores.Text.IndexOf("Combustible", 0);

                if (comb > 0)
                {
                    txtCombustible.Enabled = true;
                    //txtITC.Enabled = true;
                    txtLitros.Enabled = true;
                    txtPrecio.Enabled = true;
                    gpbTipoCombustible.Enabled = true;
                    rdbDiesel.Checked = true;
                    //btnGrabar.Enabled = true;
                }
                else
                {
                    txtCombustible.Enabled = false;
                    txtITC.Enabled = false;
                    txtAjuste.Enabled = false;
                    txtLitros.Enabled = false;
                    txtPrecio.Enabled = false;
                    gpbTipoCombustible.Enabled = false;
                    btnGrabar.Enabled = false;

                    dgItems.Enabled = true;
                    dgItems.Focus();

                    btnGrabar.Enabled = true;

                }

                cmbTicket.Enabled = true;
                btnNuevo.Enabled = false;
            }
            else
            {
                txtCombustible.Enabled = false;
                txtITC.Enabled = false;
                txtAjuste.Enabled = false;
                txtLitros.Enabled = false;
                txtPrecio.Enabled = false;

                btnGrabar.Enabled = false;

                cmbTicket.Enabled = false;

                btnNuevo.Enabled = true;
            }
        }

        public void grabaTkt()
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            int comb = cmbProveedores.Text.IndexOf("Combustible", 0);

            string sql = "";

            string nroTkt = cmbTicket.Text.Substring(0, cmbTicket.Text.IndexOf("|")-1);
            string hora = cmbTicket.Text.Substring(cmbTicket.Text.IndexOf("|", 20) + 2, 8);

            double neto = 0;
            double montoIVA = 0;
            double total = 0;
            double iva = Convert.ToDouble(lblIVAProv.Text.Substring(0, lblIVAProv.Text.IndexOf("%") - 1));

            int idTkt = 0; //Convert.ToInt32(row[0].ToString());

            SQLiteCommand command;

            if (comb > 0)
            {
                //Insert Ticket
                sql = "insert into Tickets (idProveedor, idCliente, fecha, hora, nroTicket, subTotal, pctgIVA, montoIVA, total, noGravado, ingBtos)";
                sql = sql + " values (" + cmbProveedores.SelectedValue + "," + cmbClientes.SelectedValue + ",'" + dtFecha.Value.ToString("dd/MM/yyyy") + "','" + hora + "','" + nroTkt + "','" + lblMontoNeto.Text + "','" + iva.ToString() + "','" + lblMontoIVA.Text + "','" + lblMontoTotal.Text + "','" + lblMontoNoGravado.Text + "','" + lblValorIngBtos.Text + "')";

                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                idTkt = UltimoTkt();

                //Insert Detalle
                sql = "insert into DetalleTicket (idTicket, detalle, cantidad, precioUnitario, precioNeto, totalItem)";
                sql = sql + " values (" + idTkt.ToString() + ",'" + txtCombustible.Text + "','" + txtLitros.Text + "','" + txtPrecio.Text + "','" + lblMontoNeto.Text + "','" + lblMontoTotal.Text + "')";

                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
            }
            else
            {
                //Insert Ticket
                sql = "insert into Tickets (idProveedor, idCliente, fecha, hora, nroTicket, subTotal, pctgIVA, montoIVA, total, noGravado, ingBtos)";
                sql = sql + " values (" + cmbProveedores.SelectedValue + "," + cmbClientes.SelectedValue + ",'" + dtFecha.Value.ToString("dd/MM/yyyy") + "','" + hora + "','" + nroTkt + "','','" + iva.ToString("0,00") + "','','','0','0')";

                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                idTkt = UltimoTkt();

                //Insert Detalle
                foreach (DataGridViewRow dg in dgItems.Rows)
                {
                    if ( dg.Cells[1].Value != null)
                    {
                        string pu = dg.Cells[2].Value.ToString();
                        string pn = dg.Cells[2].Value.ToString();
                        string ti = dg.Cells[3].Value.ToString();

                        sql = "insert into DetalleTicket (idTicket, detalle, cantidad, precioUnitario, precioNeto, totalItem)";
                        sql = sql + " values (" + idTkt.ToString() + ",'" + dg.Cells[1].Value + "','" + dg.Cells[0].Value + "','" + pu + "','" + pn + "','" + ti + "')";

                        command = new SQLiteCommand(sql, dbConnection);
                        command.ExecuteNonQuery();

                        neto = neto + Convert.ToDouble(dg.Cells[3].Value);
                    }
                }

                if (rdbA.Checked)
                {
                    montoIVA = Math.Round(Convert.ToDouble(neto * iva / 100), 2);
                }
                    
                total = Math.Round(Convert.ToDouble(neto + montoIVA), 2);

                //sql = "update Tickets set subTotal = '" + neto.ToString() + "', montoIVA ='" + montoIVA.ToString() + "', total='" + total.ToString() + "' ";
                sql = "update Tickets set subTotal = '" + String.Format("{0:0.00}", neto) + "', montoIVA ='" + String.Format("{0:0.00}", montoIVA) + "', total='" + String.Format("{0:0.00}", total) + "' ";
                sql = sql + "where idTicket = " + idTkt.ToString();

                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
            }
                

            //Update NrosTickets
            sql = "update NrosTickets";
            sql = sql + " set utilizado = 'S' where idNroTicket = " + cmbTicket.SelectedValue;

            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public int UltimoTkt()
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            //Obtengo el último Id
            DataSet ds = new DataSet();

            string sql = "select max(idTicket) from Tickets";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            DataRow row = ds.Tables[0].Rows[0];

            int idTkt = Convert.ToInt32(row[0].ToString());
            dbConnection.Close();
            return idTkt;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGrabar.Enabled = false;

            if (cmbTicket.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un Número de Ticket.");
                cmbTicket.Focus();
            }
            else
            {
                grabaTkt();

                string nomRep = reporte;

                if (rdbA.Checked)
                {
                    nomRep = nomRep + "A";
                }
                else
                {
                    nomRep = nomRep + "B";
                }

                nomRep=nomRep + ".rdlc";

                frmReporte fReport = new frmReporte();
                int idTkt = UltimoTkt(); //Convert.ToInt32(cmbTicket.SelectedValue);
                fReport.CargaDatos(nomRep, idTkt);
                fReport.ShowDialog();
            }

            cargarCombos();
            limpiaPantalla();
            cmbTicket.SelectedIndex = 0;
            cmbTicket.Enabled = false;
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            if (lblIdProv.Text != "")
            {
                cargarTickets();
            }
        }

        public void cargarTickets()
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            DataSet ds = new DataSet();

            string tFact = string.Empty;
            if (rdbA.Checked)
            {
                tFact = "A";
            }
            else
            {
                tFact = "B";
            }

            //Proveedores
            string sql = "select idNroTicket, nroTicket || ' | ' || fecha || ' | ' || hora as tkt from NrosTickets where fecha = '" + dtFecha.Value.Date.ToString("dd/MM/yyyy") +  "' and idProveedor = " + lblIdProv.Text + " and utilizado = 'N' and tipoTkt = '" + tFact + "' order by nroTicket asc";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = 0;
            dr[1] = "Tickets";

            ds.Tables[0].Rows.InsertAt(dr, 0);

            cmbTicket.DisplayMember = "tkt";
            cmbTicket.ValueMember = "idNroTicket";
            cmbTicket.DataSource = ds.Tables[0];

            dbConnection.Close();
        }

       private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                double lts;

                string s = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

                string valor = "";
                bool tieneComa = false;
                bool tienePunto = false;
                bool cambiaDecimal = false;

                if (e.KeyChar == (char)13)
                {
                    if (txtLitros.Text.IndexOf(",") > 0)
                    {
                        tieneComa = true;
                    }
                    if (txtLitros.Text.IndexOf(".") > 0)
                    {
                        tienePunto = true;
                    }

                    if (tieneComa && s==".")
                    {
                        cambiaDecimal = true;
                    }

                    if (tienePunto && s == ",")
                    {
                        cambiaDecimal = true;
                    }

                    if (cambiaDecimal)
                    {
                        if (tieneComa)
                        {
                            valor=txtLitros.Text.Replace(",", ".");
                        }
                        else
                        {
                            valor=txtLitros.Text.Replace(".", ",");
                        }
                    }
                    else
                    {
                        valor = txtLitros.Text;
                    }

                    lts = Convert.ToDouble(valor);
                    txtLitros.Text = valor;
                    calculaTotales();
                    //txtPrecio.Focus();
                    btnGrabar.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar un número válido.");
                txtLitros.Text = "";
                txtLitros.Focus();
            }
        }

        public void calculaTotales()
        {
            if ((txtCombustible.Text != "") && (txtLitros.Text != "") && (txtPrecio.Text != "") && (txtITC.Text != ""))
            //if ((txtCombustible.Text != "") && (txtLitros.Text != "") && (txtPrecio.Text != ""))
            {
                //No gravado = (lts x ipc) + (lts x 2,27)
                //Subtotal = (lts x $) - No Gravado /1,21
                //IVA = Subtotal x 0.21
                //total = Subtotal + No Gravado + IVA
                double noGravado = 0;
                double subtotal = 0;
                double iva = 0;
                double total = 0;
                double precioXLitro = 0;
                double ingBtos = 0;

                double lts = Convert.ToDouble(txtLitros.Text);
                double varPrecioBruto = Convert.ToDouble(txtITC.Text);
                double varIngBto = Convert.ToDouble(txtAjuste.Text);
                double valIVA = Convert.ToDouble(lblIVAProv.Text.Substring(0,lblIVAProv.Text.IndexOf(" ")));
                double precio = Convert.ToDouble(txtPrecio.Text);
                
                //noGravado = (lts * itc) + (lts * 2.27);
                //subtotal = ((lts * precio) - noGravado) / 1.21;
                if (rdbA.Checked)
                {
                    //precioXLitro = precio * 0.6472369727;
                    //precioXLitro = precio * varPrecioBruto;
                    //precioXLitro = precio;
                    
                    
                    //Calculo IngBtos
                    SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
                    dbConnection.Open();

                    DataSet ds = new DataSet();

                    string sql = "select percIngBtos, NoGrabado from Proveedores where idProveedor = " + cmbProveedores.SelectedValue.ToString();

                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
                    da.Fill(ds);

                    DataRow row = ds.Tables[0].Rows[0];

                    string ib = row[0].ToString();
                    double pctNoGrabado = 0;
                    if (!string.IsNullOrEmpty(row[1].ToString()))
                    {
                        //pctNoGrabado = Convert.ToDouble(row[1].ToString().Replace(",","."));
                        pctNoGrabado = Convert.ToDouble(row[1].ToString());
                    }

                    precioXLitro = precio / (1.21 + (pctNoGrabado / 100));
                    subtotal = lts * precioXLitro;

                    dbConnection.Close();

                    if (ib == "S")
                    {
                        ingBtos = subtotal / varIngBto;
                        ingBtos = Convert.ToDouble(ingBtos.ToString("#####.00"));
                    }

                    // Calculo el no grabado (ITC) de acurdo al tipo de nafta y la fecha
                    //noGravado = subtotal * 0.3350187;
                    noGravado = subtotal * pctNoGrabado / 100; // calculaITC() * lts;//PARA REVISAR CALCULO ITC
                    subtotal = Convert.ToDouble(subtotal.ToString("#####.00"));
                    iva = subtotal * valIVA / 100;
                    iva = Convert.ToDouble(iva.ToString("#####.00"));
                    noGravado = Convert.ToDouble(noGravado.ToString("#####.00"));
                }
                else
                {
                    precioXLitro = precio;
                    subtotal = lts * precioXLitro;
                }
                //total = subtotal + noGravado + iva + ingBtos;
                total = Convert.ToDouble(subtotal.ToString("#####.00")) + Convert.ToDouble(noGravado.ToString("#####.00")) + Convert.ToDouble(iva.ToString("#####.00")) + Convert.ToDouble(ingBtos.ToString("#####.00"));
                lblMontoNeto.Text = subtotal.ToString("#####.00");
                lblMontoNoGravado.Text = noGravado.ToString("#####.00");
                lblMontoTotal.Text = total.ToString("#####.00");
                lblMontoIVA.Text = iva.ToString("#####.00");
                lblValorIngBtos.Text = ingBtos.ToString("#####.00");
            }
        }

        public double calculaITC()
        {
            double itc = 0;

            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string tipoComb = "";

            if (rdbDiesel.Checked)
            {
                tipoComb = "Gasoil";
            }
            else
            {
                tipoComb = "Nafta";
            }

            //Obtengo el último Id
            DataSet ds = new DataSet();

            string sql = "select rtrim(valor) valor from itc where tipoCombustible = '" + tipoComb + "' and '" + dtFecha.Value.ToShortDateString() + "' between desde and hasta";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            DataRow row = ds.Tables[0].Rows[0];

            itc = Convert.ToDouble(row[0].ToString());
            dbConnection.Close();

            return itc;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                double pesos;

                string s = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

                string valor = "";
                bool tieneComa = false;
                bool tienePunto = false;
                bool cambiaDecimal = false;

                if (e.KeyChar == (char)13)
                {
                    if (txtPrecio.Text.IndexOf(",") > 0)
                    {
                        tieneComa = true;
                    }
                    if (txtPrecio.Text.IndexOf(".") > 0)
                    {
                        tienePunto = true;
                    }

                    if (tieneComa && s == ".")
                    {
                        cambiaDecimal = true;
                    }

                    if (tienePunto && s == ",")
                    {
                        cambiaDecimal = true;
                    }

                    if (cambiaDecimal)
                    {
                        if (tieneComa)
                        {
                            valor = txtPrecio.Text.Replace(",", ".");
                        }
                        else
                        {
                            valor = txtPrecio.Text.Replace(".", ",");
                        }
                    }
                    else
                    {
                        valor = txtPrecio.Text;
                    }

                    pesos = Convert.ToDouble(valor);
                    txtPrecio.Text = valor;
                    calculaTotales();
                    txtCombustible.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar un número válido.");
                txtPrecio.Text = "";
                txtPrecio.Focus();
            }
        }

        private void txtCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if ((txtCombustible.Text != "") && (txtLitros.Text != "") && (txtPrecio.Text != "") && (txtITC.Text != ""))
                {
                    calculaTotales();
                    btnGrabar.Enabled = true;
                }
                else
                {
                    btnGrabar.Enabled = false;
                }
                txtLitros.Focus();
            }
        }
    }
} 
