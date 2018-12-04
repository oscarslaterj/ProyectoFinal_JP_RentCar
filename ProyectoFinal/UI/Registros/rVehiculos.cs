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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class rVehiculos : Form
    {
        
        public rVehiculos()
        {
            InitializeComponent();
            LlenarTipoCombo();
            LlenarColorCombo();
        }
        private void Limpiar()
        {
            VehiculoNumericUpDown.Value = 0;
            ModeloTextBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            TipoComboBox.Items.Clear();
            ColorComboBox.Items.Clear();
            MarcaTextBox.Text = string.Empty;
            PlacaTextBox.Text = string.Empty;
            AnioTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
        }

        private Vehiculos LlenaClase()
        {
           Vehiculos vehiculos= new Vehiculos();
            vehiculos.VehiculoId = Convert.ToInt32(VehiculoNumericUpDown.Value);
            vehiculos.Descripcion = DescripcionTextBox.Text;
            vehiculos.Marca = MarcaTextBox.Text;
            vehiculos.Modelo = ModeloTextBox.Text;
            vehiculos.Anio = AnioTextBox.Text;
            vehiculos.Placa = PlacaTextBox.Text;
            vehiculos.PrecioRenta = Convert.ToDecimal(PrecioNumericUpDown.Value);
            vehiculos.FechaRegistro = FechaRegistroDateTimePicker.Value;
          

            return vehiculos;
        }

        private void LlenaCampos(Vehiculos vehiculos)
        {
            VehiculoNumericUpDown.Value = vehiculos.VehiculoId;
            MarcaTextBox.Text = vehiculos.Marca;
            ModeloTextBox.Text = vehiculos.Modelo;
            DescripcionTextBox.Text = vehiculos.Descripcion;
            PlacaTextBox.Text = vehiculos.Placa;
            AnioTextBox.Text = vehiculos.Anio;
            PrecioNumericUpDown.Value = vehiculos.PrecioRenta;

        }


        public bool Validar(int error)
        {
            bool paso = true;



            if (error == 2 && FechaRegistroDateTimePicker.Value == DateTime.Now || FechaRegistroDateTimePicker.Value > DateTime.Now)
            {
                ErrorProvider.SetError(FechaRegistroDateTimePicker, "Fecha Fuera De Rango");
                paso = false;
            }

            if (error == 2 && PrecioNumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PrecioNumericUpDown, "Costo en 0");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                ErrorProvider.SetError(DescripcionTextBox, "Campo Vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(MarcaTextBox.Text))
            {
                ErrorProvider.SetError(MarcaTextBox, "Campo Vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ModeloTextBox.Text))
            {
                ErrorProvider.SetError(ModeloTextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PlacaTextBox.Text))
            {
                ErrorProvider.SetError(PlacaTextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AnioTextBox.Text))
            {
                ErrorProvider.SetError(AnioTextBox, "Campo Vacio");
                paso = false;
            }
            
            return paso;
        }


        public bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();
            Vehiculos articulos = new Vehiculos();
            articulos = repositorio.Buscar((int)VehiculoNumericUpDown.Value);
            return (articulos != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();

            Vehiculos vehiculos;

            if (!Validar(2))
                return;
            vehiculos = LlenaClase();

            if (VehiculoNumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(vehiculos);

            }
            else
            {
                int id = Convert.ToInt32(VehiculoNumericUpDown.Value);
                var articulo = repositorio.Buscar(id);
                if (articulo != null)
                {
                    paso = repositorio.Modificar(articulo);
                }
                else
                {
                    MessageBox.Show("Id no Encotrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (paso)
            {
                MessageBox.Show("Guardo con Exito", "Exite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se Guardo!!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();
            int id;
            int.TryParse(VehiculoNumericUpDown.Text, out id);
            if (!ExiteEnLaBaseDeDatos())
            {
                ErrorProvider.SetError(VehiculoNumericUpDown, "Artuculo no Exite");
                VehiculoNumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Exite No se puede Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();
            int id;
            Vehiculos vehiculos = new Vehiculos();

            int.TryParse(VehiculoNumericUpDown.Text, out id);
            vehiculos = repositorio.Buscar(id);

            if (vehiculos != null)
            {
                MessageBox.Show("Articulos Encotrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampos(vehiculos);
            }
            else
            {
                MessageBox.Show("Cliente no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void MarcaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ModeloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;   

        }

        private void PlacaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void LlenarTipoCombo()
        {
            TipoComboBox.Items.Add("Sedan");
            TipoComboBox.Items.Add("Deportivo");
            TipoComboBox.Items.Add("Coupe");
            TipoComboBox.Items.Add("Familiar");
            TipoComboBox.Items.Add("TodoTerreno");

        }

        private void LlenarColorCombo()
        {
            ColorComboBox.Items.Add("Azul");
            ColorComboBox.Items.Add("Rojo");
            ColorComboBox.Items.Add("Amarillo");
            ColorComboBox.Items.Add("Blanco");
            ColorComboBox.Items.Add("Negro");
            ColorComboBox.Items.Add("Dorado");
            ColorComboBox.Items.Add("Naranja");
            ColorComboBox.Items.Add("Verde");
            ColorComboBox.Items.Add("Plateado");

        }


    }
    }
