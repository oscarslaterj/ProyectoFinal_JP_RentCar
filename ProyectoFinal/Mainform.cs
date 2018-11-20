using ProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios r = new rUsuarios();
            r.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes c = new rClientes();
            c.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos v = new rVehiculos();
            v.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
