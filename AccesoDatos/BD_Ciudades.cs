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
    public class BD_Ciudades
    {
        private readonly ConexionSQL sql = new ConexionSQL();
        public bool Add_Ciudades(EntidadCiudades ciudades)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Ciu_Nombre", ciudades.Ciu_Nombre));
                sqlParameters.Add(new SqlParameter("@Ciu_Habilitada", ciudades.Ciu_Habilitado));
                result = sql.Sqltospscalar("sp_Add_Ciudades", sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DataTable GetCiudades()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = sql.Sqldatatable("exec sp_GetCiudades");
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
    }
}
