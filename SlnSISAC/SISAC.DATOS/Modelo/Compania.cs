using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAC.DATOS.Modelo
{
    public class Compania
    {
        //ID_COMPANIA, RAZON_SOCIAL, RUC, DIRECCION, UBIGEO, TELEFONO1, TELEFONO2, CORREO1, CORREO2, USU_FECHA, USU_LOGIN, ESTADO
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Correo1 { get; set; }
        public string Correo2 { get; set; }
        public string UsuLogin { get; set; }
        public DateTime UsuFecha { get; set; }
        public bool Estado { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public IList<Cuentas> ListaCuentas { get; set; }
    }
}
