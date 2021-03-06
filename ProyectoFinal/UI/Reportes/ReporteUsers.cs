﻿using ProyectoFinal.BLL;
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
    public partial class ReporteUsers : Form
    {
        List<Usuarios> list = new List<Usuarios>();
        public ReporteUsers(List<Usuarios> lista)
        {
            InitializeComponent();
            list = lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteUsuarios reporte = new ReporteUsuarios();
            reporte.SetDataSource(list);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }
    }
}
