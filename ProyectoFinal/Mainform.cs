using ProyectoFinal.UI.Consultas;
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
            rUsuarios registrousuarios = new rUsuarios();
            registrousuarios.MdiParent = this;
            registrousuarios.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes registroclientes = new rClientes();
            registroclientes.MdiParent = this;
            registroclientes.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos registrovehiculos = new rVehiculos();
            registrovehiculos.MdiParent = this;
            registrovehiculos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRenta registrorenta = new rRenta();
            registrorenta.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rMantenimiento registromantenimiento = new rMantenimiento();
            registromantenimiento.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios consultausuarios = new cUsuarios();
            consultausuarios.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes consultaclientes = new cClientes();
            consultaclientes.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVehiculos consultavehiculos = new cVehiculos();
            consultavehiculos.Show();
        }

        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cRenta consultarenta = new cRenta();
            consultarenta.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cMantenimiento  consultamantenimiento = new cMantenimiento();
            consultamantenimiento.Show();
        }
    }
}
