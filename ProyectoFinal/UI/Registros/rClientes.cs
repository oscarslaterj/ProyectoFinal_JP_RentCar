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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private Clientes LlenarClase()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            clientes.Nombre = NombresTextBox.Text;
            clientes.Sexo = SexoComboBox.Text;
            clientes.Cedula = CedulaMaskedTextBox.Text;
            clientes.FechaNacimiento = DateTime.Now;
            clientes.Direccion = DireccionTextBox.Text;
            clientes.Telefono = TelefonoMaskedTextBox.Text;

            return clientes;

        }

        private bool Validar()
        {
            bool Validar = false;

            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                ErrorProvider.SetError(NombresTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(SexoComboBox.Text))// ojo cuando es combobox es .text preguntar
            {
                ErrorProvider.SetError(SexoComboBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                ErrorProvider.SetError(CedulaMaskedTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                ErrorProvider.SetError(DireccionTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                ErrorProvider.SetError(TelefonoMaskedTextBox, "Debes llenar este campo");
                Validar = true;
            }

            return Validar;
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Clientes clientes = BLL.ClientesBLL.Buscar(id);

            if (clientes != null)
            {
                ClienteIdNumericUpDown.Value = clientes.ClienteId;
                NombresTextBox.Text = clientes.Nombre;
                SexoComboBox.Text = clientes.Sexo;
                CedulaMaskedTextBox.Text = clientes.Cedula.ToString();
                FechaNacimientoDateTimePicker.ResetText();
                DireccionTextBox.Text = clientes.Direccion;
                TelefonoMaskedTextBox.Text = clientes.Telefono.ToString();

            }
            else
            {
                MessageBox.Show("no se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ErrorProvider.Clear();
        }

    }
}
