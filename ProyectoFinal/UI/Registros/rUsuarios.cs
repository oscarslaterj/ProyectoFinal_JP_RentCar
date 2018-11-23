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
        private RepositorioBase<Usuarios> repositorio;
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

        }

        private bool ExiteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = repositorio.Buscar((int)UserIdNumericUpDown.Value);
            return (usuarios != null);
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
            if (string.IsNullOrEmpty(UserNameTextBox.Text))
            {
                ErrorProvider.SetError(UserNameTextBox, "Debe introducir el Nombre del Usuario");
                if (string.IsNullOrEmpty(PasswordMaskedTextBox.Text))
                {
                    ErrorProvider.SetError(PasswordMaskedTextBox, "Debe introducir la Contraseña");
                    if (string.IsNullOrEmpty(ConfirmPasswordMaskedTextBox.Text))
                    {
                        ErrorProvider.SetError(ConfirmPasswordMaskedTextBox, "Debe introducir la Contraseña de confirmacion");
                    }
                }
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
            repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios;
            bool paso = false;

            usuarios = Llenaclase();
            if (PasswordMaskedTextBox.Text == ConfirmPasswordMaskedTextBox.Text)
            {
                if (!Validar())
                {
                    MessageBox.Show("Debe llenar los Campos vacios");
                }
                else
                if (UserIdNumericUpDown.Value >= 0)
                    paso = repositorio.Guardar(usuarios);
                else
                {
                    if (!ExiteEnLaBaseDeDatos())
                        MessageBox.Show("No Exite No es Modificable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(usuarios);

                if (paso)
                {
                    MessageBox.Show("Guardado con Exito", "Guardo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Guardo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            int.TryParse(UserIdNumericUpDown.Text, out id);
            usuarios = repositorio.Buscar(id);

            if (usuarios != null)
            {
                MessageBox.Show("Usuario Encotrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampos(usuarios);
            }
            else
                MessageBox.Show("Usuario No Existe");
        }
    }
    }


