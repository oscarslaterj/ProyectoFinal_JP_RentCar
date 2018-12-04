using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes
{
    public partial class ReporteRentaDetalle : Form
    {
        List<Renta> data = new List<Renta>();

        public ReporteRentaDetalle()
        {
        }

        public ReporteRentaDetalle(List<Renta> lista)
        {
            InitializeComponent();
            data = lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteRenta reporteRenta = new ReporteRenta();
            reporteRenta.SetDataSource(data);
            crystalReportViewer1.ReportSource = reporteRenta;
            crystalReportViewer1.Refresh();
        }
    }
}
