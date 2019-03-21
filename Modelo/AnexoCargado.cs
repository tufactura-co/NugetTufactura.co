namespace TuFactura.co.Modelo
{
    public class AnexoCargado
    {

        public string DocId { get; set; }
        public bool Estdo { get; set; }
        public string EstadoDocumento { get; set; }
        public int AdjuntosNotificadosCargados { get; set; }
        public int AdjuntosCargados { get; set; }
        public int AdjuntosNotificadosTotales { get; set; }
        public int AdjuntosTotales { get; set; }
        public string Observacion { get; set; }
    }
}
