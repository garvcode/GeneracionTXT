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
    
    public partial class AperturaCierreTurno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AperturaCierreTurno()
        {
            this.DetalleAperturaCierre = new HashSet<DetalleAperturaCierre>();
            this.Despacho = new HashSet<Despacho>();
            this.Factura = new HashSet<Factura>();
            this.PtoVenta = new HashSet<PtoVenta>();
        }
    
        public decimal idTurno { get; set; }
        public Nullable<decimal> transac_Ab_Volumen { get; set; }
        public Nullable<decimal> transac_Ab_Dolares { get; set; }
        public Nullable<decimal> transac_Ci_Volumen { get; set; }
        public Nullable<decimal> transac_Ci_Dolares { get; set; }
        public Nullable<decimal> totalDespachos { get; set; }
        public Nullable<decimal> totalDepositos { get; set; }
        public Nullable<decimal> totalVolumen { get; set; }
        public Nullable<decimal> totalDolares { get; set; }
        public string Impresora { get; set; }
        public Nullable<decimal> idEstado { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> FechaApertura { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public Nullable<decimal> totalDespachosEfectivo { get; set; }
        public Nullable<decimal> totalDespachosTDebito { get; set; }
        public Nullable<decimal> totalDespachosDineroElectronico { get; set; }
        public Nullable<decimal> totalDespachosTPrepago { get; set; }
        public Nullable<decimal> totalDespachosTCredito { get; set; }
        public Nullable<decimal> totalDespachosCheque { get; set; }
        public Nullable<decimal> TotalVentasCredito { get; set; }
        public Nullable<decimal> TotalVentasPrepago { get; set; }
        public Nullable<decimal> TotalVentasServicio { get; set; }
        public Nullable<decimal> TotalVentasFueraLinea { get; set; }
        public Nullable<decimal> TotalSistema { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleAperturaCierre> DetalleAperturaCierre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despacho> Despacho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PtoVenta> PtoVenta { get; set; }
    }
}
