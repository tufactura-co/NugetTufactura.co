using System;

namespace TuFactura.co.Modelo
{
    public class NotaEmitida
    {
        public NotaRecibida NotaRecibida { get; set; }
        public NotaGenerada NotaGenerada { get; set; }
        public NotaEmitida()
        {
            NotaRecibida = new NotaRecibida();
            NotaGenerada = new NotaGenerada();
        }
    }
    public class NotaRecibida
    {
        public string NotaId { get; set; }
        public string NottId { get; set; }
        public string NotaConsecutivo { get; set; }
        public string Nonce { get; set; }
        public string EstadoTrazabilidad { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
    }

    public class NotaGenerada
    {
        public string NotaId { get; set; }
        public string DocumentoTipo { get; set; }
        public string NonceInterno { get; set; }
        public string Suscriptor { get; set; }
        public string NotaNumero { get; set; }
        public string FacturaNumero { get; set; }
        public string FacturaCufe { get; set; }       
        public DateTime DocumentoCreado { get; set; }
        public DateTime DocumentoCambio { get; set; }
        public string DocumentoEstado { get; set; }
        public string EstadoTrazabilidad { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
        public string NotaPrefijo { get; set; }

    }
}
