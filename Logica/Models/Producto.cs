using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {

        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoCodigoBarras { get; set; }
        public int ProductoStock { get; set; }
        public int CostoUnitario { get; set; }
        public int PrecioVentaUnitario { get; set; }
        public bool Activo { get; set; }

        CategoriaProducto MiCategoriaProducto { get; set;}


        public Producto() { 
        MiCategoriaProducto= new CategoriaProducto();
        }

        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorNombre()
        {
            bool R = false;

            return R;
        }


        public DataTable ListarActivos()
        {
            DataTable r = new DataTable();

            return r;
        }

        public DataTable ListarInactivos()
        {
            DataTable r = new DataTable();

            return r;
        }
























    }
}
