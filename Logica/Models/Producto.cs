using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public string ProductoStock { get; set; }
        public string CostoUnitario { get; set; }
        public string PrecioVentaUnitario { get; set; }
        public bool Activo { get; set; }

        public CategoriaProducto MiCategoriaProducto { get; set;}


        public Producto() { 
        MiCategoriaProducto= new CategoriaProducto();
        }

        public bool Agregar()
        {
            bool R = false;




            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoNombre",this.ProductoNombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoCodigoBarras", this.ProductoCodigoBarras));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.ProductoStock));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CostoUnitario", this.CostoUnitario));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioVentaUnitario", this.PrecioVentaUnitario));

            MiCnn.ListaDeParametros.Add(new SqlParameter("CategoriaID",this.MiCategoriaProducto.CategoriaID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoAgregar");

            if (resultado > 0)
            {
                R = true;
            }


            return R;
        }

        public bool Editar()
        {
            bool R = false;


            Conexion MiCnn = new Conexion();

          MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoNombre", this.ProductoNombre));

          MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoCodigoBarras", this.ProductoCodigoBarras));

          MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.ProductoStock));

          MiCnn.ListaDeParametros.Add(new SqlParameter("@CostoUnitario", this.CostoUnitario));

          MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioVentaUnitario", this.PrecioVentaUnitario));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CategoriaID", this.MiCategoriaProducto.CategoriaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoModificar");
          

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoDesactivar");
            if (respuesta > 0)
            {
                R = true;
            }



            return R;
        }

        public bool Activar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));


            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoActivar");
            if (respuesta > 0)
            {
                R = true;
            }

            return R;







        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("ID",this.ProductoID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0 )
            {
                R = true;
            }



            return R;
        }

        public bool ConsultarPorCodigoBarras()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("CodigoBarras", this.ProductoCodigoBarras));
            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPProductoConsultarPorCodigoBarras");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }





            return R;
        }


        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable r = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            r = MiCnn.EjecutarSELECT("SPProductosListar");



            return r;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            //en este caso como el procedimiento almacenado tiene un parametro
            //debemos definir ese parametro en la lista de parametros del objeto de conexión

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = MiCnn.EjecutarSELECT("SPProductosListar");

            return R;


        }

        public Producto ConsultarPorIDRetornaProducto()
        {

            Producto R = new Producto();

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));
          
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                
                DataRow dr = dt.Rows[0];

                R.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                R.ProductoNombre = Convert.ToString(dr["ProductoNombre"]);
                R.ProductoCodigoBarras = Convert.ToString(dr["ProductoCodigoBarras"]);
                R.CostoUnitario = Convert.ToString(dr["CostoUnitario"]);
                R.ProductoStock = Convert.ToString(dr["CantidadStock"]);
                R.PrecioVentaUnitario = Convert.ToString(dr["PrecioVentaUnitario"]);


                //composiciones
                R.MiCategoriaProducto.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                R.MiCategoriaProducto.CategoriaDescripcion = Convert.ToString(dr["CategoriaDescripcion"]);


            }

            return R;


        }























    }
}
