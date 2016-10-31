using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public Moneda Moneda { get; set; }
        public TipoPago TipoPago { get; set; }
        public Cliente Cliente { get; set; }
        public Personal Personal { get; set; }
        public string NroPresupuesto { get; set; }
        public DateTime FechaEmision { get; set; }
        public string  Detalle { get; set; }
        public decimal  Subtotal { get; set; }
        public decimal Igv { get; set; }
        public decimal Total { get; set; }
        public string UsuLogin { get; set; }
        public DateTime UsuFecha { get; set; }
        public bool Estado { get; set; }
    }
}
