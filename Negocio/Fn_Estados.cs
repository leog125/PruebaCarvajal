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
    public class Fn_Estados
    {
        readonly BD_Estados bd_Estados = new BD_Estados();
        public bool Add_Estado(EntidadEstados estado)
        {
            bool result = false;
            try
            {
                result = bd_Estados.Add_Estados(estado);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public List<EntidadEstados> Getestados()
        {
            List<EntidadEstados> lstestados = new List<EntidadEstados>();
            try
            {
                DataTable dt = new DataTable();
                dt = bd_Estados.Getestados();
                if (dt.Rows.Count > 0)
                {
                    lstestados = dt.AsEnumerable().Select(m => new EntidadEstados()
                    {
                        Est_Id = m.Field<int>("Est_Id"),
                        Est_Nombre = m.Field<string>("Est_Nombre"),
                        Est_hailitado = m.Field<bool>("Est_hailitado"),
                    }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lstestados;
        }

    }
}
