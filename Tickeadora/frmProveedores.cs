using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickeadora
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void cargarCombos()
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "select * from Rubros order by rubro asc";

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);
            
            cmbRubro.DisplayMember = "rubro";
            cmbRubro.ValueMember = "idRubro";
            cmbRubro.DataSource = ds.Tables[0];

            sql = "select idProveedor, razonSocial from proveedores order by razonSocial asc";
            ds = new DataSet();
            da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            cmbProveedores.DisplayMember = "razonSocial";
            cmbProveedores.ValueMember = "idProveedor";
            cmbProveedores.DataSource = ds.Tables[0];

            sql = "select * from ProveedorFactura order by proveedorFactura asc";
            ds = new DataSet();
            da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            cmbProvFactura.DisplayMember = "proveedorFactura";
            cmbProvFactura.ValueMember = "idProveedorFactura";
            cmbProvFactura.DataSource = ds.Tables[0];

            

            dbConnection.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "insert into Proveedores (razonSocial, cuit, nombreFantasia, rubro, ingBrutos, iniActividad, direccion, localidad, provincia, codPostal, direccionFantasia, localidadFantasia, provinciaFantasia, codPostalFantasia, telefono, puntoVenta, proveedorFactura, iva)";
            sql = sql + " values ('" + txtRazonSocial.Text + "','" + txtCUIT.Text + "','" + txtNomFantasia.Text + "'," + cmbRubro.SelectedValue + ",'" + txtIngBrutos.Text + "','" + Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString() + "','" + txtDireccion.Text + "','" + txtLocalidad.Text + "','" + txtProvincia.Text + "','" + txtCodPostal.Text + "','" + txtDirFantasia.Text + "','" + txtLocFantasia.Text + "','" + txtProvFantasia.Text + "','" + txtCodPostalFantasia.Text + "','" + txtTelefono.Text + "','" + txtPuntoVenta.Text + "'," + cmbProvFactura.SelectedValue + "," + mskIVA.Text.Substring(0, mskIVA.Text.Length-1) + ")";

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "select * from Proveedores where idProveedor = " + cmbProveedores.SelectedValue;

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            txtRazonSocial.Text = ds.Tables[0].Rows[0]["razonSocial"].ToString();
            txtNomFantasia.Text = ds.Tables[0].Rows[0]["nombreFantasia"].ToString();
            txtCUIT.Text = ds.Tables[0].Rows[0]["cuit"].ToString();
            txtIngBrutos.Text = ds.Tables[0].Rows[0]["ingBrutos"].ToString();
            cmbRubro.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0]["rubro"].ToString());
            txtPuntoVenta.Text = ds.Tables[0].Rows[0]["puntoVenta"].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0]["iniActividad"].ToString(); 
            txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
            txtLocalidad.Text = ds.Tables[0].Rows[0]["localidad"].ToString();
            txtProvincia.Text = ds.Tables[0].Rows[0]["provincia"].ToString();
            txtCodPostal.Text = ds.Tables[0].Rows[0]["codPostal"].ToString();
            txtDirFantasia.Text = ds.Tables[0].Rows[0]["direccionFantasia"].ToString();
            txtLocFantasia.Text = ds.Tables[0].Rows[0]["localidadFantasia"].ToString();
            txtProvFantasia.Text = ds.Tables[0].Rows[0]["provinciaFantasia"].ToString();
            txtCodPostalFantasia.Text = ds.Tables[0].Rows[0]["codPostalFantasia"].ToString();
            //cmbProvFactura.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0]["proveedorFactura"].ToString());
            txtTelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
            mskIVA.Text = ds.Tables[0].Rows[0]["iva"].ToString(); //ds.Tables[0].Rows[0]["iva"].ToString("0.00%", CultureInfo.CreateSpecificCulture("ar-AR"));  //string.Format("##.00", ds.Tables[0].Rows[0]["iva"].ToString());

            dbConnection.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmGeneraTicket gt = new frmGeneraTicket();
            gt.cargaDatos(txtCUIT.Text, txtRazonSocial.Text, cmbProveedores.SelectedValue.ToString(),txtPuntoVenta.Text);
            gt.ShowDialog();
        }
    }
}
