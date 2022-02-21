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
    public class BD_Aerolinea
    {
        private readonly ConexionSQL sql = new ConexionSQL();
        public bool Add_Aerolinea(EntidadAerolinea aerolinea)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Alr_Nombre", aerolinea.Alr_Nombre));
                sqlParameters.Add(new SqlParameter("@Alr_Habilitada", aerolinea.Alr_Habilitada));
                result = sql.Sqltospscalar("sp_Add_Aerolinea", sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DataTable GetAerolineas()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = sql.Sqldatatable("exec sp_GetAerolineas");
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

    }
}
