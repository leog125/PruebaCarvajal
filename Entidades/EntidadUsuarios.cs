using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadUsuarios
    {
        public int Usu_Id { get; set; }
        public string Usu_Nombres { get; set; }
        public string Usu_Email { get; set; }
        public string Usu_Password { get; set; }
        public bool Usu_Habilitado { get; set; }
        public DateTime Usu_FechaCreacion { get; set; }
    }
}
