using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public abstract class Persona
    {
        //ID_PERSONA, FK_UBIGEO, NOMBES, AP_PATERNO, AP_MATERNO, DNI, DIRECCION, USU_FECHA, USU_LOGIN, ESTADO
        public int Id { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Nombres { get; set; }
        public string  Dni { get; set; }
        public string  Direccion { get; set; }
        public DateTime UsuFecha { get; set; }
        public string UsuLogin { get; set; }
        public bool  Estado { get; set; }
    }



    
}
