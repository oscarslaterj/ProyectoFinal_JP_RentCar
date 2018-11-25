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

    public partial class rUsuarios : Form
    {
        RepositorioBase<Usuarios> repositorio;
        public rUsuarios()
        {
            InitializeComponent();
        }

        public void LlenarCampos(Usuarios usuarios)
        {
            usuarios.Nombre = NameUserTextBox.Text;
            usuarios.NombreUser = UserNameTextBox.Text;
            usuarios.Clave = PasswordMaskedTextBox.Text;
            usuarios.ConfirmClave = ConfirmPasswordMaskedTextBox.Text;
            usuarios.Fecha = FechaRegistroDateTimePicker.Value;
        }


        public void Limpiar()
        {
            UserIdNumericUpDown.Value = 0;
            NameUserTextBox.Clear();
            UserNameTextBox.Clear();
            PasswordMaskedTextBox.Clear();
            ConfirmPasswordMaskedTextBox.Clear();
            NivelAccesoComboBox.SelectedItem = null;


            ErrorProvider.Clear();

        }

        private bool ExiteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Usuarios>(new DAL.Contexto());
            Usuarios usuario = repositorio.Buscar((int)UserIdNumericUpDown.Value);
            return (usuario != null);
        }


        public Usuarios Llenaclase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(UserIdNumericUpDown.Value);
            usuarios.Nombre = NameUserTextBox.Text;
            usuarios.NombreUser = UserNameTextBox.Text;
            usuarios.Clave = PasswordMaskedTextBox.Text;
            usuarios.ConfirmClave = ConfirmPasswordMaskedTextBox.Text;
            usuarios.Fecha = FechaRegistroDateTimePicker.Value;

            return usuarios;
        }

        private bool Validar()
        {

            bool paso = true;
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {
                ErrorProvider.SetError(UserNameTextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PasswordMaskedTextBox.Text))
            {
                ErrorProvider.SetError(PasswordMaskedTextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NameUserTextBox.Text))
            {
                ErrorProvider.SetError(NameUserTextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmPasswordMaskedTextBox.Text))
            {
                ErrorProvider.SetError(ConfirmPasswordMaskedTextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NivelAccesoComboBox.Text))
            {
                ErrorProvider.SetError(NivelAccesoComboBox, "Campo Vacio");
                paso = false;
            }


            return paso;
        }



        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Usuarios>(new DAL.Contexto());
            bool paso = false;
            Usuarios usuario;
            if (!Validar())
                return;
            usuario = new Usuarios();
            usuario = Llenaclase();
            if (UserIdNumericUpDown.Value == 0)
            {

                paso = repositorio.Guardar(usuario);
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No Se Puede Modificar No Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(usuario);
            }
            if (paso)
            {
                MessageBox.Show("Guardado con Exito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Se Puede Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void BuscarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Usuarios>(new DAL.Contexto());
            int id;
            Usuarios usuario = new Usuarios();

            int.TryParse(UserIdNumericUpDown.Text, out id);
            usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Econtrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampos(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Usuarios>(new DAL.Contexto());
            int id;
            int.TryParse(UserIdNumericUpDown.Text, out id);
            if (!ExiteEnLaBaseDeDatos())
            {
                ErrorProvider.SetError(UserIdNumericUpDown, "Este Usuario No Exite");
                UserIdNumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Usuario Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se Pudo Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


