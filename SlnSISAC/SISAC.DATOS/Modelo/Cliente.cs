using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class Cliente : Persona
    {
        public TipoCliente TipoCliente { get; set; }
        public string Codigo { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Contacto { get; set; }
        public string EmailContacto { get; set; }
        public string TelefonoContacto { get; set; }
    }
}
