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
            var listado = new List<Clientes>();
            RepositorioBase<Clientes> repositorioBase = new RepositorioBase<Clientes>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {


                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Id


                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorioBase.GetList(p => p.ClienteId == id);

                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Este Id no Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }

                    case 1://nombre


                        {
                            listado = repositorioBase.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Nombre no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }
                    case 2: //Cedula

                        {
                            listado = repositorioBase.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));
                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Cedula no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;


                        }
                    case 3://Direccion

                        {
                            listado = repositorioBase.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Direccion no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;

                    case 4://Telefono                     
                        {
                            listado = repositorioBase.GetList(p => p.Telefono.Contains(CriterioTextBox.Text));

                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Telefono no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;


                    case 7://todo
                        filtro = x => true;
                        break;
                }
            }
            else
            {
                listado = repositorioBase.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
            CriterioTextBox.Clear();
           
        }
    }
}
