using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear Una Factura de Venta incluyendo los datos de la solicitud.
    /// </summary>
    public class FacturaInput
    {
        /// <summary>
        /// Objeto que carga las propiedades de la Solicitud
        /// </summary>
        [Display(Name = "Objeto Solicitud")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public Solicitud Solicitud { get; set; }
        /// <summary>
        /// Objeto que carga Todos los Objetos que componen la factura de Venta
        /// </summary>
        [Display(Name = "Objeto FacturaVenta")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public FacturaVenta FacturaVenta { get; set; }

        public FacturaInput()
        {
            Solicitud = new Solicitud();
            FacturaVenta = new FacturaVenta();
        }
    }
}
