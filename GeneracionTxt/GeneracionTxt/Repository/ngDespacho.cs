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
    public class ngDespacho
    {
        public clsDespacho Despacho(decimal IdDespacho)
        {
            clsDespacho respuesta;
            try
            {
                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var con = db.Despacho.FirstOrDefault(d => d.idDespacho == IdDespacho);
                    respuesta = new clsDespacho
                    {
                        IdDespacho = con.idDespacho,
                        IdFormaPago = con.idFormaPago ?? 0,
                        CodigoPrincipal = con.Producto.CodigoPrincipal,
                        FechaEntero = con.fechaentero ?? 0,
                        Identificacion = con.Cliente.identificacion,
                        Cliente = con.Cliente.Nombre,
                        Direccion = con.Cliente.Direccion,
                        Telefono = con.Cliente.Telefono,
                        MontoSIMP = con.MontoSIMP ?? 0,
                        MontoDolares = con.MontoDolares ?? 0,
                        Iva = con.iva ?? 0,
                        Cantidad = con.Cantidad ?? 0,
                        Precio = con.Precio ?? 0,
                        Subsidio = con.Subsidio ?? 0,
                        IdTurno = con.idTurno ?? 0,
                        IdVendedor = con.idusuadio ?? 0,
                        Email = con.Cliente.email,
                        Despacho = con.placa,
                        Transaccion = con.Transaccion ?? 0,
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
