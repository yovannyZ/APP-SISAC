using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using SISAC.DATOS.Modelo;
using log4net;
using SISAC.DATOS.Exceptions;

namespace SISAC.DATOS.dao
{
    public class UbigeoDAO : BaseDAO<Ubigeo, string>
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public virtual List<Ubigeo> ListarDepartamentos()
        {
            List<Ubigeo> listaUbigeo = new List<Ubigeo>();
            try
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                   
                    Ubigeo ubigeo;
                    IList<Object[]> lista = sesion.CreateQuery("select u.Departamento ,u.Id from  Ubigeo as u  where substring(u.Id,3,4)='0000'").List<Object[]>();
                    foreach (var item in lista)
                    {
                        ubigeo = new Ubigeo();
                        ubigeo.Departamento = item[0].ToString();
                        ubigeo.Id = item[1].ToString();
                        listaUbigeo.Add(ubigeo);
                    }
                   
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message,ex);
                throw new DataAccessException("Ocurrio un error, no se pudo listar los departamentos",ex);
            }
            return listaUbigeo;
           
        }

        public virtual List<Ubigeo> ListarProvincias(string idDepartamento)
        {
            try
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    List<Ubigeo> listaUbigeo = new List<Ubigeo>();
                    Ubigeo ubigeo;
                    IList<Object[]> lista = sesion.CreateQuery("select u.Provincia ,u.Id from  Ubigeo as u  where substring(u.Id,5,2)='00' AND substring(u.Id,1,2) = :idDepartamento AND substring(u.Id,3,2) <> '00'").SetString("idDepartamento", idDepartamento.Substring(0, 2)).List<Object[]>();
                    foreach (var item in lista)
                    {
                        ubigeo = new Ubigeo();
                        ubigeo.Provincia = item[0].ToString();
                        ubigeo.Id = item[1].ToString();
                        listaUbigeo.Add(ubigeo);
                    }
                    return listaUbigeo;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw new DataAccessException("Ocurrio un error, no se pudo listar las provincias", ex);
            }
           
        }

        public virtual List<Ubigeo> ListarDistrito(string idProvincia)
        {
            try
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    List<Ubigeo> listaUbigeo = new List<Ubigeo>();
                    Ubigeo ubigeo;
                    IList<Object[]> lista = sesion.CreateQuery("select u.Distrito ,u.Id from  Ubigeo as u  where substring(u.Id,1,4)= :idProvincia  AND substring(u.Id,5,2) <> '00'").SetString("idProvincia", idProvincia.Substring(0, 4)).List<Object[]>();
                    foreach (var item in lista)
                    {
                        ubigeo = new Ubigeo();
                        ubigeo.Distrito = item[0].ToString();
                        ubigeo.Id = item[1].ToString();
                        listaUbigeo.Add(ubigeo);
                    }
                    return listaUbigeo;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw new DataAccessException("Ocurrio un error, no se pudo listar los distritos", ex);
            }
           
        }
    }
}
