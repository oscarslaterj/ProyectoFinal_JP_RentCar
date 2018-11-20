using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Registros;
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

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void CleanProvider()
        {
            LogInErrorProvider.Clear();
        }


        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int paso = 0;
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();

            CleanProvider();
            if (UsuarioTextBox.Text == string.Empty)
            {
                paso = 1;
                LogInErrorProvider.SetError(UsuarioTextBox, "Incorrecto");

            }
            if (ContrasenaTextBox.Text == string.Empty)
            {
                paso = 1;
                LogInErrorProvider.SetError(ContrasenaTextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if ((UsuarioTextBox.Text == "Admin") && (ContrasenaTextBox.Text == "123456"))
            {
                this.Hide();
                mainform ver = new mainform();
                ver.Show();
            }
            else
            {
                filtrar = t => t.NombreUser.Equals(UsuarioTextBox.Text);
                user = UsuariosBLL.GetList(filtrar);

                if (user.Exists(x => x.NombreUser == UsuarioTextBox.Text) && user.Exists(x => x.Clave == ContrasenaTextBox.Text))
                {
                    this.Hide();
                    mainform ver = new mainform();
                    ver.Show();
                    
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                    LogInErrorProvider.SetError(ContrasenaTextBox, "Incorrecto");
                    LogInErrorProvider.SetError(UsuarioTextBox, "Incorrecto");
                }
            }
            ContrasenaTextBox.MaxLength = 14;
        }
    }
}
