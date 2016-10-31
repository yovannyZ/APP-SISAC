using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISAC.NEGOCIO;
using SISAC.DATOS.Modelo;
using SISAC.DATOS.util;
using AppSISAC.util;
using SISAC.DATOS.Exceptions;


namespace AppSISAC.Formulario
{
    public partial class FrmCompania : Form
    {
        private UbigeoN ubigeoN = new UbigeoN();
        private CompaniaN companiaN = new CompaniaN();
        private int idCompania=-1;
        private int indexDgvCuenta = -1;
        private Compania compania;
        private List<Cuentas> listaCuentas = new List<Cuentas>();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FrmCompania()
        {
            InitializeComponent();
            try
            {
                LlenarComboDepartamento();
                ListarCompanias();
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
           
            this.txtRazonSocial.Focus();
            dgvCuentas.AutoGenerateColumns = false; 
        }

        

        private void LlenarComboDepartamento()
        {
              cboDepartamento.DataSource = ubigeoN.ListarDepartamentos();
              cboDepartamento.DisplayMember = "Departamento";
              cboDepartamento.ValueMember = "Id";  
        }

        private void LlenarComboProvincia(string idDepartamento)
        {
            cboProvincia.DataSource = ubigeoN.ListarProvincias(idDepartamento);
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.ValueMember = "Id";
        }

        private void LlenarComboDistrito(string idProvincia)
        {
            cboDistrito.DataSource = ubigeoN.ListarDistritos(idProvincia);
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.ValueMember = "Id";
        }

        private void ListarCompanias()
        {
            this.dgvListado.AutoGenerateColumns = false;
            this.dgvListado.DataSource = companiaN.Listar();
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

        private void AgregarModificarCompania() 
        {   
            compania = new Compania();
            compania.Id =this.txtId.Text == "" ? 0:Convert.ToInt32(this.txtId.Text);
            compania.RazonSocial = this.txtRazonSocial.Text;
            compania.Ruc = this.txtRuc.Text;
            compania.Direccion = this.txtDireccion.Text;
            compania.Telefono1 = this.txtTelefono1.Text;
            compania.Telefono2 = this.txtTelefono2.Text;
            compania.Correo1 = this.txtEmail1.Text;
            compania.Correo2 = this.txtEmail2.Text;
            compania.UsuLogin= "ADMIN";
            compania.UsuFecha = DateTime.Now;
            compania.Estado = true;
            compania.ListaCuentas = listaCuentas;

            try
            {
                if (compania.Id == 0)
                    companiaN.CrearCompania(compania, this.cboDistrito.SelectedValue.ToString());
                else
                    companiaN.ModificarCompania(compania, this.cboDistrito.SelectedValue.ToString());

                Util.MensajeExito("Se guardo el registro");
                Util.LimpiarTextBox("tabMantenimiento", tbCompania);
                Util.LimpiarTextBox("tabCuentas", tbCompania);
                ListarCompanias();
                idCompania = -1;
                listaCuentas = null;
                dgvCuentas.DataSource = null;

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
                Util.MensajeError("Ocurrio un error, no se pudo guardar el registro");
            }
        }

        private void PasarDatos()
        {
            if (idCompania == -1)
            {
                Util.MensajeError("Seleccione un registro");
                return;
            }
            compania = new Compania();
            compania = companiaN.ObtenerCompania(idCompania);
            this.txtRazonSocial.Text = compania.RazonSocial;
            this.txtRuc.Text = compania.Ruc;
            this.txtDireccion.Text = compania.Direccion;
            this.txtEmail1.Text = compania.Correo1;
            this.txtEmail2.Text = compania.Correo2;
            this.txtTelefono1.Text = compania.Telefono1;
            this.txtTelefono2.Text = compania.Telefono2;
            this.txtId.Text = compania.Id.ToString();
            this.cboDepartamento.SelectedValue = compania.Ubigeo.Id.Substring(0, 2)+"0000";
            this.cboProvincia.SelectedValue = compania.Ubigeo.Id.Substring(0, 4)+"00";
            this.cboDistrito.SelectedValue = compania.Ubigeo.Id.ToString();
            listaCuentas = compania.ListaCuentas.ToList();
            this.dgvCuentas.DataSource = null;
            this.dgvCuentas.DataSource = listaCuentas;
            this.tbCompania.SelectedIndex = 1;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarModificarCompania();
            this.txtRazonSocial.Focus();

           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PasarDatos();
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
             idCompania = Convert.ToInt32(this.dgvListado.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCompania == -1)
            {
                Util.MensajeError("Seleccione un registro");
                return;
            }

            if (MessageBox.Show(this, Global.mensajeAdvertencia, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                companiaN.EliminarCompania(idCompania, "ADMIN");
                MessageBox.Show(this, Global.mensajeEliminado, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarCompanias();
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
                Util.MensajeError("Ocurrio un error, no se pudo eliminar el registro");
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            AgregarCuentas();
        }

        private void AgregarCuentas()
        {
            string banco = this.txtBanco.Text;
            string descripcion = this.txtDescripcion.Text;
            string nroCuenta = this.txtNroCuenta.Text;
            string codInter = this.txtCodigoInter.Text;
            string moneda = this.cboMoneda.SelectedItem.ToString();

            Cuentas cuenta = new Cuentas();
            cuenta.Banco = banco;
            cuenta.Descripcion = descripcion;
            cuenta.NroCuenta = nroCuenta;
            cuenta.CodInterbancario = codInter;
            cuenta.Moneda = moneda;
            cuenta.UsuFecha = DateTime.Now;
            cuenta.UsuLogin = "ADMIN";

            listaCuentas.Add(cuenta);
            dgvCuentas.DataSource = null;
            dgvCuentas.DataSource = listaCuentas;
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            EliminarCuenta();
        }

        private void EliminarCuenta()
        {
            listaCuentas.RemoveAt(indexDgvCuenta);
            dgvCuentas.DataSource = null;
            dgvCuentas.DataSource = listaCuentas;
        }

        private void dgvCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexDgvCuenta = e.RowIndex;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            tbCompania.SelectedIndex=1;
        }
    }    
}
