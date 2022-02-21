using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Fn_Vuelos
    {
        readonly BD_Vuelos bd_Vuelos = new BD_Vuelos();
        public bool Add_Vuelos(EntidadVuelos vuelo)
        {
            bool result = false;
            try
            {
                result = bd_Vuelos.Add_Vuelo(vuelo);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public List<EntidadVuelosDetalles> GetVuelos()
        {
            List<EntidadVuelosDetalles> lstestados = new List<EntidadVuelosDetalles>();
            try
            {
                DataTable dt = new DataTable();
                dt = bd_Vuelos.GetVuelos();
                if (dt.Rows.Count > 0)
                {
                    lstestados = dt.AsEnumerable().Select(m => new EntidadVuelosDetalles()
                    {
                        Vuelo_ID = m.Field<int>("Vuelo_ID"),
                        Fecha_Llegada = m.Field<DateTime>("Fecha_Llegada"),
                        Fecha_Salida = m.Field<DateTime>("Fecha_Salida"),
                        Numero_Vuelo = m.Field<int>("Numero_Vuelo"),
                        Aerolinea_Nombre = m.Field<string>("Aerolinea_Nombre"),
                        Ciudad_Origen = m.Field<string>("Ciudad_Origen"),
                        Estado_Vuelo = m.Field<string>("Estado_Vuelo"),
                        Usuario_Nombre = m.Field<string>("Usuario_Nombre"),
                        Ciudad_Destino = m.Field<string>("Ciudad_Destino"),
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lstestados;
        }

        public bool Update_Vuelo(EntidadVuelosDetalles vueloDetalle)
        {
            bool result = false;
            try
            {
                result = bd_Vuelos.Update_Vuelo(vueloDetalle);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
