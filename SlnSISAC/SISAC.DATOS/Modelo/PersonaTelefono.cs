using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class PersonaTelefono
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public string Telefono { get; set; }
        public string UsuLogin { get; set; }
        public DateTime UsuFecha { get; set; }
        public bool Estado { get; set; }
    }
}
