using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
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
using ProyectoFinal.UI.Reportes;

namespace ProyectoFinal.UI.Consultas
{
    public partial class cClientes : Form
    {

        Expression<Func<Clientes, bool>> filtro = x => true;
       
        public cClientes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorioBase = new RepositorioBase<Clientes>();

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Id                  
                    int id = (string.IsNullOrWhiteSpace(CriterioTextBox.Text)) ? 0 : Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => x.ClienteId == id && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;
                        
                case 1://nombre        
                    filtro = x => x.Nombre.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;
                        
                case 2: //Cedula   
                    filtro = x => x.Cedula.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
                    break;
    
                case 3://Direccion
                    filtro = x => x.Direccion.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));                       
                    break;

                case 4://Telefono                            
                    filtro = x => x.Telefono.Contains(CriterioTextBox.Text) && ((x.FechaRegistro >= DesdeDateTimePicker.Value) && (x.FechaRegistro <= HastaDateTimePicker.Value));
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
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            ReporteCliente reporte = new ReporteCliente(repositorio.GetList(filtro));
            reporte.Show();
        }
    }
}
