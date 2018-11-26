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
        public rRenta()
        {
            InitializeComponent();
            LlenaComboBox();
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


        private bool Validar()
        {

            return paso;
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

            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<VehiculosDetalle>)DetalleDataGridView.DataSource;
            //todo: validar campos del detalle
            if (!ValidarAgregarVehiculo())
                return;
            //Agregar un nuevo detalle con los datos introducidos.
            this.Detalle.Add(
                new VehiculosDetalle(
                    vehiculoID: 0,
                     placa: 

                    )
               );
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
    }
}
