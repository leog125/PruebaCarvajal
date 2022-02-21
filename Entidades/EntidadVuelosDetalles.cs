using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadVuelosDetalles
    {
        public int Vuelo_ID { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public int Numero_Vuelo { get; set; }
        public string Aerolinea_Nombre { get; set; }
        public string Ciudad_Origen { get; set; }
        public string Estado_Vuelo { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Ciudad_Destino { get; set; }
    }
}
