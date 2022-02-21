using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ConexionSQL
    {
        public SqlConnection conn;

        private void OpenConection()
        {
            conn = new SqlConnection
            {
                ConnectionString = @"Data Source =LAPTOP-5BUGCH90\SQLEXPRESS; Initial Catalog = PruebaCarvajal; user id = sa; password = leosql; Persist Security Info=true"
            };
            conn.Open();
        }

        private void CloseConection()
        {
            conn.Dispose();
            conn.Close();
        }

        private SqlCommand Command(string sql)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = conn,
                CommandText = sql
            };
            return command;
        }

        public DataTable Sqldatatable(string sql)
        {
            SqlDataAdapter adapt = new SqlDataAdapter();
            DataTable dt = new DataTable();
            OpenConection();
            adapt.SelectCommand = Command(sql);
            adapt.Fill(dt);
            CloseConection();
            return dt;
        }

        public int Sqltosql(string sql)
        {
            SqlCommand cmd;
            OpenConection();
            cmd = Command(sql);
            int obj = cmd.ExecuteNonQuery();
            cmd.Dispose();
            CloseConection();
            return obj;
        }

        public object Sqltoscalar(string sql)
        {
            SqlCommand cmd;
            OpenConection();
            cmd = Command(sql);
            object obj = cmd.ExecuteScalar();
            cmd.Dispose();
            CloseConection();
            return obj;
        }

        public bool Sqltospscalar(string sp_name, List<SqlParameter> sqlParameter)
        {
            bool result = false;
            try
            {
                OpenConection();
                using (SqlCommand cmd = new SqlCommand(sp_name, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var item in sqlParameter)
                    {
                        cmd.Parameters.Add(item.ParameterName, item.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
                CloseConection();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public DataTable Sqltospsdatatable(string sp_name, List<SqlParameter> sqlParameter)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlDataAdapter adapt = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sp_name, conn);
                command.CommandType = CommandType.StoredProcedure;
                foreach (var item in sqlParameter)
                {
                    command.Parameters.Add(item.ParameterName, item.Value);
                }
                adapt.SelectCommand = command;
                adapt.Fill(dt);
                CloseConection();
                
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

    }
}
