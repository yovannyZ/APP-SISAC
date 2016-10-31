using log4net;
using SISAC.DATOS.dao;
using SISAC.DATOS.Exceptions;
using SISAC.DATOS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.NEGOCIO
{
    public class CompaniaN
    {
        #region .DAO.
        
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        private CompaniaDAO companiaDAO = null;
        private CompaniaDAO CompaniaDAO
        {
            get
            {
                if (companiaDAO == null)
                    companiaDAO = new CompaniaDAO();
                return companiaDAO;
            }
        }

        private UbigeoDAO ubigeoDAO = null;
        public UbigeoDAO UbigeoDAO
        {
            get
            {
                if (ubigeoDAO == null)
                    ubigeoDAO = new UbigeoDAO();
                return ubigeoDAO;
            }

        }

        #endregion

        #region .LOGICA.

        //Crear Compania
        public void CrearCompania(Compania compania,string codUbigeo)
        {
            try
            {
                compania.Ubigeo = UbigeoDAO.Obtener(codUbigeo);
                CompaniaDAO.Crear(compania);
            }
            catch (DataAccessException daex)
            {
                throw daex;
            }
            catch(Exception ex)
            {
                log.Error(ex.Message,ex);
                throw new BusinessLogicException("Ocurrio un error, no se pudo guardar el registro",ex);
            }
           
        }

        //Modificar Compania
        public bool ModificarCompania(Compania compania, string codUbigeo)
        {
            try
            {
                compania.Ubigeo = UbigeoDAO.Obtener(codUbigeo);
                return CompaniaDAO.Modificar(compania);
            }
            catch (DataAccessException daex)
            {
                throw daex;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw new BusinessLogicException("Ocurrio un error, no se pudo modificar el registro", ex);
            }
            
        }

        //Eliminar Compania

        public bool EliminarCompania(int idCompania, string usuLogin)
        {
            try
            {
                Compania compania = CompaniaDAO.Obtener(idCompania);
                compania.Estado = false;
                compania.UsuLogin = usuLogin;
                return CompaniaDAO.Modificar(compania);
            }
            catch (DataAccessException daex)
            {
                throw daex;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw new BusinessLogicException("Ocurrio un error, no se pudo eliminar el registro", ex);
            }
          
        }

        //Listar Compañias
        public IList<Compania> Listar()
        {
            try
            {
                return CompaniaDAO.ListarTodos();
            }
            catch (DataAccessException daex)
            {
                throw daex;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw new BusinessLogicException("Ocurrio un error, no se pudo listar los registros", ex);
            }
           
        }

        //Obtener Compañia
        public Compania ObtenerCompania(int idCompania)
        {
            try
            {
                return CompaniaDAO.Obtener(idCompania);
            }
            catch (DataAccessException daex)
            {
                throw daex;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw new BusinessLogicException("Ocurrio un error, no se pudo listar el registro", ex);
            }
           
        }

        #endregion
    }
}
