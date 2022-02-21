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
    public partial class Ciudades : Form
    {
        public Ciudades()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EntidadCiudades ciudad = new EntidadCiudades
                    {
                        Ciu_Nombre = txt_nombre.Text,
                        Ciu_Habilitado = true
                    };
                    Fn_Ciudades fn_Ciudades = new Fn_Ciudades();
                    if (fn_Ciudades.Add_Ciudad(ciudad))
                        MessageBox.Show("Ciudad creada", "Agregar Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Problemas al guardar la Ciudad", "Agregar Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool ValidarCampos()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la Ciudad", "Agregar Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }

    }
}
