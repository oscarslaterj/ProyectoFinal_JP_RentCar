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
            PrecioNumericUpDown.Value = 0;
            TipoComboBox.Items.Clear();
            MarcaTextBox.Text = string.Empty;
            PlacaTextBox.Text = string.Empty;
            AnioTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
        }

        private Vehiculos LlenaClase()
        {
           Vehiculos vehiculos= new Vehiculos();
            vehiculos.VehiculoID = Convert.ToInt32(VehiculoNumericUpDown.Value);
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
            VehiculoNumericUpDown.Value = vehiculos.VehiculoID;
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



            if (error == 2 && FechaRegistroDateTimePicker.Value == DateTime.Now || FechaRegistroDateTimePicker.Value < DateTime.Now)
            {
                ErrorProvider.SetError(FechaRegistroDateTimePicker, "Fecha Fuera De Rango");
                paso = false;
            }

            if (error == 2 && PrecioNumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PrecioNumericUpDown, "Costo en 0");
                paso = false;
            }

            if (error == 2 && PrecioNumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PrecioNumericUpDown, "Precio en 0");
                paso = true;
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
            repositorio = new RepositorioBase<Vehiculos>(new DAL.Contexto());
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
            repositorio = new RepositorioBase<Vehiculos>(new DAL.Contexto());

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
            repositorio = new RepositorioBase<Vehiculos>(new DAL.Contexto());
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
            repositorio = new RepositorioBase<Vehiculos>(new DAL.Contexto());
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
    }
    }
