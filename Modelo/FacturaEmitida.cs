using System;

namespace TuFactura.co.Modelo
{
    public class FacturaEmitida
    {
        public FacturaRecibida FacturaRecibida { get; set; }
        public FacturaGenerada FacturaGenerada { get; set; }

       public FacturaEmitida()
       {
            FacturaRecibida = new FacturaRecibida();
            FacturaGenerada = new FacturaGenerada();
       }
    }
  

    public class FacturaRecibida
    {
        public string Consecutivo { get; set; }
        public string FactId { get; set; }
        public string NonceInterno { get; set; }
        public string EstadoTrazabilidad { get; set; }
        public bool Estado { get; set; }
    }

    public class FacturaGenerada
    {
        public string FactId { get; set; }
        public string DocumentoTipo { get; set; }
        public string NonceInterno { get; set; }
        public string Suscriptor { get; set; }
        public string FacturaNumero { get; set; }
        public string FacturaCufe { get; set; }
        public string NotaBase64 { get; set; }
        public DateTime? DocumentoCreado { get; set; }
        public DateTime? DocumentoCambio { get; set; }
        public string DocumentoEstado { get; set; }
        public string FactPdfBase64 { get; set; }
        public string FactXMLBase64 { get; set; }
        public string FactNombreArchivo { get; set; }
        public string FactQRBase64 { get; set; }
        public string EstadoTrazabilidad { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
        public string FacturaPrefijo { get; set; }
    }
}
