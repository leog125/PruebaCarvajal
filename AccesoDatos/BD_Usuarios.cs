using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class BD_Usuarios
    {
        private readonly ConexionSQL sql = new ConexionSQL();
        public bool Add_Usuario(EntidadUsuarios usuario)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Usu_Nombres", usuario.Usu_Nombres));
                sqlParameters.Add(new SqlParameter("@Usu_Email", usuario.Usu_Email));
                sqlParameters.Add(new SqlParameter("@Usu_Password", usuario.Usu_Password));
                sqlParameters.Add(new SqlParameter("@Usu_Habilitado", usuario.Usu_Habilitado));
                sqlParameters.Add(new SqlParameter("@Usu_FechaCreacion", usuario.Usu_FechaCreacion));
                result = sql.Sqltospscalar("sp_Add_Usuario", sqlParameters);
                
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DataTable ValidarUsuario(EntidadUsuarios usuario)
        {
            try
            {
                DataTable dt = new DataTable();
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Usu_Email", usuario.Usu_Email));
                sqlParameters.Add(new SqlParameter("@Usu_Password", usuario.Usu_Password));
                dt = sql.Sqltospsdatatable("sp_ValidarUsuario", sqlParameters);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
