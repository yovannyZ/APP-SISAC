using AppSISAC.util;
using SISAC.DATOS.dao;
using SISAC.DATOS.Exceptions;
using SISAC.DATOS.Modelo;
using SISAC.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSISAC.Formulario
{
    public partial class FrmPersonal : Form
    {
        #region .VARIABLES. 
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        List<Personal> listaPersonal = new List<Personal>();
        private PersonalN personalN = null;
        private UbigeoN ubigeoN = new UbigeoN();
        private PersonalN PersonalN
        {
            get
            {
                if (personalN == null)
                    personalN = new PersonalN();
                return personalN;
            }
        }

        #endregion
        public FrmPersonal()
        {
            InitializeComponent();
            LlenarGrid(ObtenerLista());
            LlenarComboDepartamento();
        }


        #region .METODOS.

        private void LlenarGrid(List<Personal> lista)
        {
            dgvListado.AutoGenerateColumns = false;
            dgvListado.DataSource = null;
            dgvListado.DataSource = lista;     
        }

        private List<Personal> ObtenerLista()
        {
            try
            {
                listaPersonal = PersonalN.Listar().ToList();
            }
            catch (DataAccessException daex)
            {
                Util.MensajeError(daex.Message);
            }
            catch (BusinessLogicException blex)
            {
                Util.MensajeError(blex.Message);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                Util.MensajeError("Ocurrio un error, al listar algunos campos");
            }

            return listaPersonal;
        }
        private void FiltrarGrid(string filtro)
        {
            if (filtro.Trim() == "")
            {
                LlenarGrid(listaPersonal);
                return;
            }

            List<Personal> listaFiltrada = new List<Personal>(); 

            if(this.rbtCodigo.Checked)
                listaFiltrada = listaPersonal.Where(x => x.Id.ToString().Contains(filtro.Trim())).ToList();
            else if(this.rbtDni.Checked)
                listaFiltrada = listaPersonal.Where(x => x.Dni.Contains(filtro.Trim())).ToList();
            else if (this.rbtNombreApellido.Checked)
                listaFiltrada = listaPersonal.Where(x => x.NombreCompleto.ToUpper().Contains(filtro.ToUpper().Trim())).ToList();
            else if (this.rbtUsuario.Checked)
                listaFiltrada = listaPersonal.Where(x => x.Usuario.ToUpper().Contains(filtro.ToUpper().Trim())).ToList();

            LlenarGrid(listaFiltrada);   
        }

        private void ActivarFiltro(object sender)
        {
            RadioButton rb = sender as RadioButton;
            this.txtFlitro.Enabled = rb.Checked;
            this.btnBuscar.Enabled = rb.Checked;
        }

        private void LlenarComboDepartamento()
        {
            try
            {
                cboDepartamento.DataSource = ubigeoN.ListarDepartamentos();
                cboDepartamento.DisplayMember = "Departamento";
                cboDepartamento.ValueMember = "Id";
            }
            catch (DataAccessException daex)
            {
                Util.MensajeError(daex.Message);
            }
            catch (BusinessLogicException blex)
            {
                Util.MensajeError(blex.Message);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message,ex);
                Util.MensajeError("Ocurrio un error, al listar algunos campos");
            }
           
        }

        private void LlenarComboProvincia(string idDepartamento)
        {
            try
            {
                cboProvincia.DataSource = ubigeoN.ListarProvincias(idDepartamento);
                cboProvincia.DisplayMember = "Provincia";
                cboProvincia.ValueMember = "Id";
            }
            catch (DataAccessException daex)
            {
                Util.MensajeError(daex.Message);
            }
            catch (BusinessLogicException blex)
            {
                Util.MensajeError(blex.Message);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                Util.MensajeError("Ocurrio un error, al listar algunos campos");
            }
           
        }

        private void LlenarComboDistrito(string idProvincia)
        {
            try
            {
                cboDistrito.DataSource = ubigeoN.ListarDistritos(idProvincia);
                cboDistrito.DisplayMember = "Distrito";
                cboDistrito.ValueMember = "Id";
            }
            catch (DataAccessException daex)
            {
                Util.MensajeError(daex.Message);
            }
            catch (BusinessLogicException blex)
            {
                Util.MensajeError(blex.Message);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                Util.MensajeError("Ocurrio un error, al listar algunos campos");
            }
            
        }

        private void GuardarActualizarPersonal()
        {
            Personal personal = new Personal();
            personal.Nombres = this.txtNombres.Text;
            personal.ApPaterno = this.TxtApPaterno.Text;
            personal.ApMaterno = this.txtApMaterno.Text;
            personal.Clave = this.txtContrasena.Text;
            personal.Direccion = this.txtDireccion.Text;
            personal.Dni= this.txtDNI.Text;
            personal.Estado = true;
            personal.UsuFecha = DateTime.Now;
            personal.UsuLogin = "ADMIN ";
            personal.Usuario = this.txtUsuario.Text;
            string codUbigeo = cboDistrito.SelectedValue.ToString();

            try
            {
                PersonalN.Guardar(personal, codUbigeo);
                Util.MensajeExito("El registro se guardó con éxito");
            }
            catch (DataAccessException daex)
            {
                Util.MensajeError(daex.Message);
            }
            catch (BusinessLogicException blex)
            {
                Util.MensajeError(blex.Message);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                Util.MensajeError("Ocurrio un error, al guardar el registro");
            }
           

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string filtro = this.txtFlitro.Text;
            FiltrarGrid(filtro);
        }

        private void txtFlitro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                btnBuscar.PerformClick();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFiltro(sender);
        }

        private void rbtNombreApellido_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFiltro(sender);
        }

        private void rbtDni_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFiltro(sender);
        }

        private void rbtUsuario_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFiltro(sender);
        }

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
               this.txtContrasena.PasswordChar=this.chkMostrarContraseña.Checked ? '\0' : '*' ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarActualizarPersonal();
        }

        private void cboDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            string idDepartamento = cboDepartamento.SelectedValue.ToString();
            LlenarComboProvincia(idDepartamento);
        }

        private void cboProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedIndex != -1)
            {
                string idProvincia = cboProvincia.SelectedValue.ToString();
                LlenarComboDistrito(idProvincia);
            }

        }



    }
}
