using GeneracionTxt.Class;
using GeneracionTxt.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionTxt.Repository
{
    public class ngDocumento
    {
        public async Task<List<clsDespachoSQL>> DocumentoRango(DateTime parini, DateTime parfin)
        {
            List<clsDespachoSQL> respuesta = new List<clsDespachoSQL>();
            try
            {
                string query = $"SELECT D.idDespacho,F.idFactura FROM [TRANSACTOR_BASE].[Facturacion].[Despacho] D LEFT JOIN [TRANSACTOR_BASE].[Facturacion].[Factura] F ON F.idFactura = D.idFactura WHERE D.Fecha BETWEEN @FechaInicio AND @FechaFin";

                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var parametros = new SqlParameter[]
{
                    new SqlParameter("@FechaInicio", parini),
                    new SqlParameter("@FechaFin", parfin)
};
                    var despachos = db.Database.SqlQuery<clsDespachoSQL>(query, parametros);

                    await despachos.ForEachAsync(despacho => {
                        respuesta.Add(despacho);
                    });
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error al llenar la lista de facturas: " + ex);
                respuesta = null;
            }
            return respuesta;
        }
    }
}
