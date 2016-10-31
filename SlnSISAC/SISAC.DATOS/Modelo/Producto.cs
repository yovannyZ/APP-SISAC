using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public Modelo Modelo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        public decimal Precio { get; set; }
        public string Detalle { get; set; }
        public string UsuLogin { get; set; }
        public DateTime UsuFecha { get; set; }
        public bool Estado { get; set; }
    }
}
