using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionTxt.Class
{
    public class clsFacturaDetalle
    {
        public decimal IdFactura { get; set; }
        public int IdDetalle { get; set; }
        public int IdProducto { get; set; }
        public string Simnbolo { get; set; }
        public string CodigoPrincipal { get; set; }
        public string Producto { get; set; }
        public decimal Subsidio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public int IdIva { get; set; }
        public int Tarifa { get; set; }
    }
}
