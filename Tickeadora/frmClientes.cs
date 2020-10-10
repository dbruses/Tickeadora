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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void cargarCombos()
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "select * from Clientes order by razonSocial asc";

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            cmbCliente.DisplayMember = "razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = ds.Tables[0];

            dbConnection.Close();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string sql = "select * from Clientes where idCliente = " + cmbCliente.SelectedValue;

            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConnection);
            da.Fill(ds);

            txtRazonSocial.Text = ds.Tables[0].Rows[0]["razonSocial"].ToString();
            txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
            txtCuit.Text = ds.Tables[0].Rows[0]["cuit"].ToString();

            string tipoIva = ds.Tables[0].Rows[0]["tipoIVA"].ToString();

            switch (tipoIva)
            {
                case "RI":
                    rbRI.Select();
                    break;
                case "RNI":
                    rbRNI.Select();
                    break;
                case "EX":
                    rbEX.Select();
                    break;
            }

            dbConnection.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiaPantalla();
        }

        public void limpiaPantalla()
        {
            txtCuit.Text = "";
            txtDireccion.Text = "";
            txtRazonSocial.Text = "";
            rbRI.Select();

            txtRazonSocial.Focus();
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Tickets.db;");
            dbConnection.Open();

            string tipoIva = "";

            if (rbRI.Checked)
            {
                tipoIva = "RI";
            }
            if (rbRNI.Checked)
            {
                tipoIva = "RNI";
            }
            if (rbEX.Checked)
            {
                tipoIva = "EX";
            }

            string sql = "insert into Clientes (razonSocial, cuit, direccion, tipoiva)";
            sql = sql + " values ('" + txtRazonSocial.Text + "','" + txtCuit.Text + "','" + txtDireccion.Text + "','" + tipoIva + "')";

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();

            btnGuardar.Enabled = false;

            MessageBox.Show("Datos guardados correctamente.");
        }
    }
}
