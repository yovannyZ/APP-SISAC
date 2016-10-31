using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class Cuentas
    {
        public int Id { get; set; }
        public Compania Compania { get; set; }
        public string Banco { get; set; }
        public string NroCuenta { get; set; }
        public DateTime UsuFecha { get; set; }
        public string UsuLogin { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public string CodInterbancario { get; set; }
        public string  Moneda { get; set; }
    }
}
