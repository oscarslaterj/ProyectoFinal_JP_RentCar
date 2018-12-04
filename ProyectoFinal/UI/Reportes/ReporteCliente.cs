using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.UI.Reportes
{
    public partial class ReporteCliente : Form
    {
        List<Clientes> lista = new List<Clientes>();

        public ReporteCliente(List<Clientes> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteClientes reporte = new ReporteClientes();
            reporte.SetDataSource(lista);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }
    }
}
