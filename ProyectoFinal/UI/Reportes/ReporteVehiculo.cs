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
    public partial class ReporteVehiculo : Form
    {
        List<Vehiculos> lista = new List<Vehiculos>();

        public ReporteVehiculo(List<Vehiculos> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteVehiculos reporte = new ReporteVehiculos();
            reporte.SetDataSource(lista);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }
    }
}
