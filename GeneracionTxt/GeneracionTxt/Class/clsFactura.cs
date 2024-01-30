using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionTxt.Class
{
    public class clsFactura
    {
        public decimal IdFactura { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdFormaPago { get; set; }
        public string RucEmpresa { get; set; }
        public string NombreComercial { get; set; }
        public string NombreFiscal { get; set; }
        public string Ciudad { get; set; }
        public string DireccionVendedor { get; set; } 
        public decimal IdCliente { get; set; }
        public string Identificacion { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string DireccionComprador { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Placa { get; set; }
        public int FormaPago { get; set; }
        public string FormaPagoImp { get; set; }
        public int IdIva { get; set; }
        public int Tarifa { get; set; }
        public decimal IVA { get; set; }
        public decimal Subsidio { get; set; }
        public decimal SubsidioProducto { get; set; }
        public decimal MontoSIMP { get; set; }
        public decimal MontoDolares { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Precio { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Cantidad { get; set; }
        public string PuntoCarga { get; set; }
        public string Manguera { get; set; }
        public string Transaccion { get; set; }
        public string PtoEmision { get; set; }
        public string Establecimiento { get; set; }
        public decimal Secuencia { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public int FechaEntero { get; set; }
        public int DiasPlazo { get; set; }
        public int Ambiente { get; set; }
        public int TipoEmision { get; set; }
        public int TipoComprobante { get; set; }
        public string Imprimir { get; set; }
        public string Impresora { get; set; }
        public string ClaveAcceso { get; set; }
        public string Autorizacion { get; set; }
        public decimal IdVendedor { get; set; }
        public string Vendedor { get; set; }
        public int Estado { get; set; }
        public string EstadoDocumento { get; set; }
        public bool Seleccionar { get; set; }
        public decimal IdTurno { get; set; }
        public int IdPago { get; set; }
        public string Institucion { get; set; }
        public string NumReferencia { get; set; }
        public string Lote { get; set; }
        public string AutorizacionDataFast { get; set; }
        public DateTime FechaDataFast { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
