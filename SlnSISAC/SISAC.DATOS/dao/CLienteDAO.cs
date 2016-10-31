﻿using log4net;
using NHibernate;
using NHibernate.Criterion;
using SISAC.DATOS.Exceptions;
using SISAC.DATOS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.dao
{
     public class CLienteDAO : PersonaDAO
    {
         private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


         public override IList<Persona> ListarTodos()
         {
             using (ISession sesion = NHibernateHelper.ObtenerSesion())
             {
                 try
                 {
                     ICriteria busqueda = sesion.CreateCriteria(typeof(Cliente)).Add(Expression.Eq("Estado", true));
                     return busqueda.List<Persona>();
                 }
                 catch (Exception ex)
                 {
                     log.Error(ex.Message, ex);
                     throw new DataAccessException("Ocurrio un error, nose pudo listar los registros", ex);
                 }

             }

         }
    }
}
