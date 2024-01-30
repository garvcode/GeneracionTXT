using GeneracionTxt.Class;
using GeneracionTxt.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionTxt.Repository
{
    public class ngFacturaDetalle
    {
        public List<clsFacturaDetalle> DetalleFactura(decimal? IdFactura)
        {
            List<clsFacturaDetalle> respuesta = new List<clsFacturaDetalle>();
            try
            {
                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var con = db.FacturaDetalle.Where(d => d.idFactura == IdFactura).ToList();

                    con.ForEach(detalle =>
                    {
                        respuesta.Add(new clsFacturaDetalle
                        {
                            IdFactura = detalle.idFactura,
                            CodigoPrincipal = detalle.CodigoPrincipal,
                            Cantidad = detalle.Cantidad ?? 0,
                            Precio = detalle.Precio ?? 0,
                            Subsidio = detalle.Subsidio ?? 0,
                        });
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
