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
    public partial class EstadosVuelos : Form
    {
        public EstadosVuelos()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EntidadEstados estado = new EntidadEstados
                    {
                        Est_Nombre = txt_nombre.Text,
                        Est_hailitado = true
                    };
                    Fn_Estados fn_Estados = new Fn_Estados();
                    if (fn_Estados.Add_Estado(estado))
                        MessageBox.Show("Estado creada", "Agregar Estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Problemas al guardar la Estado", "Agregar Estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool ValidarCampos()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la Estado", "Agregar Estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }
    }
}
