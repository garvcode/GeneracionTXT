using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionTxt.Class
{
    public class clsDespacho
    {
        public decimal IdDespacho { get; set; }    
        
        public string CodigoPrincipal { get; set; }

        public int FechaEntero { get; set; }

        public string Cliente { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Identificacion { get; set; }

        public string Despacho { get; set; }

        public string Email { get; set; }

        public string Placa { get; set; }

        public decimal MontoSIMP { get; set; }

        public decimal MontoDolares { get; set; }

        public decimal Iva { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Subsidio { get; set; }

        public decimal IdTurno { get; set; }

        public decimal IdVendedor { get; set; }

        public decimal IdFormaPago { get; set; }

        public decimal Transaccion { get; set; }

    }
}
