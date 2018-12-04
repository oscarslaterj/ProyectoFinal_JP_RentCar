using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Reportes;
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

namespace ProyectoFinal.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        
        Expression<Func<Usuarios, bool>> filtro = x => true;
        public cUsuarios()
        {
            InitializeComponent();
         
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioBase = new RepositorioBase<Usuarios>();
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Id                  
                    int id = (string.IsNullOrWhiteSpace(CriterioTextBox.Text)) ? 0 : Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => x.UsuarioId == id && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
                    break;

                case 1://Nombre                  
                    filtro = x => x.Nombre.Contains(CriterioTextBox.Text) && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
                    break;

                case 2://Nombre usuario                  
                    filtro = x => x.NombreUser.Contains(CriterioTextBox.Text) && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
                    break;

                case 3://Clave                  
                    filtro = x => x.Clave.Contains(CriterioTextBox.Text) && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
                    break;

                case 4://Nivel de acceso      
                    filtro = x => x.NivelAcceso.Equals(CriterioTextBox.Text) && ((x.Fecha >= DesdeDateTimePicker.Value) && (x.Fecha <= HastaDateTimePicker.Value));
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
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            ReporteUsers reporte = new ReporteUsers(repositorio.GetList(filtro));
            reporte.Show();
        }
    }
}
    
