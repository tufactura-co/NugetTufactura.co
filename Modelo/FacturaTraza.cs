using System;
using System.Collections.Generic;

namespace TuFactura.co.Modelo
{
    public  class FacturaTraza
    {
        public string FactId { get; set; }
        public DateTime? FacturaFechaRecibida { get; set; }
        public DateTime? FacturaFecha { get; set; }
        public string FacturaNumero { get; set; }
        public long TrazaCodigo { get; set; }
        public string TrazaNombre { get; set; }
        public string TrazaDescripcion { get; set; }
        public long FacturaResolucion { get; set; }
        public DateTime? FacturaFechaRechazoAceptacion { get; set; }
        public string FacturaMotivoRechazo { get; set; }
        public long Tercero { get; set; }
        public DateTime? FacturaFechaCambio { get; set; }
        public string FacturaReferencia10 { get; set; }
        public List<FacturaTrazabilidad> FacturaTrazabilidad { get; set; }
        public FacturaTraza()
        {
            FacturaTrazabilidad = new List<FacturaTrazabilidad>();
        }

    }
    public class FacturaTrazabilidad
    {
        public DateTime? FechaTrazabilidad { get; set; }
        public long CodigoTrazabilidad { get; set; }
        public string NombreTrazabilidad { get; set; }
        public string DescripcionTrazabilidad { get; set; }
        public string NonceClienteTrazabilidad { get; set; }
    }
}
