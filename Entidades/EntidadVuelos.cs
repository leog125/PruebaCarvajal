using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadVuelos
    {
        public int Vue_Id { get; set; }
        public int Ciu_Id_Origen { get; set; }
        public int Ciu_Id_Destino { get; set; }
        public DateTime Vue_FechaSalida { get; set; }
        public DateTime Vue_FechaLlegada { get; set; }
        public int Vue_NumeroVuelo { get; set; }
        public int Arl_Id { get; set; }
        public int Est_Id { get; set; }
        public int Usu_Id { get; set; }
    }
}
