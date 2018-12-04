using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Reportes;
using ProyectoFinal.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class cVehiculos : Form
    {
        Expression<Func<Vehiculos, bool>> filtro = x => true;
        public cVehiculos()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            if (CriterioTextBox.Text.FirstOrDefault() == '.')
                paso = false;
            if (String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                ErrorProvider.SetError(CriterioTextBox, "Debe poner Informacion en el campo");
                paso = false;
            }
            return paso;
        }


       private void Seleccion()
        {
            RepositorioBase<Vehiculos> repositorioBase = new RepositorioBase<Vehiculos>();
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Id                  
                    int id = (string.IsNullOrWhiteSpace(CriterioTextBox.Text)) ? 0 : Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => x.VehiculoId == id && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 1://Placa                  
                    filtro = x => x.Placa.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 2://Tipo                 
                    filtro = x => x.Tipo.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 3://Marca                  
                    filtro = x => x.Marca.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 4://Modelo                  
                    filtro = x => x.Modelo.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 5://Año                  
                    filtro = x => x.Anio.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 6://Descripcion                  
                    filtro = x => x.Descripcion.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                case 7://Marca             
                    decimal renta = (string.IsNullOrWhiteSpace(CriterioTextBox.Text)) ? 0 : decimal.Parse(CriterioTextBox.Text);
                    filtro = x => x.PrecioRenta <= renta && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;

                default:
                    filtro = x => true;
                    break;
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = repositorioBase.GetList(filtro);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Seleccion();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();
            ReporteVehiculo ventana = new ReporteVehiculo(repositorio.GetList(x => true));
            ventana.Show();
            
        }
    }
}
