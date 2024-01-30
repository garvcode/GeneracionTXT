using GeneracionTxt.Class;
using GeneracionTxt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionTxt.Repository
{
    public class ngUsuario
    {
        public clsUsuario Usuario(decimal IdUsuario)
        {
            clsUsuario respuesta;
            try
            {
                using (TRANSACTOR_BASEEntities db = new TRANSACTOR_BASEEntities())
                {
                    var con = db.Usuario.FirstOrDefault(d => d.IdUsuario == IdUsuario);

                    respuesta = new clsUsuario
                    {
                        IdUsuario = con.IdUsuario,
                        Usuario = con.NombreUsuario,
                        CodigoAlterno = con.CodigoAlterno ?? "",
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
