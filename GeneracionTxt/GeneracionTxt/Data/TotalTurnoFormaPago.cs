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
    
    public partial class TotalTurnoFormaPago
    {
        public decimal idTurno { get; set; }
        public decimal idDetalle { get; set; }
        public Nullable<decimal> idFormaPago { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Totales { get; set; }
        public Nullable<decimal> idEstado { get; set; }
    
        public virtual FORMA_PAGO FORMA_PAGO { get; set; }
    }
}