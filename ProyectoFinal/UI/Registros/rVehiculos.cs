using ProyectoFinal.BLL;
using ProyectoFinal.DAL;
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

namespace ProyectoFinal.UI.Registros
{
    public partial class rVehiculos : Form
    {
        RepositorioBase<Vehiculos> repositorio;
        public rVehiculos()
        {
            InitializeComponent();
            
        }


        private void Limpiar()
        {
            VehiculoNumericUpDown.Value = 0;
            ModeloTextBox.Text = string.Empty;
            PrecioTextBox.Text= string.Empty;
            TipoComboBox.Items.Clear();
            MarcaTextBox.Text = string.Empty;
            PlacaTextBox.Text = string.Empty;
            AnioTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
        }


    }
}
