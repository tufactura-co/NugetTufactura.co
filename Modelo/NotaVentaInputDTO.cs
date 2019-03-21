using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear Una Nota Débito/Crédito de Venta incluyendo los datos de la solicitud.
    /// </summary>
    public class NotaVentaInputDTO
    {
        /// <summary>
        /// Objeto que carga las propiedades de la Solicitud
        /// </summary>
        [Display(Name = "Objeto Solicitud")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public Solicitud Solicitud { get; set; }
        /// <summary>
        /// Carga  Todos los Objetos que componen la Nota Débito/Crédito de Venta
        /// </summary>
        [Display(Name = "Objeto Nota Debito/Credito")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public NotaVenta NotaVenta { get; set; }
    }
}
