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
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class rRenta : Form
    {
        Renta renta = new Renta();
        public int Index { get; set; }
        List<RentasDetalle> Detalle = new List<RentasDetalle>();
        VehiculosDetalle vehiculo;
        public rRenta()
        {
            InitializeComponent();
            LlenaComboBox();
            FiltroVehiculoComboBox.SelectedIndex = 0;
        }

        private void LlenaComboBox()
        {
            RepositorioBase<VehiculosDetalle> repositorio = new RepositorioBase<VehiculosDetalle>();
            FiltroVehiculoComboBox.DataSource = repositorio.GetList(c => true);
            FiltroVehiculoComboBox.DisplayMember = "Modelo";
            FiltroVehiculoComboBox.ValueMember = "VehiculoID";

            RepositorioBase<Clientes> repository = new RepositorioBase<Clientes>();
            ClientecomboBox.DataSource = repository.GetList(c => true);
            ClientecomboBox.DisplayMember = "Nombre";
            ClientecomboBox.ValueMember = "ClienteId";

        }
        private Renta LlenaClase()
        {
            Renta renta = new Renta();
            renta.RentaID = Convert.ToInt32(RentaIDnumericUpDown.Value);
            renta.FechaRegistro = DateTime.Now;
            renta.FechaDevuelta = DateTime.Now;
            renta.Detalle = this.Detalle;
            return renta;
        }


        private void Limpiar()
        {
            RentaIDnumericUpDown.Value = 0;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
            FiltroVehiculoComboBox.Text = string.Empty;
            ClientecomboBox.Text = string.Empty;


        }

        private bool Validar()
        {
            bool Validar = true;
  

            return Validar;
        }


        public bool ValidarAgregarVehiculo()
        {
            bool paso = true;
            if (String.IsNullOrWhiteSpace(FiltroVehiculoComboBox.Text.Replace("-", "")))
            {
                ErrorProvider.SetError(FiltroVehiculoComboBox, "Debe Insertar un Vehiculo");
                FiltroVehiculoComboBox.Focus();
                paso = false;
            }
            return paso;
        }


            private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {

            //if (DetalleDataGridView.DataSource != null)
            //    this.Detalle = (List<VehiculosDetalle>)DetalleDataGridView.DataSource;
            ////todo: validar campos del detalle
            //if (!ValidarAgregarVehiculo())
            //    return;
            ////Agregar un nuevo detalle con los datos introducidos.
            //this.Detalle.Add(
            //    new VehiculosDetalle(
            //        vehiculoID: 0,
            //         placa: 

            //        )
            //   );
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<RentasDetalle>)DetalleDataGridView.DataSource;
            this.Detalle.Add(new RentasDetalle(0, vehiculo.VehiculoID,(int)RentaIDnumericUpDown.Value , vehiculo.Anio, vehiculo.Marca
                                , vehiculo.Modelo, vehiculo.PrecioRenta));
            ErrorProvider.Clear();
            CargarGrid();
        }

        public bool ValidarRemover()
        {
            bool paso = true;
            if (DetalleDataGridView.SelectedRows == null)
            {
                paso = false;
            }
            return paso;
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = Detalle;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
              if(DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow !=null)
            {
                Detalle.RemoveAt(Index);
                CargarGrid();
                Index = -1;
            }
        }

        private void VehiculosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex; 
        }


        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RepositorioBase<VehiculosDetalle> repositorio = new RepositorioBase<VehiculosDetalle>();
            vehiculo = repositorio.Buscar(Convert.ToInt32(FiltroVehiculoComboBox.SelectedValue));
            AnioTextBox.Text = vehiculo.Anio;
            MarcaTextBox.Text = vehiculo.Marca;
            ModeloTextBox.Text = vehiculo.Modelo;
            PlacaTextBox.Text = vehiculo.Placa;
            DescripcionTextBox.Text = vehiculo.Descripcion;
            PrecioNumericUpDown.Value = vehiculo.PrecioRenta;
            DateTimePickerF.Value = vehiculo.FechaRegistro;
        }

        private void RentarButton_Click(object sender, EventArgs e)
        {
            
            bool paso = false;
            Renta renta = LlenaClase();
            if (RentaIDnumericUpDown.Value == 0)
                paso = RentaBLL.Guardar(renta);
            else
            {
                paso = RentaBLL.Modificar(renta);
            }
            if (paso)
                MessageBox.Show("Guardado");
            else
                MessageBox.Show("No Guardado");


        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(RentaIDnumericUpDown.Value);

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
    }
}
