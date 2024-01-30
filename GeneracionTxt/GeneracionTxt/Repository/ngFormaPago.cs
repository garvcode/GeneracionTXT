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
    public class ngFormaPago
    {
        public clsFormaPago FormaPago(decimal IdFormaPago)
        {
            clsFormaPago respuesta;
            try
            {
                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var con = db.FORMA_PAGO.FirstOrDefault(d => d.idFormaPago == IdFormaPago);
                    respuesta = new clsFormaPago
                    {
                        IdFormaPago = con.idFormaPago,
                        Alias = con.Alias,
                        TipoVenta = con.TipoVenta
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
