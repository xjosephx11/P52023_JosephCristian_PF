using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoComprador
    {
        public int TipoCompradorID { get; set; }
        public string TipoCompradorDescripcion { get; set; }

        public DataTable listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();
            R = MiCnn.EjecutarSELECT("SPTipoCompradorListar");





            return R;
        }
    }
}
