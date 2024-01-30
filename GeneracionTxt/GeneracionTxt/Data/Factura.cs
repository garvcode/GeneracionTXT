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
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.FacturaDetalle = new HashSet<FacturaDetalle>();
        }
    
        public decimal idFactura { get; set; }
        public Nullable<decimal> idempresa { get; set; }
        public string RucEmpresa { get; set; }
        public Nullable<decimal> idCliente { get; set; }
        public string identificacion { get; set; }
        public Nullable<decimal> idTipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string DireccionComprador { get; set; }
        public string Telefono { get; set; }
        public string email { get; set; }
        public Nullable<decimal> idFormaPago { get; set; }
        public Nullable<decimal> idIVA { get; set; }
        public Nullable<decimal> iva { get; set; }
        public Nullable<decimal> Subsidio { get; set; }
        public Nullable<decimal> MontoSIMP { get; set; }
        public Nullable<decimal> Tarifa { get; set; }
        public Nullable<decimal> MontoDolares { get; set; }
        public string unidadMedida { get; set; }
        public string PuntoEmision { get; set; }
        public string Establecimiento { get; set; }
        public Nullable<decimal> secuencia { get; set; }
        public string numerofactura { get; set; }
        public string diasplazo { get; set; }
        public string unidadtiempo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> ambiente { get; set; }
        public Nullable<decimal> tipo_emision { get; set; }
        public Nullable<decimal> tipo_comprobante { get; set; }
        public string ClaveAcceso { get; set; }
        public string Autorizacion { get; set; }
        public Nullable<decimal> idVendedor { get; set; }
        public string Vendedor { get; set; }
        public Nullable<decimal> idEstado { get; set; }
        public string Estado_documento { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public string Placa { get; set; }
        public string env_contabilidad { get; set; }
        public string tipofactura_i { get; set; }
        public string Imprimir { get; set; }
        public string Impresora { get; set; }
        public Nullable<decimal> idPago { get; set; }
        public string NombreInstitucionPago { get; set; }
        public string NumeroReferencia { get; set; }
        public string lote_tarjeta { get; set; }
        public Nullable<bool> cuantia { get; set; }
        public Nullable<decimal> idTurno { get; set; }
        public Nullable<int> fechaentero { get; set; }
        public string env_ARCH { get; set; }
        public string AutorizacionDataFast { get; set; }
        public Nullable<System.DateTime> FechaDataFast { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public string Observacion { get; set; }
    
        public virtual AperturaCierreTurno AperturaCierreTurno { get; set; }
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
    }
}