using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuarios registro = new RegistroUsuarios();
            registro.ShowDialog();
        }

        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            try
            {
                Fn_Usuarios fn_Usuarios = new Fn_Usuarios();
                EntidadUsuarios usuario = new EntidadUsuarios();
                EntidadUsuarios resul_usuario = new EntidadUsuarios();
                usuario.Usu_Email = txt_email.Text;
                usuario.Usu_Password = txt_password.Text;
                resul_usuario = fn_Usuarios.ValidarUsuario(usuario);
                if (string.IsNullOrEmpty(resul_usuario.Usu_Email))
                {
                    MessageBox.Show("Usuario no valido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Main main = new Main();
                    //this.Close();
                    main.usuario = resul_usuario;
                    main.Show();
                    txt_email.Text = string.Empty;
                    txt_password.Text = string.Empty;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
