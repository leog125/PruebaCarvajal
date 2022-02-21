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
    public partial class Aerolineas : Form
    {
        public Aerolineas()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EntidadAerolinea aerolinea = new EntidadAerolinea
                    {
                        Alr_Nombre = txt_nombre.Text,
                        Alr_Habilitada = true
                    };
                    Fn_Aerolineas fn_Aerolinea = new Fn_Aerolineas();
                    if (fn_Aerolinea.Add_Aerolinea(aerolinea))
                        MessageBox.Show("Aerolinea creada", "Agregar Aerolinea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Problemas al guardar la Aerolinea", "Agregar Aerolinea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool ValidarCampos()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la Aerolinea", "Agregar Aerolinea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }
    }
}
