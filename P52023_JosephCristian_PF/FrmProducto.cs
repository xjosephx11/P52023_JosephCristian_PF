using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_JosephCristian_PF
{
    public partial class FrmProducto : Form
    {
        private Logica.Models.Producto MiProductoLocal { get; set; }

        private DataTable ListaProductos { get; set; }

        public FrmProducto()
        {
            InitializeComponent();
            MiProductoLocal = new Logica.Models.Producto();
            ListaProductos = new DataTable();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

            CargarListadeCategorias();
            CargarListaDeProductos();
            

        }

        private void CargarListaDeProductos()
        {
            ListaProductos = new DataTable();

            string FiltroBusqueda = "";

            if (!String.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }

            if (CboxVerActivos.Checked)
            {
                ListaProductos = MiProductoLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaProductos = MiProductoLocal.ListarInactivos(FiltroBusqueda);
            }
            DgLista.DataSource = ListaProductos;

        }

        private void CargarListadeCategorias()
        {
            Logica.Models.CategoriaProducto MiCategoria = new Logica.Models.CategoriaProducto();
            DataTable dt = new DataTable();
            dt = MiCategoria.listar();
            if (dt != null && dt.Rows.Count > 0)
            {
                CbCategoriaProducto.ValueMember = "ID";
                CbCategoriaProducto.DisplayMember = "Descrip";
                CbCategoriaProducto.DataSource = dt;
                CbCategoriaProducto.SelectedIndex = -1;



            }



        }




        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }

        private void LimpiarFormulario()
        {
            TxtProductoID.Clear();
            TxtProductoNombre.Clear();
            TxtProductoCodigoBarras.Clear();
            TxtProductoStock.Clear();
            TxtProductoCostoUnitario.Clear();
            TxtProductoPrecioVentaUnitario.Clear();

            CbCategoriaProducto.SelectedIndex = -1;



        }
        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;

        }
        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }


        private bool ValidarDatosDigitados()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de nombre del producto no puede estar vacío.");
                TxtProductoNombre.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de Codigo de barras del producto no puede estar vacío.");
                TxtProductoCodigoBarras.Focus();
                return false;

            }

            if (!string.IsNullOrEmpty(TxtProductoStock.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de Stock del producto no puede estar vacío.");
                TxtProductoStock.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(TxtProductoCostoUnitario.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de Precio de Venta del producto no puede estar vacío.");
                TxtProductoPrecioVentaUnitario.Focus();
                return false;
            }
            if (CbCategoriaProducto.SelectedIndex == 0 || CbCategoriaProducto.SelectedIndex == 1)
            {
                R = true;

            }
            else
            {
                MessageBox.Show("El campo de Categoria del producto no puede estar vacío.");
                CbCategoriaProducto.Focus();
                return false;
            }




            return R;
        }

        private void DgLista_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                int IDProducto = Convert.ToInt32(MiFila.Cells["CProductoID"].Value);

                MiProductoLocal = new Logica.Models.Producto();

                MiProductoLocal.ProductoID = IDProducto;

                MiProductoLocal = MiProductoLocal.ConsultarPorIDRetornaProducto();

                if (MiProductoLocal != null && MiProductoLocal.ProductoID > 0)
                {
                    TxtProductoID.Text = Convert.ToString(MiProductoLocal.ProductoID);
                    TxtProductoNombre.Text = MiProductoLocal.ProductoNombre;
                    TxtProductoCodigoBarras.Text = MiProductoLocal.ProductoCodigoBarras;
                    TxtProductoStock.Text = MiProductoLocal.ProductoStock;
                    TxtProductoCostoUnitario.Text = MiProductoLocal.CostoUnitario;
                    TxtProductoPrecioVentaUnitario.Text = MiProductoLocal.PrecioVentaUnitario;

                    CbCategoriaProducto.SelectedValue = MiProductoLocal.MiCategoriaProducto.CategoriaID;
                    

                    ActivarEditarEliminar();

                }





            }
        }

        private void DgLista_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool NombreOK;
                bool CodigoBarrasOK;

                MiProductoLocal = new Logica.Models.Producto();


                MiProductoLocal.ProductoNombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.ProductoCodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.ProductoStock = TxtProductoStock.Text.Trim();
                MiProductoLocal.CostoUnitario = TxtProductoCostoUnitario.Text.Trim();
                MiProductoLocal.PrecioVentaUnitario = TxtProductoPrecioVentaUnitario.Text.Trim();

                MiProductoLocal.MiCategoriaProducto.CategoriaID = Convert.ToInt32(CbCategoriaProducto.SelectedValue);

                NombreOK = MiProductoLocal.ConsultarPorID();
                CodigoBarrasOK = MiProductoLocal.ConsultarPorCodigoBarras();

                if (NombreOK == false && CodigoBarrasOK == false)
                {

                    string msg = string.Format("¿Está seguro que desea agregar al Producto {0}?", MiProductoLocal.ProductoNombre);
                    DialogResult respuesta = MessageBox.Show(msg, "??", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProductoLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Producto guardado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeProductos();
                        }
                        else
                        {

                            MessageBox.Show("El Producto no se pudo agregar!", ":/", MessageBoxButtons.OK);
                        }
                    }

                }
                else
                {
                    if (NombreOK)
                    {
                        MessageBox.Show("Ya existe un Producto previamente almacenado con ese nombre!", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                    if (CodigoBarrasOK)
                    {
                        MessageBox.Show("Ya existe un Producto previamente almacenado con esa cedula!", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                }












            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            { 
                MiProductoLocal.ProductoNombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.ProductoCodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.ProductoStock = TxtProductoStock.Text.Trim();
                MiProductoLocal.CostoUnitario = TxtProductoCostoUnitario.Text.Trim();
                MiProductoLocal.PrecioVentaUnitario = TxtProductoPrecioVentaUnitario.Text.Trim();

                MiProductoLocal.MiCategoriaProducto.CategoriaID = Convert.ToInt32(CbCategoriaProducto.SelectedValue);

                if (MiProductoLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el producto?", "???",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Editar())
                        {
                            MessageBox.Show("El producto se modifico correctamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProductos();
                             

                        }
                    }
                }
            }        
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiProductoLocal.ProductoID > 0 && MiProductoLocal.ConsultarPorID())
            {
                if (CboxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Está seguro de eliminar el producto?", "???",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Eliminar())
                        {
                            MessageBox.Show("El Producto ha sido eliminado correctamente", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProductos();
                          
                        }

                    }
                }
                else
                {
                    //ACTIVAR PRODUCTO
                    DialogResult r = MessageBox.Show("¿Está seguro de activar el producto?", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Activar())
                        {

                            MessageBox.Show("El Producto ha sido activado correctamente", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProductos();
                        }
                    }


                }









            }
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeProductos();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
            }




        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeProductos();
        }

        private void DgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
