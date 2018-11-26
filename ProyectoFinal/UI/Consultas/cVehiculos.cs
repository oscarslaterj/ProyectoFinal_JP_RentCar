using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
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
        RepositorioBase<VehiculosDetalle> repositorio;
        public cVehiculos()
        {
            InitializeComponent();
            FiltroComboBox.SelectedIndex = 0;//Seleccionamos por default el Campo "Todos" de nuestro ComboBox
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


       /* private void Seleccion()
        {
            repositorio = new RepositorioBase<Vehiculos>();
            var lista = new List<Vehiculos>();
            ErrorProvider.Clear();
            if (CriterioTextBox.Text.Trim().Length >= 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        lista = repositorio.GetList(p => true);
                        break;
                    case 1: //Por ID
                        if (!Validar())
                            return;
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(p => p.VehiculoID == id);
                        break;
                    case 2://Por Marca
                        if (!Validar())
                            return;
                        lista = repositorio.GetList(p => p.Marca.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Por Precio
                        if (!Validar())
                            return;
                        Decimal precio = Convert.ToDecimal(CriterioTextBox.Text);
                        lista = repositorio.GetList(p => p.PrecioRenta == precio);
                        break;
                    case 4://Por Modelo
                        if (!Validar())
                            return;
                        lista = repositorio.GetList(p => p.Modelo.Contains(CriterioTextBox.Text));
                        break;
                    case 5: // Por Placa
                        if (!Validar())
                            return;
                        lista = repositorio.GetList(p => p.Placa.Contains(CriterioTextBox.Text));
                        break;
                }

                lista = lista.Where(c => c.FechaRegistro.Date >= DesdeDateTimePicker.Value.Date && c.FechaRegistro.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }*/

        private void BuscarButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
