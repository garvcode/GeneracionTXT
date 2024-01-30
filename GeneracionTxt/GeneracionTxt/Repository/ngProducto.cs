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
    public class ngProducto
    {
        public List<clsProducto> ProductoGasolina()
        {
            List<clsProducto> respuesta = new List<clsProducto>();
            try
            {
                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var con = db.Producto.Where(d => d.idTipo == 1 && d.idEstado == 1)
                                               .ToList();

                    con.ForEach(detalle =>
                    {
                        respuesta.Add(new clsProducto
                        {
                            IdProducto = detalle.idProducto,
                            Producto = detalle.Descripcion,
                            CodigoPrincipal = detalle.CodigoPrincipal,
                        });
                    });
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
