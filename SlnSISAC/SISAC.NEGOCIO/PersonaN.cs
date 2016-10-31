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
    public class PersonaN
    {
        #region .DAO.


        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private CLienteDAO personaDAO = null;
        private CLienteDAO PersonaDAO
        {
            get
            {
                if (personaDAO == null)
                    personaDAO = new CLienteDAO();
                return personaDAO;
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
        public IList<Persona> Listar()
        {
            try
            {
                return PersonaDAO.ListarTodos();
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

    }
}
