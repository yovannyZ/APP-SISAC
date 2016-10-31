using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class DetallePresupuesto
    {
        public int Id { get; set; }
        public Presupuesto Presupuesto { get; set; }
        public Producto  Producto { get; set; }
        public int Item { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
    }
}
