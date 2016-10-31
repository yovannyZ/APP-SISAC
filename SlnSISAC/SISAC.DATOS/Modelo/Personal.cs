using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class Personal : Persona
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string NombreCompleto
        {
            get 
            {
                return Nombres + " "+ ApPaterno +" "+ApMaterno;
            }
            
        }
        
    }
}
