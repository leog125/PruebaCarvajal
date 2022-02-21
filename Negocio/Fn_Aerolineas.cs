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
    public class Fn_Aerolineas
    {
        readonly BD_Aerolinea bd_Aerolinea = new BD_Aerolinea();
        public bool Add_Aerolinea(EntidadAerolinea aerolinea)
        {
            bool result = false;
            try
            {
                result = bd_Aerolinea.Add_Aerolinea(aerolinea);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public List<EntidadAerolinea> GetAerolineas()
        {
            List<EntidadAerolinea> lstestados = new List<EntidadAerolinea>();
            try
            {
                DataTable dt = new DataTable();
                dt = bd_Aerolinea.GetAerolineas();
                if (dt.Rows.Count > 0)
                {
                    lstestados = dt.AsEnumerable().Select(m => new EntidadAerolinea()
                    {
                        Alr_Id = m.Field<int>("Alr_Id"),
                        Alr_Nombre = m.Field<string>("Alr_Nombre"),
                        Alr_Habilitada = m.Field<bool>("Alr_Habilitada"),
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
