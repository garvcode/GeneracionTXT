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
    
    public partial class Deposito
    {
        public decimal idDeposito { get; set; }
        public decimal idTurno { get; set; }
        public Nullable<int> Billetes5 { get; set; }
        public Nullable<int> Billetes10 { get; set; }
        public Nullable<int> Billetes20 { get; set; }
        public Nullable<decimal> Monedas { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string Impresora { get; set; }
        public Nullable<decimal> idEstado { get; set; }
        public Nullable<int> Billetes50 { get; set; }
        public Nullable<int> Billetes100 { get; set; }
        public string Descripcion { get; set; }
        public string Imprimir { get; set; }
        public decimal tipo { get; set; }
    }
}
