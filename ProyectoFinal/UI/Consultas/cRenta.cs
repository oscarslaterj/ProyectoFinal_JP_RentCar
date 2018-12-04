using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Reportes;

namespace ProyectoFinal.UI.Consultas
{
    public partial class cRenta : Form
    {
        Expression<Func<Renta, bool>> filtro = x => true;
        public cRenta()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Renta> repositorioBase = new RepositorioBase<Renta>();

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Id                  
                    int id = (string.IsNullOrWhiteSpace(CriterioTextBox.Text)) ? 0 : Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => x.RentaId == id && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 1://Fecha devuelta     
                    DateTime fecha = (string.IsNullOrWhiteSpace(CriterioTextBox.Text)) ? DateTime.Now : DateTime.Parse(CriterioTextBox.Text);
                    filtro = x => x.FechaDevuelta.Equals(fecha) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                default:
                    filtro = x => true;
                    break;
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = repositorioBase.GetList(filtro);
            CriterioTextBox.Clear();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Renta> repositorio = new RepositorioBase<Renta>();
            ReporteRentaDetalle reporte = new ReporteRentaDetalle(repositorio.GetList(filtro));
            reporte.Show();
        }
    }
}
