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
    /// <summary>
    /// Clase que contiene la lógica del negocio de la Clase Personal
    /// </summary>
    public class PersonalN
    {
        #region .Variables.
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private PersonalDAO personalDAO = null;
        private PersonalDAO PersonalDAO
        {
            get
            {
                if (personalDAO == null)
                    personalDAO = new PersonalDAO();
                return personalDAO;
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

        #region .METODOS.

        public IList<Personal> Listar()
        {
            try
            {
                return PersonalDAO.ListarTodos();
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

        public void Guardar(Personal personal, string codUbigeo)
        {
            Ubigeo ubigeo = UbigeoDAO.Obtener(codUbigeo);
            personal.Ubigeo = ubigeo;
            PersonalDAO.Crear(personal);
        }

        #endregion
    }
}
