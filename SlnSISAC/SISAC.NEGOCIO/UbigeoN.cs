using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISAC.DATOS.dao;
using SISAC.DATOS.Modelo;

namespace SISAC.NEGOCIO
{
    public class UbigeoN
    {
        #region .DAO.

        private UbigeoDAO ubigeoDAO = null;
        private UbigeoDAO UbigeoDAO
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

        public List<Ubigeo> ListarDepartamentos()
        {
            return UbigeoDAO.ListarDepartamentos();
        }

        public List<Ubigeo> ListarProvincias(string idDepartamento)
        {
            return UbigeoDAO.ListarProvincias(idDepartamento);
        }

        public List<Ubigeo> ListarDistritos(string idProvincia)
        {
            return UbigeoDAO.ListarDistrito(idProvincia);
        }

        #endregion
    }
}
