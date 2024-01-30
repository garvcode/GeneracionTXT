using GeneracionTxt.Class;
using GeneracionTxt.Modal;
using GeneracionTxt.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeneracionTxt
{
    public partial class Form1 : Form
    {
        public clsFactura factura = new clsFactura();

        public clsDespacho despacho = new clsDespacho();

        public bool despachoCR;

        public Form1()
        {
            InitializeComponent();
        }

        public void LlenarLineaProducto(StringBuilder cadena, List<clsProducto> producto)
        {
            producto.ForEach(item =>
            {
                cadena.Append($"0|");
                cadena.Append($"{item.CodigoPrincipal}|");
                cadena.Append($"{item.Producto}||");
                cadena.Append("\n");
            });
        }

        public void LlenarLineaUno(StringBuilder cadena, clsDespachoSQL documento)
        {
            ngFormaPago negocioFormaPago = new ngFormaPago();

            despachoCR = documento.IdFactura == null ? true : false;

            if (despachoCR)
            {
                ngDespacho negocioDespacho = new ngDespacho();

                despacho = negocioDespacho.Despacho(documento.IdDespacho);
                if (!despacho.Cliente.Equals("CONTROL INTERNO"))
                {
                    var pago = negocioFormaPago.FormaPago(despacho.IdFormaPago);
                    if (!(pago.Alias.Equals("CALIBRACIONES") || pago.Alias.Equals("CALIBRACIONES")))
                    {
                        cadena.Append($"1|");
                        cadena.Append($"{FormatearDocumento("NOTAS DE DESPACHO")}|");
                        cadena.Append($"{FormatearNumeroDespacho(despacho.Transaccion.ToString())}|");
                        cadena.Append($"{FormatearFechaEntero(despacho.FechaEntero.ToString())}|");
                        cadena.Append($"|");
                        cadena.Append($"|");
                        cadena.Append($"|");
                        cadena.Append($"{despacho.Identificacion}|");
                        cadena.Append($"{despacho.Cliente}|");
                        cadena.Append($"{despacho.Direccion}|");
                        cadena.Append($"{despacho.Telefono}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(despacho.MontoSIMP))}|");
                        cadena.Append($"{FormatearIvaCero()}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(despacho.Iva))}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(despacho.MontoDolares))}|");
                        cadena.Append($"1||");
                        cadena.Append($"|");
                        cadena.Append($"{FormatearCodigoUsuario(despacho.IdVendedor)}|");
                        cadena.Append($"2|");
                        cadena.Append($"{FormatearFechaEntero(despacho.FechaEntero.ToString())}|");
                        cadena.Append($"{despacho.Email}|");
                        cadena.Append($"|");
                        cadena.Append($"|");
                        cadena.Append($"|");
                        cadena.Append($"{despacho.Placa}|");
                        cadena.Append("\n");
                    }
                }
            }
            else
            {
                //Correcto
                ngFactura negocioFactura = new ngFactura();

                factura = negocioFactura.Factura(documento.IdFactura);
                var pago = negocioFormaPago.FormaPago(factura.IdFormaPago);
                if (!(pago.Alias.Equals("CALIBRACIONES") || pago.Alias.Equals("CALIBRACIONES")))
                {
                    cadena.Append($"1|");
                    cadena.Append($"{FormatearDocumento("FACTURA")}|");
                    cadena.Append($"{FormatearNumeroFactura(factura.NumeroFactura)}|");
                    cadena.Append($"{FormatearFechaEntero(factura.FechaEntero.ToString())}|");
                    cadena.Append($"|");
                    cadena.Append($"|");
                    cadena.Append($"|");
                    cadena.Append($"{factura.Identificacion}|");
                    cadena.Append($"{factura.Nombre}|");
                    cadena.Append($"{factura.DireccionComprador}|");
                    cadena.Append($"{factura.Telefono}|");
                    cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(factura.MontoSIMP))}|");
                    cadena.Append($"{FormatearIvaCero()}|");
                    cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(factura.IVA))}|");
                    cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(factura.MontoDolares))}|");
                    cadena.Append($"{factura.IdTurno}||");
                    cadena.Append($"C|");
                    cadena.Append($"{FormatearCodigoUsuario(factura.IdVendedor)}|");
                    cadena.Append($"2|");
                    cadena.Append($"{FormatearFechaEntero(factura.FechaEntero.ToString())}|");
                    cadena.Append($"{factura.Email}|");
                    cadena.Append($"{factura.ClaveAcceso}|");
                    cadena.Append($"{factura.ClaveAcceso}|");
                    cadena.Append($"{FormatearFechaAutorizacion(factura.FechaAutorizacion)}");
                    cadena.Append($"|");
                    cadena.Append($"{factura.Placa}|");
                    if (FormatearFormaPago(pago.Alias).Equals("EFE"))
                    {
                        cadena.Append($"{FormatearCodigoFormaPago(pago.Alias)}");
                    }
                    else if (FormatearFormaPago(pago.Alias).Equals("TCR"))
                    {
                        cadena.Append($"{FormatearCodigoFormaPago(pago.Alias)}|");
                        cadena.Append($"{FormatearLoteTarjeta(factura.Lote)}");
                    }
                    cadena.Append("\n");
                }
            }
        }

        public void LlenarLineaDosAsync(StringBuilder cadena, clsDespachoSQL documento)
        {
            ngFormaPago negocioFormaPago = new ngFormaPago();

            if (despachoCR)
            {
                if (!despacho.Cliente.Equals("CONTROL INTERNO"))
                {
                    var pago = negocioFormaPago.FormaPago(despacho.IdFormaPago);
                    if (!(pago.Alias.Equals("CALIBRACIONES") || pago.Alias.Equals("CALIBRACIONES")))
                    {
                        cadena.Append($"2|");
                        cadena.Append($"{FormatearDocumento("NOTAS DE DESPACHO")}|");
                        cadena.Append($"{FormatearNumeroDespacho(despacho.Transaccion.ToString())}|");
                        cadena.Append($"{FormatearFormaPagoDespacho(pago.Alias)}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(despacho.MontoDolares))}|||");
                        cadena.Append("\n");
                    }
                }
            }
            else
            {
                var pago = negocioFormaPago.FormaPago(factura.IdFormaPago);

                cadena.Append($"2|");
                cadena.Append($"{FormatearDocumento("FACTURA")}|");
                cadena.Append($"{FormatearNumeroFactura(factura.NumeroFactura)}|");
                cadena.Append($"{FormatearFormaPago(pago.Alias)}|");
                cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(factura.MontoDolares))}||||F|");

                if (FormatearFormaPago(pago.Alias).Equals("EFE"))
                {
                    cadena.Append($"{FormatearCodigoFormaPago(pago.Alias)}");
                }
                else if (FormatearFormaPago(pago.Alias).Equals("TCR"))
                {
                    cadena.Append($"{FormatearCodigoFormaPago(pago.Alias)}|");
                    cadena.Append($"{FormatearLoteTarjeta(factura.Lote)}");
                }
                cadena.Append("\n");
            }
        }

        public void LlenarLineaTresAsync(StringBuilder cadena, clsDespachoSQL documento)
        {
            ngFormaPago negocioFormaPago = new ngFormaPago();

            if (despachoCR)
            {

                if (!despacho.Cliente.Equals("CONTROL INTERNO"))
                {
                    var pago = negocioFormaPago.FormaPago(despacho.IdFormaPago);
                    if (!(pago.Alias.Equals("CALIBRACIONES") || pago.Alias.Equals("CALIBRACIONES")))
                    {
                        ngDespacho negocioDespacho = new ngDespacho();
                        clsDespacho registroDespacho = negocioDespacho.Despacho(documento.IdDespacho);

                        cadena.Append($"3|");
                        cadena.Append($"{FormatearDocumento("NOTAS DE DESPACHO")}|");
                        cadena.Append($"{FormatearNumeroDespacho(registroDespacho.Transaccion.ToString())}|");
                        cadena.Append($"{registroDespacho.CodigoPrincipal}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(registroDespacho.Cantidad))}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(registroDespacho.Precio))}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(registroDespacho.Subsidio))}");
                        cadena.Append("\n");
                    }
                }
            }
            else
            {
                var pago = negocioFormaPago.FormaPago(factura.IdFormaPago);
                if (!(pago.Alias.Equals("CALIBRACIONES") || pago.Alias.Equals("CALIBRACIONES")))
                {
                    ngFacturaDetalle negocioFacturaDetalle = new ngFacturaDetalle();
                    var detalles = negocioFacturaDetalle.DetalleFactura(documento.IdFactura);

                    detalles.ForEach(detalle =>
                    {
                        cadena.Append($"3|");
                        cadena.Append($"{FormatearDocumento("FACTURA")}|");
                        cadena.Append($"{FormatearNumeroFactura(factura.NumeroFactura)}|");
                        cadena.Append($"{detalle.CodigoPrincipal}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(detalle.Cantidad))}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(detalle.Precio))}|");
                        cadena.Append($"{FormatearNumeros(FormatearNumeroDosDecimales(detalle.Subsidio))}");
                        cadena.Append("\n");
                    });
                }
            }
        }


        public decimal FormatearNumeroDosDecimales(decimal montoDolares)
        {
            decimal numero = Math.Truncate(montoDolares * 100) / 100;
            return numero;
        }



        public string FormatearNumeros(decimal numero)
        {
            string resultado = numero.ToString()
                                     .Replace(".", string.Empty)
                                     .PadLeft(9, '0');
            return resultado;
        }

        public string FormatearFormaPago(string formaPago) => formaPago.Equals("EFECTIVO") ? "EFE" :
                                                              formaPago.Equals("CREDITO") ? "CRE" :
                                                              formaPago.Equals("T. CRÉDITO / DEBITO") ? "TCR" :
                                                              formaPago.Equals("OTRAS FORMAS") ? "CRE" :

                                                              string.Empty;
        public string FormatearFormaPagoDespacho(string formaPago) => formaPago.Equals("") ?
                                                             string.Empty : "CRE";

        public string FormatearCodigoFormaPago(string formaPago) => formaPago.Equals("EFECTIVO") ? "01" :
                                                                    "20";

        public string FormatearNumeroFactura(string numeroFactura) => numeroFactura.Replace("-", string.Empty);

        public string FormatearDocumento(string documento) => documento.Equals("FACTURA") ? "FC" :
                                                              documento.Equals("NOTAS DE DESPACHO") ? "NE" :
                                                              string.Empty;
        public string FormatearIvaCero() => "000000000";

        public string FormatearNumeroDespacho(string transaccion) => transaccion.PadLeft(15, '0');

        public string FormatearFechaAutorizacion(DateTime? fechaAutorizacion) => fechaAutorizacion == null || fechaAutorizacion.Equals(string.Empty) ? "|" : fechaAutorizacion.ToString();

        public string FormatearLoteTarjeta(string loteTarjeta) => loteTarjeta == null || loteTarjeta.Equals(string.Empty) ? string.Empty : loteTarjeta.ToString();

        public string FormatearFechaEntero(string fecha)
        {
            if (fecha.Equals("0"))
            {
                return "|";
            }
            else
            {
                DateTime originalDate = DateTime.ParseExact(fecha, "yyyyMMdd", null);

                string formattedDate = originalDate.ToString("ddMMyyyy");

                return formattedDate;
            }
        }

        public string FormatearCodigoUsuario(decimal IdUsuario)
        {
            ngUsuario negocioUsuario = new ngUsuario();
            clsUsuario usuario = negocioUsuario.Usuario(IdUsuario);
            return usuario.CodigoAlterno;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ngFactura negocioFactura = new ngFactura();
            ngProducto negocioProducto = new ngProducto();

            DateTime fechaDesde = dateTimePickerDesde.Value;
            DateTime fechaHasta = dateTimePickerHasta.Value;



            List<clsDespachoSQL> documentos = negocioFactura.DocumentoRango(fechaDesde, fechaHasta);
            List<clsProducto> productos = negocioProducto.ProductoGasolina();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto";
            if (documentos != null)
            {
                if (documentos.Count > 0)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        string rutaArchivo = saveFileDialog.FileName;
                        LlenarLineaProducto(stringBuilder, productos);
                        using (StreamWriter writer = new StreamWriter(rutaArchivo))
                        {

                            foreach (clsDespachoSQL documento in documentos)
                            {


                                LlenarLineaUno(stringBuilder, documento);
                                LlenarLineaDosAsync(stringBuilder, documento);
                                LlenarLineaTresAsync(stringBuilder, documento);
                            }
                            writer.WriteLine(stringBuilder.ToString());
                        }
                        MessageBox.Show("Archivo generado con éxito en:\n" + rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe Registros en ese rango de Fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
