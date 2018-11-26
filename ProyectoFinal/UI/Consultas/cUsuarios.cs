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
    public partial class cUsuarios : Form
    {
        RepositorioBase<Usuarios> repositorioBase;
        Expression<Func<Usuarios, bool>> filtro = x => true;
        public cUsuarios()
        {
            InitializeComponent();
            repositorioBase = new RepositorioBase<Usuarios>(new DAL.Contexto());
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {


                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Id


                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorioBase.GetList(p => p.UsuarioId == id);

                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Este Usuario no Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    case 2: //Usuario

                        {
                            listado = repositorioBase.GetList(p => p.NombreUser.Contains(CriterioTextBox.Text));
                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Usuario no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;


                        }
                    case 3://Clave

                        {
                            listado = repositorioBase.GetList(p => p.Clave.Contains(CriterioTextBox.Text));
                            if (repositorioBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Clave no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;






                    case 4://todo
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
    
