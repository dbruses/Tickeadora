using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickeadora
{
    public partial class frmTickeadora : Form
    {
        public frmTickeadora()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores fProveedores = new frmProveedores();
            fProveedores.ShowDialog();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            frmTickets fTickets = new frmTickets();
            fTickets.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes fClientes = new frmClientes();
            fClientes.ShowDialog();
        }
    }
}
