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
    public class Comprador
    {

        public int CompradorID { get; set; }
        public string NombreComprador { get; set; }
        public string CedulaComprador { get; set; }
        public string TelefonoComprador { get; set; }
        public string CorreoComprador { get; set; }
        public TipoComprador MiCompradorTipo { get; set; }


        public Comprador() { 
        
        MiCompradorTipo= new TipoComprador();
        
        }


        public bool Agregar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreComprador", this.NombreComprador));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CedulaComprador", this.CedulaComprador));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TelefonoComprador", this.TelefonoComprador));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoComprador", this.CorreoComprador));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@CompradorTipoID", this.MiCompradorTipo.TipoCompradorID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCompradorAgregar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreComprador", this.NombreComprador));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CedulaComprador", this.CedulaComprador));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TelefonoComprador", this.TelefonoComprador));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoComprador", this.CorreoComprador));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@CompradorTipoID", this.MiCompradorTipo.TipoCompradorID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CompradorID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCompradorEditar");

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CompradorID));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPCompradorDesactivar");
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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CompradorID
                ));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPCompradorActivar");
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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CompradorID));
           
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCompradorConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }



            return R;
        }

        public Comprador ConsultarPorIDRetornaComprador()
        {

            Comprador R = new Comprador();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CompradorID));
            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPCompradorConsultarPorID");


            if (dt != null && dt.Rows.Count > 0)
            {
                //Esta consulta deberia tener solo un registro 
                //se crea un objeto de tipo DataRow para capturar la info contenida en
                //index 0 del dt(DataTable)
                DataRow dr = dt.Rows[0];

                R.CompradorID = Convert.ToInt32(dr["CompradorID"]);
                R.NombreComprador = Convert.ToString(dr["NombreComprador"]);
                R.CedulaComprador = Convert.ToString(dr["CedulaComprador"]);
                R.TelefonoComprador = Convert.ToString(dr["TelefonoComprador"]);
                R.CorreoComprador = Convert.ToString(dr["CorreoComprador"]);



                //composiciones

                R.MiCompradorTipo.TipoCompradorID = Convert.ToInt32(dr["CompradorTipoID"]);
                R.MiCompradorTipo.TipoCompradorDescripcion = Convert.ToString(dr["DescripcionTipoComprador"]);

            }


            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R =false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.CedulaComprador));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPCompradorConsultarPorCedula");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;

            }



            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.CorreoComprador));


            DataTable consulta = new DataTable();


            consulta = MiCnn.EjecutarSELECT("SPCompradorConsultarPorEmail");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;

            }


            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = MiCnn.EjecutarSELECT("SPCompradorListar");



            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable r = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            r = MiCnn.EjecutarSELECT("SPCompradorListar");





            return r;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasenia)
        {
            Usuario r = new Usuario();

            return r;
        }



























    }
}
