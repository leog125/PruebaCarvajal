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
    public class BD_Estados
    {
        private readonly ConexionSQL sql = new ConexionSQL();
        public bool Add_Estados(EntidadEstados estados)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Est_Nombre", estados.Est_Nombre));
                sqlParameters.Add(new SqlParameter("@Est_hailitado", estados.Est_hailitado));
                result = sql.Sqltospscalar("sp_Add_Estados", sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DataTable Getestados()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = sql.Sqldatatable("exec sp_GetEstados");
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
    }
}
