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
    public class Fn_Usuarios
    {
        readonly BD_Usuarios bd_Usuarios = new BD_Usuarios();
        public bool Add_Usuario(EntidadUsuarios usuario)
        {
            bool result = false;
            try
            {
                result = bd_Usuarios.Add_Usuario(usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public EntidadUsuarios ValidarUsuario(EntidadUsuarios usuario)
        {
            try
            {
                DataTable dt = new DataTable();
                EntidadUsuarios result_usuario = new EntidadUsuarios();
                dt = bd_Usuarios.ValidarUsuario(usuario);
                if (dt.Rows.Count > 0)
                {
                    result_usuario.Usu_Id = (int)dt.Rows[0]["Usu_Id"];
                    result_usuario.Usu_Nombres = dt.Rows[0]["Usu_Nombres"].ToString();
                    result_usuario.Usu_Email = dt.Rows[0]["Usu_Email"].ToString();
                    result_usuario.Usu_Password = dt.Rows[0]["Usu_Password"].ToString();
                    result_usuario.Usu_Habilitado = (bool)dt.Rows[0]["Usu_Habilitado"];
                    result_usuario.Usu_FechaCreacion = (DateTime)dt.Rows[0]["Usu_FechaCreacion"];
                }
                return result_usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
