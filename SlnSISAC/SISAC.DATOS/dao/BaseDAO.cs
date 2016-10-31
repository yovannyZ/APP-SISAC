using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using NHibernate.Criterion;
using log4net;
using SISAC.DATOS.Exceptions;

namespace SISAC.DATOS.dao
{
      
    
        public class BaseDAO<Entidad, Id>
        {
            private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            public virtual void Crear(Entidad entidad)
            {

                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    using (var tx = sesion.BeginTransaction())
                    {
                        try
                        {
                            sesion.Save(entidad);
                            tx.Commit();
                           
                        }
                        catch (Exception ex)
                        {
                            log.Error(ex.Message, ex);
                            tx.Rollback();
                            throw new DataAccessException("Ocurrio un error,no se pudo guardar el registro", ex); 
                        }

                    }

                }

            }
            public virtual Entidad Obtener(Id id)
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    return sesion.Get<Entidad>(id);
                }
            }
            public virtual bool Modificar(Entidad entidad)
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    using (var tx = sesion.BeginTransaction())
                    {
                        try
                        {
                            sesion.Update(entidad);
                            sesion.Flush();
                            tx.Commit();
                            return true;

                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            log.Error(ex.Message,ex)
;                           return false;
                            throw new DataAccessException("Ocurrio un error, no se pudo modificar el registro",ex);
                        }

                    }

                }

            }
            public virtual bool Eliminar(Entidad entidad)
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    using (var tx = sesion.BeginTransaction())
                    {
                        try
                        {
                            sesion.Delete(entidad);
                            sesion.Flush();
                            tx.Commit();
                            return true;

                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            log.Error(ex.Message,ex);
                            return false;
                            throw new DataAccessException("Ocurrio un error, no se pudo eliminar el registro",ex);

                        }

                    }

                }
            }
            public virtual IList<Entidad> ListarTodos()
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    try
                    {
                        ICriteria busqueda = sesion.CreateCriteria(typeof(Entidad)).Add(Expression.Eq("Estado", true));
                        return busqueda.List<Entidad>();
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex.Message, ex);   
                        throw new DataAccessException("Ocurrio un error, nose pudo listar los registros",ex);
                    }
                   
                }
            }
        }
    
}
