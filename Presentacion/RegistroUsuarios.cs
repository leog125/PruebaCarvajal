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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
            LimpearCampos();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EntidadUsuarios usuario = new EntidadUsuarios
                    {
                        Usu_Nombres = txt_nombres.Text,
                        Usu_Email = txt_email.Text,
                        Usu_Password = txt_password.Text,
                        Usu_Habilitado = true,
                        Usu_FechaCreacion = DateTime.Now
                    };
                    Fn_Usuarios fn_Usuarios = new Fn_Usuarios();
                    if (fn_Usuarios.Add_Usuario(usuario))
                    {
                        MessageBox.Show("Registro Guardado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpearCampos();
                    }
                    else
                        MessageBox.Show("No fue posible guardar el registro", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LimpearCampos()
        {
            txt_nombres.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_password.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txt_nombres.Text))
            {
                MessageBox.Show("Digite el Nombre del usuario", "Registro Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Digite el Email del usuario", "Registro Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Digite la contraseña del usuario", "Registro Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            return result;
        }
    }
}
