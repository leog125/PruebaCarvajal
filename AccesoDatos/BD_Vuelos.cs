using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class BD_Vuelos
    {
        private readonly ConexionSQL sql = new ConexionSQL();
        public bool Add_Vuelo(EntidadVuelos vuelo)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>
                {
                    new SqlParameter("@Ciu_Id_Origen", vuelo.Ciu_Id_Origen),
                    new SqlParameter("@Ciu_Id_Destino", vuelo.Ciu_Id_Destino),
                    new SqlParameter("@Vue_FechaSalida", vuelo.Vue_FechaSalida),
                    new SqlParameter("@Vue_FechaLlegada", vuelo.Vue_FechaLlegada),
                    new SqlParameter("@Arl_Id", vuelo.Arl_Id),
                    new SqlParameter("@Est_Id", vuelo.Est_Id),
                    new SqlParameter("@Usu_Id", vuelo.Usu_Id)
                };
                result = sql.Sqltospscalar("sp_Add_Vuelos", sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DataTable GetVuelos()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = sql.Sqldatatable("exec sp_GetVuelos");
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public bool Update_Vuelo(EntidadVuelosDetalles vueloDetalle)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>
                {
                    new SqlParameter("@Vuelo_ID", vueloDetalle.Vuelo_ID),
                    new SqlParameter("@Fecha_Llegada", vueloDetalle.Fecha_Llegada),
                    new SqlParameter("@Fecha_Salida", vueloDetalle.Fecha_Salida),
                    new SqlParameter("@Aerolinea_Nombre", vueloDetalle.Aerolinea_Nombre),
                    new SqlParameter("@Ciudad_Origen", vueloDetalle.Ciudad_Origen),
                    new SqlParameter("@Estado_Vuelo", vueloDetalle.Estado_Vuelo),
                    new SqlParameter("@Ciudad_Destino", vueloDetalle.Ciudad_Destino)
                };
                result = sql.Sqltospscalar("sp_UpdateVuelo", sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
