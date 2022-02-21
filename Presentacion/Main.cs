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
    public partial class Main : Form
    {
        public EntidadUsuarios usuario = new EntidadUsuarios();
        private int Vuelo_ID = 0;
        public Main()
        {
            InitializeComponent();
            CargarInformacion();
            LimpearCampos();
        }

        private void CargarVuelos()
        {
            try
            {
                Fn_Vuelos fn_Vuelos = new Fn_Vuelos();
                gv_vuelos.DataSource = fn_Vuelos.GetVuelos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CargarAerolineas()
        {
            try
            {
                Fn_Aerolineas fn_Aerolineas = new Fn_Aerolineas();
                cb_aerolineas.DataSource = fn_Aerolineas.GetAerolineas();
                cb_aerolineas.DisplayMember = "Alr_Nombre";
                cb_aerolineas.ValueMember = "Alr_Id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CargarCiudadDestino()
        {
            try
            {
                Fn_Ciudades fn_Ciudad = new Fn_Ciudades();
                cb_ciudaddestino.DataSource = fn_Ciudad.GetCiudades();
                cb_ciudaddestino.DisplayMember = "Ciu_Nombre";
                cb_ciudaddestino.ValueMember = "Ciu_Id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CargarCiudadOrigen()
        {
            try
            {
                Fn_Ciudades fn_Ciudad = new Fn_Ciudades();
                cb_ciudadorigen.DataSource = fn_Ciudad.GetCiudades();
                cb_ciudadorigen.DisplayMember = "Ciu_Nombre";
                cb_ciudadorigen.ValueMember = "Ciu_Id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CargarEstados()
        {
            try
            {
                Fn_Estados fn_Estados = new Fn_Estados();
                cb_estados.DataSource = fn_Estados.Getestados();
                cb_estados.DisplayMember = "Est_Nombre";
                cb_estados.ValueMember = "Est_Id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            if (usuario.Usu_Id == 0)
            {
                login.Show();
            }
            else
            {
                login.Close();
            }
        }

        private void aerolineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aerolineas aerolineas = new Aerolineas();
            aerolineas.ShowDialog();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudades ciudades = new Ciudades();
            ciudades.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadosVuelos estados = new EstadosVuelos();
            estados.ShowDialog();
        }

        private void actualizarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarInformacion();
            LimpearCampos();
        }

        private void CargarInformacion()
        {
            CargarEstados();
            CargarCiudadOrigen();
            CargarCiudadDestino();
            CargarAerolineas();
            CargarVuelos();
        }

        private void LimpearCampos()
        {
            cb_ciudadorigen.SelectedItem = null;
            cb_ciudadorigen.SelectedText = string.Empty;
            cb_ciudaddestino.SelectedItem = null;
            cb_ciudaddestino.SelectedText = string.Empty;
            cb_aerolineas.SelectedItem = null;
            cb_aerolineas.SelectedText = string.Empty;
            cb_estados.SelectedItem = null;
            cb_estados.SelectedText = string.Empty;
            Vuelo_ID = 0;
            btn_crear.Text = "Crear";
        }

        private bool ValidarCampos()
        {
            bool result = true;
            if (string.IsNullOrEmpty((string)cb_ciudadorigen.SelectedValue))
            {
                MessageBox.Show("Seleccione Ciudad origen", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty((string)cb_ciudaddestino.SelectedValue))
            {
                MessageBox.Show("Seleccione Ciudad destino", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty(dt_fechallegada.Value.ToShortDateString()))
            {
                MessageBox.Show("Seleccione Fecha llegada", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty(dt_horallegada.Value.ToShortTimeString()))
            {
                MessageBox.Show("Seleccione Hora llegada", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty(dt_fechasalida.Value.ToShortDateString()))
            {
                MessageBox.Show("Seleccione Fecha salida", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty(dt_horasalida.Value.ToShortTimeString()))
            {
                MessageBox.Show("Seleccione Hora salida", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty((string)cb_aerolineas.SelectedValue))
            {
                MessageBox.Show("Seleccione Aerolinea", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (string.IsNullOrEmpty((string)cb_estados.SelectedValue))
            {
                MessageBox.Show("Seleccione Estado Vuelo", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else if (cb_ciudaddestino.SelectedValue.ToString() == cb_ciudadorigen.SelectedValue.ToString())
            {
                MessageBox.Show("No pueden ser iguales la ciudad origen y destino", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            return result;
        }

        private bool ValidarFechas(DateTime fechallegadacompleta, DateTime fechasalidacompleta)
        {
            bool result = true;
            if (fechasalidacompleta >= fechallegadacompleta)
            {
                MessageBox.Show("La fecha de llegada tiene que ser mayor a la de salida ", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechallegada = Convert.ToDateTime(dt_fechallegada.Value.ToShortDateString());
                DateTime horallegada = Convert.ToDateTime(dt_horallegada.Value.ToShortTimeString());
                DateTime fechallegadacompleta = fechallegada.AddHours(horallegada.Hour).AddMinutes(horallegada.Minute).AddSeconds(horallegada.Second);
                DateTime fechasalida = Convert.ToDateTime(dt_fechasalida.Value.ToShortDateString());
                DateTime horasalida = Convert.ToDateTime(dt_horasalida.Value.ToShortTimeString());
                DateTime fechasalidacompleta = fechasalida.AddHours(horasalida.Hour).AddMinutes(horasalida.Minute).AddSeconds(horasalida.Second);
                if (ValidarCampos() && ValidarFechas(fechallegadacompleta, fechasalidacompleta))
                {
                    Fn_Vuelos fn_Vuelos = new Fn_Vuelos();
                    if (btn_crear.Text == "Crear")
                    {
                        EntidadVuelos vuelo = new EntidadVuelos
                        {
                            Ciu_Id_Origen = (int)cb_ciudadorigen.SelectedValue,
                            Ciu_Id_Destino = (int)cb_ciudaddestino.SelectedValue,
                            Vue_FechaLlegada = fechallegadacompleta,
                            Vue_FechaSalida = fechasalidacompleta,
                            Arl_Id = (int)cb_aerolineas.SelectedValue,
                            Est_Id = (int)cb_estados.SelectedValue,
                            Usu_Id = usuario.Usu_Id
                        };
                        if (fn_Vuelos.Add_Vuelos(vuelo))
                        {
                            MessageBox.Show("Vuelo Guardado", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpearCampos();
                        }
                        else
                            MessageBox.Show("Problemas al guardar el vuelo.", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (btn_crear.Text == "Actualizar")
                    {
                        EntidadVuelosDetalles vuelosDetalles = new EntidadVuelosDetalles();
                        vuelosDetalles.Aerolinea_Nombre = cb_aerolineas.Text;
                        vuelosDetalles.Ciudad_Destino = cb_ciudaddestino.Text;
                        vuelosDetalles.Ciudad_Origen = cb_ciudadorigen.Text;
                        vuelosDetalles.Estado_Vuelo = cb_estados.Text;
                        vuelosDetalles.Fecha_Llegada = fechallegadacompleta;
                        vuelosDetalles.Fecha_Salida = fechasalidacompleta;
                        vuelosDetalles.Vuelo_ID = Vuelo_ID;
                        if (fn_Vuelos.Update_Vuelo(vuelosDetalles))
                        {
                            MessageBox.Show("Vuelo Actualizado", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpearCampos();
                        }
                        else
                            MessageBox.Show("Problemas al actualizar el vuelo.", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                CargarVuelos();
                btn_crear.Text = "Crear";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void gv_vuelos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpearCampos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_vuelos.Rows[e.RowIndex];
                cb_ciudadorigen.SelectedText = row.Cells["Ciudad_Origen"].Value.ToString();
                cb_ciudaddestino.SelectedText = row.Cells["Ciudad_Destino"].Value.ToString();
                cb_aerolineas.SelectedText = row.Cells["Aerolinea_Nombre"].Value.ToString();
                cb_estados.SelectedText = row.Cells["Estado_Vuelo"].Value.ToString();
                Vuelo_ID = Convert.ToInt32(row.Cells["Vuelo_ID"].Value.ToString());
                btn_crear.Text = "Actualizar";
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
