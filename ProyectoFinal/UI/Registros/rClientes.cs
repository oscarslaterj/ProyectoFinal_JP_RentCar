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
            LlenarComboSexo();
        }

        public void Limpiar()
        {
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            DireccionTextBox.Clear();
            SexoComboBox.Items.Clear();
            TelefonoMaskedTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            FechaNacimientoDateTimePicker.ResetText();
          


            ErrorProvider.Clear();

        }

        private void LlenarComboSexo()
        {
            //Vaciar comboBox para que los items que vamos a añadir no se repitan
            SexoComboBox.Items.Clear();

            //Incluir dos items Hombre y Mujer
            SexoComboBox.Items.Add(new KeyValuePair<string, string>("Hombre", "(H)"));
            SexoComboBox.Items.Add(new KeyValuePair<string, string>("Mujer", "(M)"));
        }


        private Clientes LlenarClase()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            clientes.Nombre = NombresTextBox.Text;
            clientes.Sexo = SexoComboBox.Text;
            clientes.Cedula = CedulaMaskedTextBox.Text;
            clientes.FechaNacimiento = DateTime.Now;
            clientes.FechaRegistro = DateTime.Now;
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

            if (string.IsNullOrWhiteSpace(SexoComboBox.Text))
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {

            bool paso = false;
            Clientes clientes = new Clientes();

            if (Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            ErrorProvider.Clear();

            clientes = LlenarClase();

            if (ClienteIdNumericUpDown.Value == 0)
                paso = BLL.ClientesBLL.Guardar(clientes);
            else
            {
                int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
                Clientes clientesd = BLL.ClientesBLL.Buscar(id);

                
                paso = BLL.ClientesBLL.Modificar(clientes);
               
            }

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);

            if (Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            if (BLL.ClientesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("no se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
