using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuFactura.co;
using TuFactura.co.Modelo;


namespace prueba_Nuget
{
   class Program
    {
        /*Se obtienen en www.tufactura.co*/
        private const string Usuario = "";
        private const string Pass = "";
        private const string Suscriptor = "";

        static void Main(string[] args)
        {
           callWebApi().Wait();
        }

        static private async Task callWebApi()
        {
            TuFacturaco tufactura = new TuFacturaco(Usuario, Pass, Suscriptor, Ambientes.Habilitacion) ;           


            ///Consultamos Estdo de Servicios e Informacion del Facturador
            var resul = tufactura.EstadoAsync().Result;


            Persona Tercero = new Persona();
            //simulamos datos del tercero
            Tercero = ObetenerPersona();

            ///Creamos o Actualizamos el tercero 
           //Se Valida la estructura del objeto antes de enviar al servicio
           //Si se presentan errores en la estructura del objeto se retornara un listado de todos los errores presentes.
            var persona =  tufactura.CrearActualizarPersonaAsync(Tercero).Result.Persona.FirstOrDefault();

            FacturaVenta Factura = new FacturaVenta();
            /// simulamos datos de Factura
            Factura = ObtenerFacturaVenta();
            /// Emitimos una Factura Electronica
            var facturaEmitida = tufactura.EmitirFacturaAsync(Factura).Result;

            NotaVenta NotaCredito = new NotaVenta();
            //Simulamos los datos de la Nota
            NotaCredito = ObtenerNotaVenta(facturaEmitida);
            //Emitimos la Nota
            var notaCreditoEmitida = tufactura.EmitirNotasAsync(NotaCredito).Result;

            List<AdjuntoInput> Adjuntos = new List<AdjuntoInput>();
            //simulamos los adjuntos a cargar como anexos
            Adjuntos =ObtenerAdjuntos(tufactura);


            //cargamos los anexos a la Factura.
            var AnexosFactura = tufactura.CargarAnexosAsync(facturaEmitida.FacturaGenerada.FactId, Adjuntos).Result;

            //Cargamos los Anexos a La Nota.
           // var AnexosNota = tufactura.CargarAnexosAsync(notaCreditoEmitida.NotaGenerada.NotaId, Adjuntos).Result;

           
           

            /*Usamos las diferentes opciones para obtener la imagen(.JPG) del QR del PDF de la Factura*/

            //Obtenemos el arreglo de byte
            var imagen1 = tufactura.ObtenerImagenQr(facturaEmitida);

            //Guardamos la Imagen en disco y obtenemos la ruta de la imagen
            var imagen2 = tufactura.ObtenerImagenQr(facturaEmitida, @"C:\Users\Administrador\Desktop\Escrituras\");

            //Obtenemos el MemoryStream de la Imagen JPG del QR de la factura.
            var imagen3 = tufactura.ObtenerImagenQr(facturaEmitida.FacturaGenerada.FactQRBase64);


            var TrazaFactura = tufactura.ConsultarTrazabilidadFacturaAsync(facturaEmitida.FacturaGenerada.FactId).Result;

            var TrazaNota = tufactura.ConsultarTrazabilidadNotaAsync(notaCreditoEmitida.NotaGenerada.NotaId).Result;


        }


        static private List<AdjuntoInput> ObtenerAdjuntos(TuFacturaco tufactura)
        {

            //El metodo tiene sobrecargas para recibir un Stream o MemoryStream
            /*tufactura.GenerarAdjunto(Stream stream, TipoAdjunto tipo, string NombreArchivo)
            tufactura.GenerarAdjunto(MemoryStream memoryStream, TipoAdjunto tipo, string NombreArchivo)*/
            List<AdjuntoInput> Adjuntos = new List<AdjuntoInput>();
            var archivo = tufactura.GenerarAdjunto(@"C:\Users\Administrador\Downloads\02_nov._2018_10_57_4.pdf", TipoAdjunto.Representacion);
            Adjuntos.Add(archivo);
            archivo = tufactura.GenerarAdjunto(@"C:\Users\Administrador\Downloads\face_f081102337100000005CF.zip", TipoAdjunto.AdjuntoCorreo);
            Adjuntos.Add(archivo);
            archivo = tufactura.GenerarAdjunto(@"C:\Users\Administrador\Downloads\Reporte-811023371.xlsx", TipoAdjunto.AdjuntoCorreo);
            Adjuntos.Add(archivo);
            archivo = tufactura.GenerarAdjunto(@"C:\Users\Administrador\Downloads\Braveheart Remix [Tiesto].mp3", TipoAdjunto.AdjuntoPortal);
            Adjuntos.Add(archivo);
            archivo = tufactura.GenerarAdjunto(@"C:\Users\Administrador\Downloads\ImpresionFinal.mp4", TipoAdjunto.AdjuntoPortal);
            Adjuntos.Add(archivo);
            return Adjuntos;

        }
        static private Persona ObetenerPersona()
        {
            Persona Tercero = new Persona();
            Tercero.TipoPersona = 1;
            Tercero.Documento = 89090;
            Tercero.PDireccion = "Cra ";
            Tercero.PEmail = "uncorreo@gmail.com;otrocorreo@otro.com";
            Tercero.PTelefono = 123456;
            Tercero.DCodigoDocumento = "31";
            Tercero.RCodigoTributario = 0;
            Tercero.JRazonSocial = "INDUSTRIA COLOMBIANA *** S.A.S";
            Tercero.DNombreDepartamento = "ANTIOQUIA";
            Tercero.CNombreCiudad = "MEDELLIN";
            Tercero.CodigoPais = "CO";
            Tercero.PersReferencia1 = "Zona 1";
            Tercero.PersReferencia2 = "Aasesor 12145";
            Tercero.PersReferencia3 = "Ruta 20";
            return Tercero;
        }
        static private FacturaVenta ObtenerFacturaVenta()
        {
            FacturaVenta Factura = new FacturaVenta();
            Cabecera CabeceraFactura = new Cabecera();

            CabeceraFactura.DocumentoReferencia10 = Guid.NewGuid().ToString(); ;
            CabeceraFactura.Subtotal = 457500;
            CabeceraFactura.Base = 456500;
            CabeceraFactura.Descuentos = 0;
            CabeceraFactura.Abonos = 0;
            CabeceraFactura.Cargos = 0;
            CabeceraFactura.ImpuestosRetenidos = 0;
            CabeceraFactura.Total= 543080;
            CabeceraFactura.CodigoMonedaFactura = "COP";
            CabeceraFactura.CodigoEstablecimiento = "E-11";
            CabeceraFactura.Documento = 89090;
            CabeceraFactura.TiempoEsperaEmision = 0;
            CabeceraFactura.TipoFactura = "V";
            CabeceraFactura.NumeroResolucion = "9000000106802688";

            Observaciones Observacion= new Observaciones();
            Observacion.Lista.Add("Observacion 1");
            Observacion.Lista.Add("Observacion 2");
            Observacion.Lista.Add("Observacion 3");

            List<Item> DetalleFactura = new List<Item>();

            DetalleFactura.Add(new Item
            {
                IdItems = "1",
                Cantidad = 10,
                Descripcion = "Pqtes de Lana Roja",
                EanUpc = "931804231236",
                Presentacion = "Docena",
                Referencia = "RTF15B20",
                ValorUnitario = 100,
                SubTotal = 1000,
                ValorTotal = 1000
            });
            DetalleFactura.Add(new Item
            {
                IdItems = "2",
                Cantidad = 1,
                Descripcion = "Smart Phone samsung",
                EanUpc = "931804231236",
                Presentacion = "Unidad",
                Referencia = "Galaxy S10+",
                ValorUnitario = 450000,
                Serial="39000000014521",
                SubTotal = 450000,
                ValorTotal = 450000
            });
            DetalleFactura.Add(new Item
            {
                IdItems = "3",
                Cantidad = 1,
                Descripcion = "Cubeta x 30 huevos",              
                Presentacion = "Panal",
                Referencia = "HAA30",
                ValorUnitario = 6500,           
                SubTotal = 6500,
                ValorTotal = 6500
            });

            List<ItmsImpuesto> Impuestos = new List<ItmsImpuesto>();

            Impuestos.Add(new ItmsImpuesto
            {
                IdItems = "1",
                CodigoImpuesto="01",
                BaseImpuesto=450000,
                TarifaImpuesto="19",
                ValorImpuesto=85500
            });
            Impuestos.Add(new ItmsImpuesto
            {
                IdItems = "2",
                CodigoImpuesto = "01",
                BaseImpuesto = 1000,
                TarifaImpuesto = "8",
                ValorImpuesto = 80
            });

            Factura.Cabecera = CabeceraFactura;
            Factura.Observaciones = Observacion;
            Factura.Items = DetalleFactura;
            Factura.ItmsImpuestos = Impuestos;
            return Factura;

        }
        static private NotaVenta ObtenerNotaVenta(FacturaEmitida facturaaplicar)
        {
            NotaVenta Nota = new NotaVenta();
            CabeceraNota CabeceraNota = new CabeceraNota();

            CabeceraNota.DocumentoReferencia1 = Guid.NewGuid().ToString();
            CabeceraNota.DocumentoReferencia2 = null;
            CabeceraNota.DocumentoReferencia3 = null;
            CabeceraNota.DocumentoReferencia4 = null;
            CabeceraNota.NotaTipo = "C";
            CabeceraNota.Subtotal = 520;
            CabeceraNota.Base = 468;
            CabeceraNota.Descuentos = 52;
            CabeceraNota.Abonos = 0;
            CabeceraNota.Cargos = 1710077;
            CabeceraNota.ImpuestosRetenidos = 11.7M;
            CabeceraNota.Total = 545.22M;
            CabeceraNota.NumeroResolucionNota = null;
            CabeceraNota.ConsecutivoFactura = facturaaplicar.FacturaGenerada.FacturaNumero;
            CabeceraNota.CodigoMonedaNota = "USD";
            CabeceraNota.CodigoEstablecimiento = "E-02";
            CabeceraNota.TiempoEsperaEmision = 0;
            CabeceraNota.CodigoNotificacionAdicional = "";
            CabeceraNota.CodigoConceptoNota = "2";
            CabeceraNota.TotalCop = 1710077;         
            

            Observaciones Observacion = new Observaciones();
            Observacion.Lista.Add("Observacion 1");
            Observacion.Lista.Add("Observacion 2");
            Observacion.Lista.Add("Observacion 3");

            List<ItemNota> DetalleNota = new List<ItemNota>();

            DetalleNota.Add(new ItemNota
            {
                IdItems = "1",
                Cantidad = 10,
                Descripcion = "Pqtes de Lana Roja",
                EanUpc = "931804231236",
                Presentacion = "Docena",
                Referencia = "RTF15B20",
                ValorUnitario = 100,
                SubTotal = 1000,
                ValorTotal = 1000
            });
            DetalleNota.Add(new ItemNota
            {
                IdItems = "2",
                Cantidad = 1,
                Descripcion = "Smart Phone samsung",
                EanUpc = "931804231236",
                Presentacion = "Unidad",
                Referencia = "Galaxy S10+",
                ValorUnitario = 450000,
                Serial = "39000000014521",
                SubTotal = 450000,
                ValorTotal = 450000
            });
            DetalleNota.Add(new ItemNota
            {
                IdItems = "3",
                Cantidad = 1,
                Descripcion = "Cubeta x 30 huevos",
                Presentacion = "Panal",
                Referencia = "HAA30",
                ValorUnitario = 6500,
                SubTotal = 6500,
                ValorTotal = 6500
            });

            List<ItmsImpuesto> Impuestos = new List<ItmsImpuesto>();

            Impuestos.Add(new ItmsImpuesto
            {
                IdItems = "1",
                CodigoImpuesto = "01",
                BaseImpuesto = 450000,
                TarifaImpuesto = "19",
                ValorImpuesto = 85500
            });
            Impuestos.Add(new ItmsImpuesto
            {
                IdItems = "2",
                CodigoImpuesto = "01",
                BaseImpuesto = 1000,
                TarifaImpuesto = "8",
                ValorImpuesto = 80
            });

            Nota.Cabecera = CabeceraNota;
            Nota.Observaciones = Observacion;
            Nota.Items = DetalleNota;
            Nota.ItmsImpuestos = Impuestos;
            return Nota;

        }


    }
}
