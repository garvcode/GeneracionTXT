using GeneracionTxt.Class;
using GeneracionTxt.Data;
using GeneracionTxt.Modal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneracionTxt.Repository
{
    public class ngFactura
    {
        public List<clsDespachoSQL> DocumentoRango(DateTime parini, DateTime parfin)
        {

            string connectionString = ConfigurationManager.AppSettings["Conexion"];


            List<clsDespachoSQL> respuesta = new List<clsDespachoSQL>();

            string query = "SELECT D.idDespacho,F.idFactura FROM [TRANSACTOR_BASE].[Facturacion].[Despacho] D LEFT JOIN [TRANSACTOR_BASE].[Facturacion].[Factura] F ON F.idFactura = D.idFactura WHERE D.Fecha BETWEEN @FechaInicio AND @FechaFin";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        if (parini == parfin) parfin.AddDays(1);

                        command.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = parini;
                        command.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = parfin;
                        command.CommandTimeout = 500;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal idDespacho = reader.GetDecimal(0);
                                decimal? idFactura = reader.IsDBNull(1) ? (decimal?)null : reader.GetDecimal(1);
                                respuesta.Add(new clsDespachoSQL { IdDespacho = idDespacho, IdFactura = idFactura });
                            }
                        }
                    }
                }
                catch (Exception) { }
                return respuesta;
            }
        }

        public clsFactura Factura(decimal? IdFactura)
        {
            clsFactura respuesta;
            try
            {
                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var con = db.Factura.FirstOrDefault(d => d.idFactura == IdFactura);
                    respuesta = new clsFactura
                    {
                        IdFactura = con.idFactura,
                        NumeroFactura = con.numerofactura,
                        Identificacion = con.identificacion,
                        Nombre = con.Nombre,
                        DireccionComprador = con.DireccionComprador,
                        Telefono = con.Telefono,
                        MontoSIMP = con.MontoSIMP ?? 0,
                        IVA = con.iva ?? 0,
                        MontoDolares = con.MontoDolares ?? 0,                        
                        IdTurno = con.idTurno ?? 0,
                        IdVendedor = con.idVendedor ?? 0,
                        IdFormaPago = con.idFormaPago ?? 0,
                        FechaEntero = con.fechaentero ?? 0,
                        Email = con.email,
                        ClaveAcceso = con.ClaveAcceso,
                        Placa = con.Placa,
                        FechaAutorizacion = con.FechaAutorizacion,
                        Lote = con.lote_tarjeta
                    };
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error al llenar la lista de Productos: " + ex);
                respuesta = null;
            }

            return respuesta;
        }
    }
}
