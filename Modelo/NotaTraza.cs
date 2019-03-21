using System;
using System.Collections.Generic;

namespace TuFactura.co.Modelo
{
    public  class NotaTraza
    {
        public string FactId { get; set; }
        public string NotaId { get; set; }
        public DateTime? NotaFechaRecibida { get; set; }
        public DateTime? NotaFecha { get; set; }
        public string NotaNumero { get; set; }
        public long TrazaCodigo { get; set; }
        public string TrazaNombre { get; set; }
        public string TrazaDescripcion { get; set; }
        public long NotauraResolucion { get; set; }
        public DateTime? NotaFechaRechazoAceptacion { get; set; }
        public string NotaMotivoRechazo { get; set; }
        public long Tercero { get; set; }
        public DateTime? NotaFechaCambio { get; set; }
        public string NotaReferencia1 { get; set; }
        public List<FacturaTrazabilidad> FacturaTrazabilidad { get; set; }

        public NotaTraza()
        {
            FacturaTrazabilidad = new List<FacturaTrazabilidad>();
        }


    }
}
