using System.Collections.Generic;

namespace TuFactura.co.Modelo
{
    public class Suscriptor
    {
        public string Tipo { get; set; }
        public string CodigoTipo { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Documento { get; set; }
        public string Div { get; set; }
        public string Id { get; set; }
        public string Direccion { get; set; }
        public string CodigoDepartamento { get; set; }
        public string Departamento { get; set; }
        public string CodigoCiudad { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPais { get; set; }
        public string CodigoArea { get; set; }
        public string GenerarPdf { get; set; }
        public string ServicioIntegrador { get; set; }
        public string ServicioFacturar { get; set; }
        public List<Resoluciones> Resoluciones { get; set; }

       public  Suscriptor()
        {
            Resoluciones = new List<Resoluciones>();
        }

        //
    }
}
