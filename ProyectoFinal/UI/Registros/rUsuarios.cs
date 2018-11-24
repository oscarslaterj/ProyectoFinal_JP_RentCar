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

       /* private bool ExiteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = repositorio.Buscar((int)UserIdNumericUpDown.Value);
            return (usuarios != null);
        }*/


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

        private bool Validar(int error)
        {
            bool errores = false;
            int num = 0;
            if (error == 1 && UserIdNumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(UserIdNumericUpDown, "Llenar Usuario Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(NameUserTextBox.Text))
            {

                ErrorProvider.SetError(NameUserTextBox, "Llene Nombre");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {

                ErrorProvider.SetError(UserNameTextBox, "Llene Usuario");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(PasswordMaskedTextBox.Text))
            {

                ErrorProvider.SetError(PasswordMaskedTextBox, "Llene contraseña");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(ConfirmPasswordMaskedTextBox.Text))
            {

                ErrorProvider.SetError(ConfirmPasswordMaskedTextBox, "Llene contraseña");
                errores = true;
            }

          /*  if (error == 2 && string.IsNullOrEmpty(NivelAccesoComboBox.Text))
            {

                ErrorProvider.SetError(NivelAccesoComboBox, "Llene Tipo de Usuario");
                errores = true;
            }*/
            if (error == 3 && int.TryParse(NameUserTextBox.Text, out num) == true)
            {

                ErrorProvider.SetError(NameUserTextBox, "Debe Digitar Caracteres");
                errores = true;
            }

            if (error == 4 && PasswordMaskedTextBox.Text != ConfirmPasswordMaskedTextBox.Text)
            {

                ErrorProvider.SetError(ConfirmPasswordMaskedTextBox, "Llenar Confirmar Contraseña");
                errores = true;
            }

            return errores;
        }



        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuarios = Llenaclase();
            int id = Convert.ToInt32(UserIdNumericUpDown.Value);


            if (Validar(3))
            {
                MessageBox.Show("Favor Dijite un Nombre", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validar(4))
            {
                MessageBox.Show("La Contraseña no son Iguales", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordMaskedTextBox.Clear();
                ConfirmPasswordMaskedTextBox.Clear();
                return;
            }

            if (Validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserIdNumericUpDown.Value == 0)
                {
                    paso = BLL.UsuariosBLL.Guardar(usuarios);
                }
                else
                {

                    var usuario = BLL.UsuariosBLL.Buscar(id);

                    if (usuario != null)
                    {
                        paso = BLL.UsuariosBLL.Editar(usuarios);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Limpiar();
                ErrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




            private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(UserIdNumericUpDown.Value);
                Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);

                if (usuarios != null)
                {
                    UserIdNumericUpDown.Value = usuarios.UsuarioId;
                    NameUserTextBox.Text = usuarios.Nombre;
                    UserNameTextBox.Text = usuarios.NombreUser;
                    PasswordMaskedTextBox.Text = usuarios.Clave;
                    NivelAccesoComboBox.Text = usuarios.NivelAcceso;

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ErrorProvider.Clear();
            }
        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(UserIdNumericUpDown.Value);

                if (BLL.UsuariosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ErrorProvider.Clear();
            }
        }
    }
    }


