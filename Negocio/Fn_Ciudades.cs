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
    public class Fn_Ciudades
    {
        readonly BD_Ciudades bd_Ciudades = new BD_Ciudades();
        public bool Add_Ciudad(EntidadCiudades ciudad)
        {
            bool result = false;
            try
            {
                result = bd_Ciudades.Add_Ciudades(ciudad);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public List<EntidadCiudades> GetCiudades()
        {
            List<EntidadCiudades> lstciudades = new List<EntidadCiudades>();
            try
            {
                DataTable dt = new DataTable();
                dt = bd_Ciudades.GetCiudades();
                if (dt.Rows.Count > 0)
                {
                    lstciudades = dt.AsEnumerable().Select(m => new EntidadCiudades()
                    {
                        Ciu_Id = m.Field<int>("Ciu_Id"),
                        Ciu_Nombre = m.Field<string>("Ciu_Nombre"),
                        Ciu_Habilitado = m.Field<bool>("Ciu_Habilitado"),
                    }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lstciudades;
        }
    }
}
