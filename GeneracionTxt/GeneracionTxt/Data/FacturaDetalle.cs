//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneracionTxt.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacturaDetalle
    {
        public decimal idFactura { get; set; }
        public decimal idDetalle { get; set; }
        public Nullable<decimal> idProducto { get; set; }
        public string Producto { get; set; }
        public string DesProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> MontoSIMP { get; set; }
        public Nullable<decimal> iva { get; set; }
        public Nullable<decimal> MontoDolares { get; set; }
        public Nullable<decimal> Subsidio { get; set; }
        public Nullable<decimal> SubsidioProducto { get; set; }
        public Nullable<decimal> idIVA { get; set; }
        public Nullable<decimal> Tarifa { get; set; }
        public string CodigoPrincipal { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto1 { get; set; }
    }
}
