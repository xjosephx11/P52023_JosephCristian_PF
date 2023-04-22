using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_JosephCristian_PF
{
    public partial class FrmComprador : Form
    {

        private Logica.Models.Comprador MiCompradorLocal { get; set; }
        private DataTable ListaCompradores { get; set; }

















        public FrmComprador()
        {
            InitializeComponent();
            MiCompradorLocal = new Logica.Models.Comprador();
            ListaCompradores = new DataTable();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmComprador_Load(object sender, EventArgs e)
        {
            CargarListaDeCompradores();
            CargarListaTipoComprador();
            ActivarAgregar();
        }

        private void CargarListaDeCompradores()
        {
            ListaCompradores = new DataTable();

            string FiltroBusqueda = "";

            if (!String.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }
            if (CboxVerCompradoresActivos.Checked)
            {
                ListaCompradores = MiCompradorLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaCompradores = MiCompradorLocal.ListarInactivos(FiltroBusqueda);
            }
            DgListaComprador.DataSource = ListaCompradores;
        }

        private void CargarListaTipoComprador()
        {
            Logica.Models.TipoComprador MiComprador = new Logica.Models.TipoComprador();
            DataTable dt = new DataTable();

            dt = MiComprador.listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoComprador.ValueMember = "ID";
                CbTipoComprador.DisplayMember = "Descrip";
                CbTipoComprador.DataSource = dt;
                CbTipoComprador.SelectedIndex = -1;

            }


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgListaComprador.ClearSelection();
            ActivarAgregar();
        }

        private void LimpiarFormulario()
        {
            TxtCompradorID.Clear();
            TxtCompradorNombre.Clear();
            TxtCompradorCedula.Clear();
            TxtCompradorTelefono.Clear();
            TxtCompradorCorreo.Clear();

            CbTipoComprador.SelectedIndex = -1;

        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;

        }
        private void ActivarEditarElminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgListaComprador_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgListaComprador.ClearSelection();
        }

        private void DgListaComprador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgListaComprador.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgListaComprador.SelectedRows[0];

                int IDComprador = Convert.ToInt32(MiFila.Cells["CCodComprador"].Value);
                MiCompradorLocal = new Logica.Models.Comprador();

                MiCompradorLocal.CompradorID = IDComprador;

                MiCompradorLocal = MiCompradorLocal.ConsultarPorIDRetornaComprador();

                if (MiCompradorLocal != null && MiCompradorLocal.CompradorID > 0)
                {
                    TxtCompradorID.Text = Convert.ToString(MiCompradorLocal.CompradorID);
                    TxtCompradorNombre.Text = MiCompradorLocal.NombreComprador;
                    TxtCompradorCedula.Text = MiCompradorLocal.CedulaComprador;
                    TxtCompradorTelefono.Text = MiCompradorLocal.TelefonoComprador;
                    TxtCompradorCorreo.Text = MiCompradorLocal.CorreoComprador;

                    CbTipoComprador.SelectedValue = MiCompradorLocal.MiCompradorTipo.TipoCompradorID;

                    ActivarEditarElminar();

                }

            }
        }

        private bool ValidarDatosDigitados()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(TxtCompradorNombre.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de nombre del comprador no puede estar vacío.");
                TxtCompradorNombre.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(TxtCompradorCedula.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de Cedula del Comprador no puede estar vacío.");
                TxtCompradorCedula.Focus();
                return false;

            }

            if (!string.IsNullOrEmpty(TxtCompradorTelefono.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de Telefono del comprador no puede estar vacío.");
                TxtCompradorTelefono.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(TxtCompradorCorreo.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("El campo de Correo del comprador no puede estar vacío.");
                TxtCompradorCorreo.Focus();
                return false;
            }

            if (CbTipoComprador.SelectedIndex == 0 || CbTipoComprador.SelectedIndex == 1)
            {
                R = true;

            }
            else
            {
                MessageBox.Show("El campo de Tipo del comprador no puede estar vacío.");
                CbTipoComprador.Focus();
                return false;
            }




            return R;




        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool CedulaOK;
                bool EmailOK;

                MiCompradorLocal = new Logica.Models.Comprador();

                MiCompradorLocal.NombreComprador = TxtCompradorNombre.Text.Trim();
                MiCompradorLocal.CedulaComprador = TxtCompradorCedula.Text.Trim();
                MiCompradorLocal.TelefonoComprador = TxtCompradorTelefono.Text.Trim();
                MiCompradorLocal.CorreoComprador = TxtCompradorCorreo.Text.Trim();

                MiCompradorLocal.MiCompradorTipo.TipoCompradorID = Convert.ToInt32(CbTipoComprador.SelectedValue);

                CedulaOK = MiCompradorLocal.ConsultarPorCedula();

                EmailOK = MiCompradorLocal.ConsultarPorEmail();

                if (CedulaOK == false && EmailOK == false)
                {
                    string msg = string.Format("¿Está seguro que desea agregar al Comprador {0}?", MiCompradorLocal.NombreComprador);
                    DialogResult respuesta = MessageBox.Show(msg, "??", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiCompradorLocal.Agregar();
                        if (ok)
                        {
                            MessageBox.Show("Comprador guardado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeCompradores();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo agregar!", ":/", MessageBoxButtons.OK);
                        }
                    }







                }
                else
                {
                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un Comprador previamente almacenado con esa cedula!", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un Comprador previamente almacenado con ese correo!", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                }







            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                MiCompradorLocal.NombreComprador = TxtCompradorNombre.Text.Trim();
                MiCompradorLocal.CedulaComprador = TxtCompradorCedula.Text.Trim();
                MiCompradorLocal.TelefonoComprador = TxtCompradorTelefono.Text.Trim();
                MiCompradorLocal.CorreoComprador = TxtCompradorCorreo.Text.Trim();

                MiCompradorLocal.MiCompradorTipo.TipoCompradorID = Convert.ToInt32(CbTipoComprador.SelectedValue);

                if (MiCompradorLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el comprador?", "???",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiCompradorLocal.Editar())
                        {
                            MessageBox.Show("El comprador se modifico correctamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                        }
                        
                        
                    }

                }





            }

























        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiCompradorLocal.CompradorID > 0 && MiCompradorLocal.ConsultarPorID())
            {
                if (CboxVerCompradoresActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Está seguro de eliminar el comprador?", "???",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        if (MiCompradorLocal.Eliminar())
                        {
                            MessageBox.Show("El Comprador ha sido eliminado correctamente", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                           CargarListaDeCompradores();
                        }

                    }
                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro de activar el comprador?", "???",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (r == DialogResult.Yes)
                    {
                        if (MiCompradorLocal.Activar())
                        {
                            MessageBox.Show("El Comprador ha sido activado correctamente", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeCompradores();
                        }
                    }
                }


            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeCompradores();
        }

        private void CboxVerCompradoresActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeCompradores();

            if (CboxVerCompradoresActivos.Checked)
            {

                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";

            }



        }

     
    }
}
