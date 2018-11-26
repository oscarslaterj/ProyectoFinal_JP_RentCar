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

        public rUsuarios()
        {
            InitializeComponent();
            LlenarComboNivel();
        }

        public void LlenarCampos(Usuarios usuarios)
        {
            NameUserTextBox.Text = usuarios.Nombre;
            UserNameTextBox.Text = usuarios.NombreUser;
            PasswordMaskedTextBox.Text = usuarios.Clave;
            ConfirmPasswordMaskedTextBox.Text = usuarios.ConfirmClave ;
            FechaRegistroDateTimePicker.Value = usuarios.Fecha;
            NivelAccesoComboBox.Text = usuarios.NivelAcceso;
        }


        public void Limpiar()
        {
            UserIdNumericUpDown.Value = 0;
            NameUserTextBox.Clear();
            UserNameTextBox.Clear();
            PasswordMaskedTextBox.Clear();
            ConfirmPasswordMaskedTextBox.Clear();
            NivelAccesoComboBox.Items.Clear();
            LlenarComboNivel();
            ErrorProvider.Clear();

        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)UserIdNumericUpDown.Value);
            return (usuario != null);
        }

        private void LlenarComboNivel()
        {
            NivelAccesoComboBox.Items.Clear();
            NivelAccesoComboBox.Items.Add(new KeyValuePair<string, string>("Admin", "(Admin)"));
            NivelAccesoComboBox.Items.Add(new KeyValuePair<string, string>("Usuario", "(User)"));
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
            //usuarios.NivelAcceso = NivelAccesoComboBox.SelectedValue.ToString();
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
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
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
            LlenarComboNivel();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
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
            LlenarComboNivel();
        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
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
            LlenarComboNivel();
        }

        private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NameUserTextBox_KeyPress(object sender, KeyPressEventArgs e)
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


